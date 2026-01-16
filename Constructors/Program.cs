using System;
using System.Drawing;

class Car
{
    public string model, color;
    public int year;
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
}

class Program
{
    static void Main(string [] args)
    {
        Car car1 = new Car("Mazda", "Red", 2020);
        Car car2 = new Car("Ford", "Grey", 2022);

        Console.WriteLine(car1.model+ " with color " + car1.color + " for year " + car1.year);
        Console.WriteLine(car2.model+ " with color " + car2.color + " for year " + car2.year);
    }
}