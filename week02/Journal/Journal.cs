
using System.Security.Cryptography.X509Certificates;

public class Journal()
{
    public List<string> _entries = new List<string>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        string prompt = entry.PromptGenerator();
        Console.Write("How is your mood today? ");
        entry._mood = Console.ReadLine();
        Console.WriteLine(prompt);
        entry._entryText = Console.ReadLine();

        _entries.Add(entry.DisplayEntry(prompt));
    }
    public void Display()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outPutFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
        {
            outPutFile.WriteLine(entry);
        }
        }
        
    }   

    public void Load()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string text = System.IO.File.ReadAllText(filename);
        _entries.Clear();

        string[] fileEntries = text.Split("\n");

        foreach (string i in fileEntries)
            _entries.Add(i);
        
    }

}