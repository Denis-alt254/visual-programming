using System; // Provides basic functionality like Console
using System.Threading.Tasks;

class Program
{
    static async Task Task1()
    {
        Console.WriteLine("Task 1 started.");
        await Task.Delay(2000);
        Console.WriteLine("Task 1 finished");
    }

    static async Task Task2()
    {
        Console.WriteLine("Task 2 started.");
        await Task.Delay(2000);
        Console.WriteLine("Task 2 finished");
    }
    
    static async Task Task3()
    {
        Console.WriteLine("Task 3 started.");
        await Task.Delay(1000);
        Console.WriteLine("Task 3 finished");
    }

    static async Task Main(string [] args)
    {
        await Task.WhenAll(Task1(), Task2(), Task3());
        Console.WriteLine("All Tasks done");
    }
}