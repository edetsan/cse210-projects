//for EXCEEDING REQUIREMENTS: The program will ask for a username and will save/load it in the textfile. When the user loads the textfile, the program will display a welcoming message. I added a counter to the Eternal goal and removed the brackets, so the user can know that it can't be checked and how many times the goal was accomplished
class Program
{
    static void Main(string[] args)
    {
       bool runProgram = true;
       Console.WriteLine("What's your name?: ");
       User user = new User(Console.ReadLine());
        
       while (runProgram)
        {
            Console.WriteLine($"Points: {user.GetTotalPoints()}");
            Console.WriteLine("\nSelect an option from the menu:");
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                user.CreateNewGoal();
            }

            else if (userInput == 2)
            {
                user.DisplayGoals();
            }

            else if (userInput == 3)
            {
                user.Save();
            }
        
            else if (userInput == 4)
            {
                user.Load();
            }
        
            else if (userInput == 5)
            {
                user.RecordEvent();
            }
        
            else if (userInput == 6)
            {
                runProgram = false;
            }
        
            else 
            {
                Console.WriteLine("That's not an option.");
            }
        }
    }
}
