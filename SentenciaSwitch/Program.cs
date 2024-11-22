// See https://aka.ms/new-console-template for more information
class MyClass
{
    static void Main(string[] args)
    {
        string m = "NO";
        switch (m)
        {
            case "dos":
                Console.WriteLine("buena seleccion");
                break;
            default:
                Console.WriteLine("fuera de rango");
                break;
        }
        int num = 3;
        switch ( num)
        {
            case > 0 and < 4:
                Console.WriteLine("booom");
                break;
            case 4 or 7:
                Console.WriteLine("4 O 7");
                break ;
            case 6:
            case 5:
                Console.WriteLine("bingo");
                break ;
            default:
                break;
        }
    }

}