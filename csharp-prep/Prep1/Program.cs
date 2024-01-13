using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your second name");
        string secondname = Console.ReadLine();

        Console.WriteLine($"Your name is {secondname}, {firstname} {secondname}.");

    }
}