// See https://aka.ms/new-console-template for more information
class MyClass
{
    static void Main(string[] args)
    {
        try
        {
            Cider cider = new Cider()
            {
                Name = "Thachers",
                //Brand = "Gold"
            };
            Console.WriteLine(cider);
        }
        catch (ExceptionSidra ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        

    }
    public class ExceptionSidra : Exception
    {
        public ExceptionSidra():base("El nombre o la marca son nulos"){}
    }
    public class Cider
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public override string ToString()
        {
            if (Name==null || Brand== null)
            {
                throw new ExceptionSidra();

            }
            return $"Name: {Name} Brand: {Brand}"; 
        }
    }
}
