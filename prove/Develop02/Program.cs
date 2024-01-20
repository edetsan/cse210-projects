using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        int userInput = 0;
       
        while (userInput != 5)
        {
        
            Console.WriteLine("\nPlease select one of the following options:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                string currentPrompt = prompt.GetPrompt();
                Console.WriteLine(currentPrompt);
                //Console.Write("> ");
                string record = Console.ReadLine();

                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry._date = dateText;
                entry._prompt = currentPrompt;
                entry._record = record;

                journal._entries.Add(entry);
            }

            else if (userInput == 2)
            {
                journal.DisplayJournal();
            }

            else if (userInput == 3)
            {
                journal.SaveFile();
            }

            else if (userInput == 4)
            {
                journal.LoadFile();
            }


        }
    }
}