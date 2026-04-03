
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count;
    
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run()
    {
        Console.WriteLine("Get Ready!");
        ShowAnimation(3);
        Console.WriteLine("\n");

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("\n");
        
        List<string> items = new List<string>();
        ListItems(items);

        Console.WriteLine($"You listed {_count} items!");
    }

    private void ListItems(List<string> items)
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        _count = items.Count();
            
    }

    private string GetRandomPrompt()
    {
        string prompt;
        Random random = new Random();
        int rNUmber = random.Next(0, _prompts.Count());

        prompt = _prompts[rNUmber];

        return prompt;

    }
}