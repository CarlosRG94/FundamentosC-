// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Shark[] sharks = new Shark[]
        {
            new Shark("Nemo",2),
            new Shark("Predator", 4)
        };
        Ifish[] sirena = new Ifish[]
        {
            new Sirena(4),
            new Sirena(6),
            new Shark("Martillo",7)
        };
        Sirena[] sirena2 = new Sirena[]
        {
            new Sirena(5)
        };
        ShowFish(sharks);
        ShowAnimol(sharks);
        ShowFish(sirena);
        ShowFish(sirena2);


    }
    public static void ShowFish(Ifish[] fish)
    {
        Console.WriteLine("Mostramos los peces");
        int i = 0;
        while (i<fish.Length)
        {
            Console.WriteLine(fish[i].Swim());
            i++;
        }
    }
    public static void ShowAnimol(Ianimal[] animal)
    {
        Console.WriteLine("Mostramos los animales");
        int i = 0;
        while (i < animal.Length)
        {
            Console.WriteLine(animal[i].Name);
            i++;
        }
    }
}
public class Sirena : Ifish
{
    public int Speed { get; set; }
    public Sirena(int Speed)
    {
        this.Speed = Speed;
    }
    public string Swim()
    {
        return $"La sirena nada a {Speed} km/h";
    }
}
public class Shark : Ianimal, Ifish
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public Shark(string Name, int Speed)
    {
        this.Name = Name;
        this.Speed = Speed;
    }
    public string Swim()
    { 
        return $"Este pez llamado {Name} nada a {Speed} km/h";
    }

}
public interface Ianimal
{
    public string Name { get; set; }
}
public interface Ifish
{
    public int Speed { get; set; }
    public string Swim();
}
