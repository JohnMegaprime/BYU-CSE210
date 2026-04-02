using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("joão Gabriel", "Addition");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Cleberildo", "Multiplication", "6.7", "1-7");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Melyssa", "History", "The History of Brazil");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}