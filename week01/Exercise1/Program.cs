using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String name = Console.ReadLine();

        Console.Write("What is your last name? ");
        String last_name = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your name is {last_name}, {name} {last_name}.");
    }
}