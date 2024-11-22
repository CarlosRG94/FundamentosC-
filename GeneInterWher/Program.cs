// See https://aka.ms/new-console-template for more information
using GeneInterWher;

var carlos = new Drunked() { Name = "Carlos"};
var paco = new Drunked() { Name = "Paco" };
var terminator = new Terminator<Drunked>();
var nuevocarlos = terminator.Kill(false, carlos);
var nuevopaco = terminator.Kill(true, paco);
var survivors = terminator.GetPrisioners();
Console.WriteLine(survivors);
