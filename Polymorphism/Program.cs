use System;
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("The animal make sound.");
    }
}

class Dog: Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog burks");
    }
}

class Engine
{
    static void Main(string [] args)
    {
        Animal myanimal = new Animal();
        Animal dog = new Dog();

        myanimal.Sound();
        dog.Sound();
    }
}