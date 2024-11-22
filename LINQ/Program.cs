// See https://aka.ms/new-console-template for more information
class Myclass
{
    static void Main(string[] args)
    {
        List<Cider> ciders = new List<Cider>() 
        {
            new Cider() {Name="Thatchers",Country="England" },
            new Cider() {Name="El gaitero",Country ="Spain"},
            new Cider() {Name="Kopalberg",Country="Sweden"}

        };
        foreach (var cider in ciders)
            Console.WriteLine(cider);

        Console.WriteLine("......................");
        //select
        var cidername = from c in ciders
                        select new {
                           Name = c.Name,
                           Letters = c.Name.Length,
                           Quality = "Best"
                        };
        foreach (var cider in cidername)
            Console.WriteLine(cider);
        Console.WriteLine("..................");
        foreach (var cider in cidername)
            Console.WriteLine($"{cider.Name} {cider.Letters}" +
                $" {cider.Quality}");
        Console.WriteLine(".....................");
        var realname = from c in cidername
                       select new
                       {
                           Name = c.Name
                       };
        foreach (var item in realname)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("................");
        var ciderEngland = from c in ciders
                           where c.Country == "England"
                           || c.Country ==  "Spain"
                           select c;
        foreach (var item in ciderEngland)
            Console.WriteLine(item);
        Console.WriteLine(".................");
        var orderedCider = from c in ciders
                           orderby c.Name ascending
                           select c;
        foreach (var item in orderedCider)
            Console.WriteLine(item);


       

    }
}
public class Cider
{
    public string Name { get; set; }
    public string Country { get; set; }
    public override string ToString()
    {
        return $"Name: {Name} Country: {Country}";
    }
}
