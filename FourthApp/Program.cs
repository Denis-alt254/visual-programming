using System;

class Program
{  
    static void Main(string[] args)
    { 
    double radius, height, volume;
    double CalculateVolume()
    {
        Console.WriteLine("Enter radius = ");
        radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height = ");
        height = Convert.ToDouble(Console.ReadLine());
        volume = Math.PI * radius * radius * height;
        volume = Math.Round(volume, 2);
        Console.WriteLine("The volume is = " + volume + " cm^3");
        return 0;
    }
    
    CalculateVolume();
    }
    
}