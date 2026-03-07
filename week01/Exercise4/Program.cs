using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        float sum = 0;
        int new_number = -1;
        int max = -1000000;
        int min = 9999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (new_number != 0)
        {
            Console.Write("Enter a Number: ");
            new_number = int.Parse(Console.ReadLine());

            if (new_number != 0)
                numbers.Add(new_number);
        }

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
                max = number;
            if (number < min && number > 0)
                min = number;
        }

        float average = sum / (numbers.Count());

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The Largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
    }
}