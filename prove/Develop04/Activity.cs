using System.Collections.Specialized;

public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name,string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStart()
    {
        Console.WriteLine($"Welcome to the: {_name}\n{_description}\n");
        InputDuration();
        Console.WriteLine($"The {_name} activity will start for {_duration} seconds...");
        Countdown();   
    }
    public void DisplayEnd()
    {
        Console.WriteLine($"Nice job! You completed the {_name} for {_duration} seconds.");
        Thread.Sleep(2500);
        Console.WriteLine("Come back soon");
    }
    public void Countdown()
    {
        for (int i = 3; i > 0; i--)
        {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("...");
        }
        Console.WriteLine();
    }

     public void CountdownReflect()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (String s in animationStrings)
        {
            
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }


    public void InputDuration()
    {
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }

    //GETERS
    public int GetDuration()
    {
        return _duration;
    }
}