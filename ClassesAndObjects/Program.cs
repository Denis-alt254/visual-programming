using System;
using System.ComponentModel.Design;

class Student
{
    public string name;
    public int marks;

    public void Reference()
    {
        string z = (marks>50)? "Good": "Work hard";
        Console.WriteLine(z);
    }
}

class Program
{
    static void Main(string [] args)
    {
        Student student1 = new Student();
        student1.name = "Denis";
        student1.marks = 80;
        Console.WriteLine(student1.name + " scored marks = " + student1.marks);
        student1.Reference();

        Student student2 = new Student();
        student2.name = "Mark";
        student2.marks = 40;
        Console.WriteLine(student2.name + " scored marks = " + student2.marks);
        student2.Reference();
    }
}