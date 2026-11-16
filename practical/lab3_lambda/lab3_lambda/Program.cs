using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 2010, DepartmentId = 1,
                Name = "Suman", Address = "Chandragiri" },

            new Student { Id = 2000, DepartmentId = 2,
                Name = "Saman", Address = "Kathmandu" },

            new Student { Id = 2003, DepartmentId = 1,
                Name = "Aditya", Address = "Bhaktapur" },

            new Student { Id = 2004, DepartmentId = 3,
                Name = "Sishir", Address = "Lalitpur" },

            new Student { Id = 2005, DepartmentId = 2,
                Name = "Samir", Address = "Patan" }
        };

        Console.Write("Enter Department ID: ");

        int deptId = Convert.ToInt32(Console.ReadLine());

        var result = students.Where(s =>
            s.DepartmentId == deptId);

        Console.WriteLine("\nStudent List:");

        foreach (var s in result)
        {
            Console.WriteLine(
                $"ID: {s.Id}, Name: {s.Name}, " +
                $"Department: {s.DepartmentId}, " +
                $"Address: {s.Address}");
        }

        Console.WriteLine("\n\tBy Suman Pun Magar");
    }
}
