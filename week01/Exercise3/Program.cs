using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int guesses = 0;
        int guess = 0;
        string choice = "yes";

        Console.WriteLine("Guess the magic number?");
        
        while (choice.ToLower() == "yes")
        {
            guesses = 0;
            int magic_number = randomGenerator.Next(1, 101);
            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess > magic_number)
                {
                    Console.WriteLine("lower!");
                }
                else
                {
                    Console.WriteLine("Higher!");
                }
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of guesses: {guesses}");
            Console.WriteLine();
            Console.Write("Do you want to play again?(yes/no) ");
            choice = Console.ReadLine();
        }

    }
}