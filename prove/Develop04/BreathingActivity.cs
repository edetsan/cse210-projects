public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        int seconds = GetDuration();
        while (seconds > 0)
        {
            Console.WriteLine("Breathe in...");
            Countdown();
            seconds = seconds - 3;
            if (seconds > 0)
                {
                    Console.WriteLine("Breathe out...");
                    Countdown();
                    seconds = seconds - 3;
                }
        }
        DisplayEnd();
    }
}