class Program
{
    static void Main(string[] args)
    {
        dynamic something = 1;
        Console.WriteLine(something.GetType());
        something = "Pato";
        Console.WriteLine(something.GetType());
        something = new Drunked() { Name = "Carlos" };
        Console.WriteLine(something.Name);
        ShowMagic(1, 2);
        ShowMagic("Madrid", "Gana");

    }
    static void ShowMagic(dynamic a, dynamic b)
    {
        Console.WriteLine(a + b);
    }
}
public class Drunked
{
    public string Name { get; set; }
    public string Description { get; set; }
}
