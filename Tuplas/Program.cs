// See https://aka.ms/new-console-template for more information
(string Name, int Id) persona = ("Carlos", 34);
Console.WriteLine($"Datos del cliente{persona.Name}{persona.Id}");
persona.Name = "Pepe";
Console.WriteLine(persona.Name);
var persona2 = ("Paco", "dentista", 32);
Console.WriteLine($"Datos del segundo cliente " +
    $"; {persona2.Item1} {persona2.Item2} {persona2.Item3}");
var clientes = new[]
{
    ("Antonio",25,"Valencia",DateTime.Now),
    ("Javi",35,"Albacete",DateTime.Now),
    ("Jose",37,"Albacete",DateTime.Now)
};
Console.WriteLine("Mostramos la lista de clientes");
foreach (var cliente in clientes)
{
    Console.WriteLine($"{cliente.Item1} {cliente.Item2} {cliente.Item3} {cliente.Now}");
}
(string Name, int Id)[] clientes2 = new[]
{
     ("Antonio",25),
    ("Javi",35),
    ("Jose",37)
};
foreach (var cliente2 in clientes2)
{
    Console.WriteLine($"{cliente2.Name}{cliente2.Id}");
}
 (float lngt, int lat, string city) getLocation()
{
    float lngt = 1.23423f;
    int lat = 2;
    string city = "Bristol";
    return (lngt,lat,city);
}
var clientes3 = getLocation();
Console.WriteLine($"long:{clientes3.lngt}lat:{clientes3.lat}city:{clientes3.city}");
var (_,lat,_)= getLocation();
Console.WriteLine(lat);

