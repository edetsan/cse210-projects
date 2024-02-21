using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("03 March 2023",5.2,50));
        activities.Add(new CyclingActivity("15 Jul 2023",7.9,60));
        activities.Add(new SwimmingActivity("27 Dec 2023",102,45));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY #{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}