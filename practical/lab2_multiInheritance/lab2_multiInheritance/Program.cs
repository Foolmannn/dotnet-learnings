using System;
using System.Text;

interface IStudent
{
    void DisplayStudent();
}

interface IAddress
{
    void DisplayAddress();
}

class Student : IStudent, IAddress
{
    public void DisplayStudent()
    {
        Console.WriteLine("Student Name: Suman");
        Console.WriteLine("Student ID: 2010");
    }

    public void DisplayAddress()
    {
        Console.WriteLine("Address: Kathmandu");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.DisplayStudent();
        s.DisplayAddress();

        Console.WriteLine("\n\tBy Suman Pun Magar");
    }
}


