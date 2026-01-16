using System;
using System.Formats.Asn1;
using System.Net.Http.Headers;

class Program
{
    static void CalculateArea()
    {
        Console.WriteLine("Enter the length = ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width = ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = Convert.ToDouble(length * width);

        Console.WriteLine("Area = " + area + " cm^2");
    }

    static void Main(string [] args)
    {
        CalculateArea();
    }
}