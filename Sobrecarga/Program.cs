// See https://aka.ms/new-console-template for more information
class Myclass 
{
    static void Main(string[] args)
    {
        Math math = new Math();
        Console.WriteLine(math.Sum(1,2));
        Console.WriteLine(math.Sum("4","7"));
        int[] numbers = new int[] {2,4,8};
        Console.WriteLine(math.Sum(numbers));
        
    }
}
class Math 
{
    public int Sum(int a, int b) 
    {
        return a + b; 
    }
    public int Sum(string a, string b)
    {
        return int.Parse(a) + int.Parse(b);
    }
    public int Sum(int[] numbers) 
    {
        int suma = 0;
        int i = 0;
        while(i < numbers.Length)
        {
            suma+=numbers[i];
            i++;
        }
        return suma;
    }
    
}
