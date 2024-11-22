// See https://aka.ms/new-console-template for more information
class Program
{
    static async Task Main(string[] args)
    {
        var task = new Task(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("La tarea interna del task");
        });
        task.Start();
        var task2 = new Task(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("La tarea interna del task2");
        });
        task2.Start();
        Console.WriteLine("Imprime mientras trabajan los task");
        await task;
        await task2;
        int resultmult = await MultAsync(7);
        Console.WriteLine(resultmult);
        Console.WriteLine("La tarea ha terminado");
    }
    public static async Task<int> MultAsync(int num)
    {
        int num2 = 5;
        var task = new Task<int>(() => num * num2);
        task.Start();
        int result = await task;
        return result;
    }
}   
