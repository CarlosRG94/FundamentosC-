// See https://aka.ms/new-console-template for more information
class Clase1
{
    static void Main(string[] args)
    {
        Sale sale = new Sale(120, DateTime.Now);
        
        Console.WriteLine(sale.Total);
        Console.WriteLine(sale.Date);
       
       
    }
}
//Las propiedades son como los atributos de la clase pero la diferencia
// es que tiene accesor que son get y set que permiten acceder leer y escribir
//Las propiedades publicas se escriben con mayuscula al inicio
//Se puede acceder al total y a la fecha estando privadas por el accesor
class Sale 
{
   private int total;
    private DateTime date;
    public string Date
    {
        get
        {
            return date.ToString();
        }
    }
    public int Total
    {
        get
        {
            return total;
        }
        set
        {
            if (value < 0)
                value = 0;
            total = value;
        }

    }
    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    } 
}
