// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        Console.WriteLine(list.Count);
        list.Remove(1);
        Console.WriteLine(list.Count);
        List<int> list2 = new List<int>()
        {
            1,2,3,4,5,6,7
        };
        Console.WriteLine(list2.Count);
        list2.Clear();
        Console.WriteLine(list2.Count);
        list2.Add(2);
        List<string> list3 = new List<string>()
        {
            "Alpha","Beta","Delta"
        };
        Console.WriteLine(list3.Count);
    }
}