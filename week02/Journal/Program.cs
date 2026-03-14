using System;
// I EXCEEDED THE REQUIREMENTS ADDING EXTRA INFORMATION AT THE JOURNAL ENTRIES (MOOD OF THE USER)
class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Journal journal = new Journal();

        while (option != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
                journal.AddEntry();
            if (option == 2)
                journal.Display();
            if (option == 3)
                journal.Load();
            if (option == 4)
                journal.Save();

        }
        
    }
}