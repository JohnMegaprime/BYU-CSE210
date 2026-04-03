
public class BreathingActivity : Activity
{
    
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(_duration);

        Console.WriteLine("Get Ready!");
        ShowAnimation(3);
        Console.WriteLine();

        while (DateTime.Now < endtime)
        {
            Console.Write("Breath IN...");
            ShowCountdown(5);
            Console.WriteLine();
            Console.Write("Breath OUT...");
            ShowCountdown(6);
            Console.WriteLine("\n");
        }
    }
}