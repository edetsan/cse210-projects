//For exceeding requirments, The program keeps track of how many times the user used X Activity during the session. It will increment a variable each time the user select that activity, and the user can see the full log with the option number 4.
class Program
{
    static void Main(string[] args)
    {
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;
            
        //userInput = int.Parse(Console.ReadLine());

        bool runProgram = true;
        while (runProgram)
        {

            Console.WriteLine("\nPlease, select a mindfulness activity:");
            Console.WriteLine("1. Start breathing");
            Console.WriteLine("2. Start reflecting");
            Console.WriteLine("3. Start Listing");
            Console.WriteLine("4. Activity Log");
            Console.WriteLine("5. Quit");
            int userInput = int.Parse(Console.ReadLine());

             if (userInput == 1)
            {
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.StartActivity();
                    breathingLog += 1;
            }
             else if (userInput == 2)
            {
                    ReflectingActivity reflecting = new ReflectingActivity("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.StartActivity();
                    reflectingLog += 1;
            }
        
            else if (userInput == 3)
            {
                    ListingActivity listing = new ListingActivity("Listing Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.StartActivity();
                    listingLog += 1;
            }
        
            else if (userInput == 4)
            {
                    Console.WriteLine("Activity - Number of times performed in this session");
                    Console.WriteLine($"Breathing Activity: {breathingLog} times");
                    Console.WriteLine($"Reflecting Activity: {reflectingLog} times");
                    Console.WriteLine($"Listing Activity: {listingLog} times");
            }
        
            else if (userInput == 5)
            {
                    Console.WriteLine("Great job, thanks for using the Mindfulness app, come back soon!");
                    
                    runProgram = false;              
            }
        }
        
    }
    
}