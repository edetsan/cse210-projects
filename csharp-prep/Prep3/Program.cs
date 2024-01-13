using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); //Random number
        int random_number = randomGenerator.Next(1, 101);

        int user_number = -1;
        int tries = 0;

        while (user_number != random_number)
        {
            Console.Write("What's the magic number?: ");
            user_number = int.Parse(Console.ReadLine());

            if (user_number == random_number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {tries} tries");
                break;
            }
            else if (user_number < random_number)
            {
                Console.WriteLine("Higher");
            }
            else if (user_number > random_number)
            {
                Console.WriteLine("Lower");
            }

            tries++;
        }
        
    }
}