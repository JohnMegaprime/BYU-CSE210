using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "";
        Reference reference = new Reference("Mosias", 2, 17);
        Scripture scripture = new Scripture(reference, "E eis que vos digo estas coisas para que aprendais sabedoria; para que saibais que, quando estais a serviço de vosso próximo, estais somente a serviço de vosso Deus.");

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