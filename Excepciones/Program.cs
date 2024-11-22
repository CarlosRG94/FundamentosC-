// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        try
        {
            string content = File.ReadAllText(@"C: \Users\carli\Documentos\DxDiag.txt");
            Console.WriteLine(content);
            string content2 = File.ReadAllText(@"C:\Users\carli\Escritorio\nose.txt");
            Console.WriteLine(content2);
            throw new Exception("Esto e mu raro ");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("No esta en el sistema");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Pues nada que no puedo acceder a la npta que no decia naada");
        }
        Console.WriteLine("Continua");
    }
 
}
