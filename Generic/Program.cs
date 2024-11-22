// See https://aka.ms/new-console-template for more information
class Program 
{
    static void Main(string[] args)
    {
        MyList<int> number = new MyList<int>(5);
        number.Add(1);
        number.Add(2);
        
        MyList<string> name = new MyList<string>(5);
        name.Add("Morad");
        name.Add("John");
        MyList<People> people = new MyList<People>(5);
        people.Add(new People() { Id = 1 , Name="paco"});
        people.Add(new People() { Id = 3, Name = "pepe" });
        Console.WriteLine(number.GetNumber(1));
        Console.WriteLine(name.GetNumber(0));
        Console.WriteLine(name.GetLista());
        Console.WriteLine(number.GetLista());
        Console.WriteLine(people.GetLista());
    }
}
public class People
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
        return $"Identidad {Id} nombre {Name} ";
    }
}
public class MyList<T>
{
    private T[] _elementos;
    private int _index = 0;
    public MyList(int n)
    {
        _elementos = new T[n];
    }
    public void Add(T amount)
    {
        if (_index < _elementos.Length)
        {
            _elementos[_index] = amount;
            _index++;
        }
    }
    public T GetNumber(int a) 
    {
        if (a <= _index && a >= 0)
        {
            return _elementos[a];
        }
        else return default(T);
    }
    public string GetLista()
    {
        int i = 0;
        string result = "";
        while (i<_index)
        {
            result += _elementos[i].ToString()+"|";
            i++;
        }
        return result;
    }
   
}
