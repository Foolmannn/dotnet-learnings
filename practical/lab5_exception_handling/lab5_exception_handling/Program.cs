using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Product Price: ");

            string input = Console.ReadLine();

            decimal price = decimal.Parse(input);

            Console.WriteLine(
                "Product Price: " + price);
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Invalid Input! Enter a numeric price.");
        }
        catch (OverflowException)
        {
            Console.WriteLine(
                "Price is too large or too small.");
        }
        finally
        {
            Console.WriteLine(
                "Program execution completed.");
        }

        Console.WriteLine("\n\tBy Suman Pun Magar");
    }
}
