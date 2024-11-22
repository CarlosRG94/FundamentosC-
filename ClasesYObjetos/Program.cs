// See https://aka.ms/new-console-template for more information
class Programa
{

    static void Main(string[] args)
    {
        Sale sale = new Sale(100,DateTime.Now);
        Sale sale1 = new Sale(200,DateTime.Now);
        Console.WriteLine(sale1.GetInfo()); 
        Console.WriteLine(sale.GetInfo());
        sale.Show();

    }

}
//Creamos la clase sale
//Dentro creamos un metodo publico(se puede acceder fuera de la clase)
//y no regresa nada este metodo por eso es void
/*Luego se crean dos variables y si queremos que estas propiedas sean obligatorias
 * para el objeto se crea un constructor para hacerlo se crea un metodo con 
 * el nombre de la clase con los parametros del metodo que son el mismo tipo de dato 
 * que las declaradas fuera y se igualan los dos por lo que this.total que es el total
 * declarado fuera sea igual al que te pide el constructor por los parametros
 */
class Sale
{
    int total;
    DateTime date;
    public Sale(int total , DateTime date)
    {
        this.total = total;
        this.date = date;
    }
    public string GetInfo()
    {
        return total + "" + date.ToLongDateString();

    }

    public void Show() 
    {
        Console.WriteLine("Aquí hemos mostrado el número de ventas y la fecha");
    }
}
