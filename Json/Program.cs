// See https://aka.ms/new-console-template for more information
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        Beer beer = new Beer()
        {
            Brand = "Paulaner", Name = "Rubia" 
        };
      
       //tring json = "{\"Brand\":\"Pualaner\",\"Name\":\"Rubia\"}";

       string json = JsonSerializer.Serialize(beer);

        Beer beer1 = JsonSerializer.Deserialize<Beer>(json);

        Beer[] beers = new Beer[]
        {
            new Beer()
            {
                Brand ="Mohue", Name = "Negra"
            },
            new Beer(){
                Brand = "Any", Name = "NoName"
            }

        };
        /* string jsons = "["+
             "{\"Brand\":\"Mouhe\",\"Name\":\"Negra\"}"+
             "{\"Brand\":\"Any\",\"Name\":\"NoName\"}"+
             "]";
        */
        string json2 = JsonSerializer.Serialize(beers);
        Beer[] beers1 = JsonSerializer.Deserialize<Beer[]>(json2);

    }
}
public class Beer
{
    public string Brand { get; set; }
    public string Name { get; set; }
}
