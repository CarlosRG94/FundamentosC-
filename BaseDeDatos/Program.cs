// See https://aka.ms/new-console-template for more information
using BaseDeDatos;
using System.Data.Common;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            BeerDb db = new BeerDb("MSI", "CsharpDb", "sa", "123456");
            bool again = true;
            int op = 0;
            do
            {
                Menu();
                Console.WriteLine("Elige una opcion");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1  :Show(db) ; break;
                    case 2 :Add(db) ; break;
                    case 3 :Edit(db) ; break;
                    case 4 :Delete(db) ; break; 
                    case 5 : again = false ; break;
                }
            } while (again);
           
        }
        catch (SqlException ex)
        {
            Console.WriteLine("No pudimos conectarnos");
        }
    }
    public static void Menu()
    {
        Console.WriteLine("\n----------Menu----------");
        Console.WriteLine("1.- Mostrar");
        Console.WriteLine("2.- Agregar");
        Console.WriteLine("3.- Editar");
        Console.WriteLine("4.- Eliminar");
        Console.WriteLine("5.- Salir");
    }
    public static void Show(BeerDb beerDb)
    {
        Console.Clear();
        Console.WriteLine("Aqui se muestran las cervezas");
        List<Beer> list = beerDb.GetAll();
        foreach (var beer in list)
        {
            Console.WriteLine($"Nombre:{beer.Name}  BrandId:{beer.BrandId}");
        }
    }
    public static void Add(BeerDb beerDb)
    {
        Console.Clear();
        Console.WriteLine("Agregar nueva cerveza");
        Console.WriteLine("Escribe el nombre");
        string name = Console.ReadLine();
        Console.WriteLine("Escribe el id de la marca");
        int id = int.Parse(Console.ReadLine());
        Beer beer = new Beer(name,id);
        beerDb.Add(beer);
        
    }
    public static void Edit(BeerDb beerDb) {
        Console.Clear(); 
        Show(beerDb);
        Console.WriteLine("Editar cerveza");
        Console.WriteLine("Escribe el Id de tu cerveza a editar");
        int id = int.Parse(Console.ReadLine());
        
        Beer beer = beerDb.Get(id);
        if (beer!=null)
        {
            Console.WriteLine("Escriba el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Escriba el brandId");
            int brandid = int.Parse(Console.ReadLine());
            beer.Name = name;
            beer.BrandId = brandid;
            beerDb.Edit(beer);
        }
        else
        {
            Console.WriteLine("No existe le ID");
        }
        
    }
    public static void Delete(BeerDb beerDb)
    {
        Console.Clear();
        Show(beerDb);
        Console.WriteLine("Eliminar cerveza");
        Console.WriteLine("Escribe el Id de tu cerveza a eliminar");
        int id = int.Parse(Console.ReadLine());

        Beer beer = beerDb.Get(id);
        if (beer != null)
        {
         beerDb.Delete(id);
        }
        else
        {
            Console.WriteLine("No existe le ID");
        }
    }
}