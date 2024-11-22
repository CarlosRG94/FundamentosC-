// See https://aka.ms/new-console-template for more information
class Program 
{
    static void Main(string[] args)
    {
        People people = new People()
        {
            Name = "paco",
            Id = 1

        };
        People people1 = new People()
        {
            Id = 2,
            Name = "Antonio"
        };
        People people2 = new People()
        {
            Name = "Pepe"

        };
        Console.WriteLine(People.Cadena());
          

        Console.WriteLine(People.Count);
    }
}
public class People
{
    public static int Count=0;
    public int Id { get; set; }
    public string Name { get; set; }
    public People()
    {
        Count++;
    }
    public static string Cadena()
    {
        return "Hay"+Count+"objetos de la clase people";
    }
}
