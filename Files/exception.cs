using System;

try
{
    int[] numbers = {1,2,3};

    Console.WriteLine(numbers[4]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}