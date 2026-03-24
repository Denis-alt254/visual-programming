using System;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

interface IAnimal
{
    void MakeSound();
    void Move();
}

public abstract class Animal: IAnimal
{
    public string Name{get; set;}

    public void Move() => Console.WriteLine("Animal is moving");
    public abstract void MakeSound();
    
}

public class Dog: Animal
{
    public override void MakeSound() => Console.WriteLine("Dog barks: Woof!");
}

public class Cat: Animal
{
    public override void MakeSound() => Console.WriteLine("Cat meows: Meow!");
}

class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.MakeSound();
        dog.Move();

        cat.MakeSound();
        cat.Move();
    }
}