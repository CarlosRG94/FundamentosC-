// See https://aka.ms/new-console-template for more information
class Myclass
{
    static void Main(string[] args)
    {
        var beers = new List<Beer>()
        {
            new Beer(){Name = "Paulaner", Country = "Germany", Strength = 4.5f},
            new Beer(){Name = "Alhambra", Country = "Spain", Strength = 4.7f},
            new Beer(){Name = "Corona", Country = "Mexico", Strength = 5.2f}

        };
        var countries = new List<Country>()
        {
            new Country(){Name ="Germany", Continent ="Europe"},
            new Country(){Name ="Spain", Continent ="Europe" },
            new Country(){Name ="Mexico", Continent = "America"}
        };
        var beercountry = from beer in beers
                          join country in countries
                          on beer.Country equals country.Name
                          select new
                          {
                              Name = beer.Name,
                              Country = beer.Country,
                              Continent = country.Continent,
                              Strength = beer.Strength

                          };
        foreach (var beer in beercountry)
            Console.WriteLine($"{beer.Name} {beer.Country} " +
                $" {beer.Continent} {beer.Strength}");
        
    }
}
public class Beer
{
    public string Name { get; set; }
    public string Country { get; set; }
    public float Strength { get; set; }
}
public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }

}