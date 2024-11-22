using BD;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        DbContextOptionsBuilder<CsharpDbContext> optionsBuilder
            = new DbContextOptionsBuilder<CsharpDbContext>();
        optionsBuilder.UseSqlServer("Server=MSI; Database=CsharpDb; " +
            "User=sa; Password=123456");

        bool again = true;
        int op = 0;
        do
        {
            ShowMenu();
            Console.WriteLine("Elige una opcion");
            op= int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: 
                    Show(optionsBuilder); 
                    break;
                case 2:
                    Add(optionsBuilder);
                    break ;
                case 3:
                    Edit(optionsBuilder);
                    break;
                case 4:
                    Delete(optionsBuilder);
                    break;
                case 5: 
                    again= false; 
                    break;
            }
        } while (again);
        
    }
    public static void Show(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
    {
        Console.Clear();
        Console.WriteLine("Muestra la lista de las cervezas");
        using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options))
        {
            List<Beer> beers2 = (from b in context.Beers
                                 where b.BrandId == 2
                                orderby b.Names
                                select b).Include(b=>b.Brand).ToList();

            foreach (var beer in beers2)
            {
                Console.WriteLine($"{beer.Id} - {beer.Names} - {beer.Brand.Name}");
            }
        }
    }
    public static void Add(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
    {
        Console.Clear();
        Console.WriteLine("Agregar nueva cerveza");
        Console.WriteLine("Escribe el nombre");
        string name = Console.ReadLine();
        Console.WriteLine("Escribe el Id de la marca");
        int id = int.Parse(Console.ReadLine());
        using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options))
        {
            Beer beer = new Beer()
            {
                Names = name,
                BrandId = id
            };
            context.Add(beer);
            context.SaveChanges();

        }
    }
    public static void Edit(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
    {
        Console.Clear();
        Show(optionsBuilder);
        Console.WriteLine("Elige una cerveza a editar");
        int id = int.Parse(Console.ReadLine());
        using (var context = new CsharpDbContext(optionsBuilder.Options))
        {
            Beer beer = context.Beers.Find(id);
            if (beer != null)
            {
                Console.WriteLine("Escribe el nombre de la cerveza");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la marca");
                int brandId = int.Parse(Console.ReadLine());
                beer.Names = name;
                beer.BrandId = brandId;
                context.Entry(beer).State = EntityState.Modified;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }
    }
    public static void Delete(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
    {
        Console.Clear();
        Show(optionsBuilder);
        Console.WriteLine("Escribe el id de la cerveza a eliminar");
        var id = int.Parse(Console.ReadLine());
        using (var context = new CsharpDbContext(optionsBuilder.Options))
        {
            Beer beer = context.Beers.Find(id);
            if (beer!= null)
            {
                context.Remove(beer);
                context.SaveChanges();
            }
            else 
            {
                Console.WriteLine("La cerveza no existe");
                    
            }

        }
    }
    public static void ShowMenu() 
    {
        Console.WriteLine("\n-------Menu---------");
        Console.WriteLine("1.Mostrar");
        Console.WriteLine("2.Agregar");
        Console.WriteLine("3.Editar");
        Console.WriteLine("4.Eliminar");
        Console.WriteLine("5.Salir");
    }
}