// See https://aka.ms/new-console-template for more information
//Creamos una variable inicializada en cero
//entra en un bucle y mientras rep la variable sea menor que 10 muestre un texto
//cada vez que entra en el bucle se le suma una a la variable hasta que llega a diez
int rep = 0;
while (rep < 10)
{
    Console.WriteLine("repeticion"+rep);
    rep++;  
}
//Aqui se crea un array para que el bucle haga un recorrido x ese array
string[] num = new string[9]
{
   "cero","uno","dos","tres","cuatro","cinco","seis","siete","ocho"
};
int rec = 2;
while (rec < num.Length)
{
    Console.WriteLine("este numero es par " + num[rec]);
    rec= rec +2;
}
/*En este bucle el tipo de dato es un booleano inicializado en false
y el boocle entra primero una vez y evalua despues en el while
al estar inicalizado en falso solo entra una vez hasta que evalua
*/
bool run = false;
do
{
    Console.WriteLine("Solo corre una vez");
}
while (run);