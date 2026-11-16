using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog said Bhau Bhau.");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat said meow meow.");
    }
}

class Program
{
    static void Main()
    {
        Animal a;

        a = new Dog();
        a.Sound();

        a = new Cat();
        a.Sound();

        Console.WriteLine("\n\tBy Suman Pun Magar.");
    }
}