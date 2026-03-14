
public class Entry()
{
    Random random = new Random();
    public string _entryText = "";

    public string _mood = "";
    public List<string> _prompts = new List<string>();

    public DateTime _date = DateTime.Now;
    public int randomNumber = 0;

    public string PromptGenerator()
    {
        _prompts.Add("What was the best part of today, even if it was just a small moment?");
        _prompts.Add("What is one thing I want to do differently tomorrow?");
        _prompts.Add("What are three things I’m grateful for right now?");
        _prompts.Add("What is something I'm looking forward to in the next few days?");
        _prompts.Add("What is a goal I’m currently working toward, and why does it matter to me?");
        _prompts.Add("If I had an extra hour in my day today, how would I have spent it?");
        
        int randomNumber = random.Next(0,5);

        return _prompts[randomNumber];

    }

    public string DisplayEntry(string prompt)
    {

        return $"{_date} - Mood:  {_mood} \n Prompt: {prompt} \n {_entryText} \n";
    }

}
