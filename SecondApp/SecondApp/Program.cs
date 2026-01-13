// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

double radius, Area;

Console.WriteLine("Enter radius = ");
radius = Console.ReadLine();
Area = Math.PI * radius * radius;
Console.WriteLine("The area is = " + Area);