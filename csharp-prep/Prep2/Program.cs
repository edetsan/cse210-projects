using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        string percentage = Console.ReadLine();
        int percentagenum = int.Parse(percentage);

        string letter = "";

        if (percentagenum >= 90)
        {
           letter = "A";
        }
        else if (percentagenum >= 80)
        {
            letter = "B";
        }
        else if (percentagenum >= 70)
        {
            letter = "C";
        }
        else if (percentagenum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}"); 

        if (percentagenum >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass, keep trying!");
        }
    }
}