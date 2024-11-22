// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;

        Show();
        Show();
        Show();
        Sum(8, 5);
        int m = Mul(5, 6);
        Console.WriteLine(m);
        Console.WriteLine(Mul(6,6));

    }
    //Creamos la funcion pasandole dos variables de tipo entero
    //Esta funcion recibe la informacion del tipo de dato que declares en los parametros
    static void Sum(int num1, int num2)
    {
        int num3 = num1 + num2;
        Console.WriteLine(num3);
    }
    //Esta funcion no recibe ni devuelve nada
    static void Show()
    {
        Console.WriteLine("Hola me imprimo desde la funcion");

    }
    //Esta funcion devuelve un tipo de dato y tambien se le pasan unos parametros
    static int Mul(int num1, int num2) 
    {
        return num1 * num2; 
    }  






}