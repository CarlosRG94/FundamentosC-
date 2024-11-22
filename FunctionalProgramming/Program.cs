Operation mysum = Functions.Sum;
//Console.WriteLine(mysum(5,5));
mysum = Functions.Mult;
//Console.WriteLine(mysum(5,5));
Show show = Console.WriteLine;
show += Functions.ShowMessage;
//show("hola mundo");
Functions.Some("Antonio", "Ruiz", show);
#region Action
Action<string> showMessage = Console.WriteLine;
showMessage("Hola");
Functions.SomeAction("Carlos", "Ruiz", showMessage);
Action<string,string> sm =(a,b) => Console.WriteLine($"{a} {b}");
sm("Ahora", "Si");
Action<string, string, string> sm2 = (a, b, c) =>Console.WriteLine($"{a}{b}{c}");

sm2("Carlos", "Ruiz", "Gomez");
Functions.SomeAction("sabe", "u que", a =>{
    Console.WriteLine("Soy una expresion lamba" + a);
    });

#endregion
#region Func
Func<int> numberRandom = ()=>new Random().Next(0,100);
Func<int,int> numberRandomLimit =(limit)=>new Random().Next(0,limit);
Console.WriteLine(numberRandom());
Console.WriteLine(numberRandomLimit(60));
#endregion
#region Predicate
Predicate<string> hasSpaceorA = (word) => word.Contains(" ")||word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceorA("Beear"));
Console.WriteLine(hasSpaceorA("be er"));

var words = new List<string>()
{
    "beer",
    "patito",
    "sandia",
    "hola mundo",
    "c#"
};
var wordsnew = words.FindAll((w)=>!hasSpaceorA(w));
foreach(var word in wordsnew)Console.WriteLine(word);
#endregion
#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
#endregion
public class Functions
{
    public static int Sum(int a, int b)=> a+b;
    public static int Mult(int a, int b) =>a*b;
    public static void ShowMessage(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastName,Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola{name} {lastName}");
        Console.WriteLine("Hay algo al final");
    }
    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola{name} {lastName}");
        Console.WriteLine("Hay algo al final");
    }
}

