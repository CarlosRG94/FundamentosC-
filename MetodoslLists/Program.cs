// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7
        };
        Show(list);
        //El metodo insert de la clase list te permite insertar el valor que quieras
        //Se elige la posicion en el primer parametro de la funcion y el valor
        list.Insert(1, 6);
        Show(list);
        //La propiedad Count cuenta el numero de elemento de la lista
        Console.WriteLine($"Numero de elementos de la lista:{list.Count}");
        //El metodo contains compara si el dato ingresado con alguno de la lista
        if (list.Contains(2))
            Console.WriteLine("Existe");
        
        else Console.WriteLine("No existe");
        //Indexof te regresa la posicion que ocupa en la lista
        Console.WriteLine(list.IndexOf(1));
        int indice = list.IndexOf(6);
        Console.WriteLine(indice);
        indice = list.IndexOf(100);
        Console.WriteLine(indice);
        //Sort,este es un objeto mutable, un objeto string es inmutable para modificarlo
        //Se necesita igualar la variable 
        list.Sort();
        Show(list);
        string name = "Antonio";
        name.ToUpper();
        Console.WriteLine(name);
        name = name.ToUpper();
        Console.WriteLine(name);
        //AddRange une una lista con otra
        list.AddRange(new List<int>()
        {
            50,20,30
        });
        Show(list);
        var number = new List<int>() 
        { 
            60, 70, 80 
        };
        list.AddRange(number);
        Show(list);



    }
    public static void Show(List<int>numbers)
    {
        Console.WriteLine("Mostramos los numeros");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}
