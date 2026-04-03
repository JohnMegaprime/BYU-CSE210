
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    private int _uses;

    public Activity()
    {
        _name = "Activity";
        _description = "This is a default mindfulness activity, meant to help you relax and heal your spirit.";
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!\n");
        ShowAnimation(2);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
        ShowAnimation(3);
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void ShowAnimation(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        List<string> anim = new List<string>();
        anim.Add("|");
        anim.Add("/");
        anim.Add("-");
        anim.Add("\\");

        int i = 0;

        while (DateTime.Now < endtime)
        {

            Console.Write(anim[i]);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;
            if (i >= anim.Count())
                i = 0;

        }
    }

    public void ShowCountdown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        int i = seconds;

        while (DateTime.Now < endtime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public void DisplayTest()
    {
        Console.WriteLine(_duration);
    }


    public void AddUse()
    {
        _uses++;
    }
    public int GetActivityUses()
    {
        return _uses;
    }
}