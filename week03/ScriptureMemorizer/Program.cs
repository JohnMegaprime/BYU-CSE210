using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "";
        Reference reference = new Reference("Mosiah", 2, 17);
        Scripture scripture = new Scripture(reference, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");

        while (word != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            if (scripture.IsCompletelyHidden())
                break;
            word = Console.ReadLine();
            scripture.HideRandomWords(3);

            Console.Clear();

        }
       
        

    }
}