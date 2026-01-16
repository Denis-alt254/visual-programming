using System;

class Program
{
    static void Main(string [] args)
    {
        int [] numbers = {1, 2, 3, 4, 5};

        Console.WriteLine("foreach loop");

        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("For loop");

        for(int j = 0; j< numbers.GetLength(0); j++)
        {
            Console.WriteLine(numbers[j]);
        }
    }
}