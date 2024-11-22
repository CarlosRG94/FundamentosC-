// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

int number = 2435;
Console.WriteLine(number);
double doubleNumber = 12.12222;
char character = 'a';
string name = "hector";
bool isDead = false;
Console.WriteLine(isDead);
//Los tipos de datos son objetos no son variables
//Estos vienen con un tipo de dato default
int number2 = new int();
Console.WriteLine(number2);
//Con el simbolo de interrogacion se puede hacer un tipo de dato null
int? number3 = new int?();
Console.WriteLine(number3);
//El objeto de la clase tiene distinto comportamiento y no se puede hacer null
var number4 = new Number();
Console.WriteLine(number4);

public class Number {
}
