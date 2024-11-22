// See https://aka.ms/new-console-template for more information
/*
 * Los tipos anonimos te permiten crear objetos pero son readonly
 * por lo que no se puede modificar, los atributos de este se declaran
 * al darle el valor automaticamente
 */

var person = new
{
    Name = "Juan",
    Ciudad ="Malaga",
    Edad = 40
};
Console.WriteLine($"Eston son los datos del objeto nombre:{person.Name}" +
    $"ciudad{person.Ciudad}edad{person.Edad}");
//Tambien se puede crear un array de objetos anonimos
//Imprimimos con un bucle for each cada atributo de cada objeto k recorre
var beer = new[]
{
    new{Name = "Jack",Graduacion=40 },
    new{Name = "San miguel",Graduacion = 5 }
};
foreach (var a in beer)
    Console.WriteLine($"Estas son las bebidas{a.Name}{a.Graduacion}");