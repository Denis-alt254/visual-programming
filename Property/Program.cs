using System;

namespace person
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string [] args)
        {
            Person myObj = new Person();
            myObj.Name = "Denis";
            Console.WriteLine(myObj.Name);
        }
    }
}