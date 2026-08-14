namespace CSharpLearning.Basics;

public class Strings
{
    public static void Run()
    {
        string firstName = "Suman";
        string lastName = "Pun";

        string fullName = firstName + " " + lastName;

        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Length: {fullName.Length}");
    }
}