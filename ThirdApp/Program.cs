using System;

class Program
{
    static void Main(string[] args)
    {
       double radius, Area;

        Console.WriteLine("Enter radius = ");
        radius = Convert.ToDouble(Console.ReadLine());
        Area = Math.PI * radius * radius;
        Console.WriteLine("The area is = " + Area + " cm^2");
    }
}
