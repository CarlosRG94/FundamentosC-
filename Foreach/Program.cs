// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>()
        {
            1,2, 3, 4, 5, 6, 7,
        };
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
        var personas = new List<Persona>() {
        new Persona() { City = "Granada", Name = "Carlos" },
        new Persona() { City = "Bristol", Name = "Paco" },
        new Persona() { City = "Londres", Name = "Antonio" },
        };
       
        Show(personas);
    }
    static void Show(List<Persona> personas) 
    {
        Console.WriteLine("Mostramos las personas:");
        foreach (var persona in personas)
        {
            Console.WriteLine($"Nombre: {persona.Name} Ciudad: {persona.City}");
        }
    }
}
public class Persona
{
    public string City { get; set; }
    public string Name { get; set; }
}