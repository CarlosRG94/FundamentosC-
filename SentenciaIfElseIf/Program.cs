// See https://aka.ms/new-console-template for more information
class Comida
{
    static void Main(string[] args)
    {
        bool areYouHungry = true;
        bool youHaveMone = false;

        if (areYouHungry && youHaveMone)
        {
            Console.WriteLine("Come");
        }
        else if (areYouHungry || youHaveMone && IsOpenRestaurant("Casa paco", 8))
        {
            Console.WriteLine("En Casa paco se come como sea");
        }
        else
        {
            Console.WriteLine("No comes");
        }   
    }
    //Creamos una funcion que devuelve un tipo de dato booleano
    //Declaramos un tipo de dato string y otro entero en sus parametros
    //Esos datos los usamos en el condicional 
    static bool IsOpenRestaurant(string restaurant, int hora = 0)
    {
        if (hora > 2 && hora < 10 && restaurant == "Casa paco")
        {
            return true;
        }
        else if (restaurant == "telepizza")
        {
            return true;
        }
        else
        {
            return false;
        }


    }

}