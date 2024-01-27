using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer Program!");

        int userInput = 0;
            
        Console.WriteLine("\nPlease, choose a scripture to memorize:");
        Console.WriteLine("1. John 14:27");
        Console.WriteLine("2. 2 Nephi 31:20");
        Console.WriteLine("3. Moroni 7: 42-43");
        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
            {
                string text1 = "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.";
                Scripture scripture1 = new Scripture(text1);
                Reference reference1 = new Reference("John", 14, 27);
                UserInterface(scripture1,reference1);
            }
        else if (userInput == 2)
            {
                string text2 = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";
                Scripture scripture2 = new Scripture(text2);
                Reference reference2 = new Reference("2 Nephi", 31, 20);
                UserInterface(scripture2,reference2);
            }
        
        else if (userInput == 3)
            {
                string text3 = "Wherefore, if a man have faith he must needs have hope; for without faith there cannot be any hope. And again, behold I say unto you that he cannot have faith and hope, save he shall be meek, and lowly of heart.";
                Scripture scripture3 = new Scripture(text3);
                Reference reference3 = new Reference("Moroni", 7, 42,43);
                UserInterface(scripture3,reference3);
            }
        
    } 
    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }  
}