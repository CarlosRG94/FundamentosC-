// See https://aka.ms/new-console-template for more information
using System.Collections;

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(1);
//Elimina el elemento por el valor no por la posicion del array
//Si tienes varios elementos con el mismo valor solo elimina el primero
numbers.Remove(1);

HashSet<int> eventNumbers = new HashSet<int>();
HashSet<int> oddNumbers = new HashSet<int>();

Hashtable hashtable = new Hashtable();
hashtable.Add(1,"1");
hashtable.Add(2,"2");
hashtable.Add(3,"3");
hashtable.Add(4,"4");
//El key tiene que ser unico pero los valores se pueden repetir

Dictionary<int,string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "1");
dictionary.Add(2, "2");
dictionary.Add(3, "3");
dictionary.Add(4, "4");

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(10);
queue.Enqueue(11);
queue.Dequeue();
queue.Dequeue();

Stack<int> stack = new Stack<int>();
stack.Push(12);
stack.Push(34);
stack.Push(65);
stack.Pop();


foreach (var number in numbers)
{
    Console.WriteLine(number);
}

for (int i = 2; i < 10; i = i+2)
{
    eventNumbers.Add(i);
}
for (int i = 1; i < 10; i = i+2)
{
    oddNumbers.Add(i);
}
foreach (var number in eventNumbers)
{
    Console.WriteLine($"Numeros pares:{number}");
}
foreach (var number in oddNumbers)
{
    Console.WriteLine($"Numeros impares:{number}");
}

foreach (var number in hashtable.Values)
{
    Console.WriteLine(number);
}
foreach (var number in dictionary.Values)
{
    Console.WriteLine(number);
}
foreach (var number in queue)
{
    Console.WriteLine(number);
}
foreach (var number in stack)
{
    Console.WriteLine(number);
}
