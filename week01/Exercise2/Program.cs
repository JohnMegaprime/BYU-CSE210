using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade_str = Console.ReadLine();
        int grade = int.Parse(grade_str);
        string letter = "";
        string sign = "";
        string message = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (grade >= 70)
            message = "Congratulations! You have passed the class";
        else
            message = "You did not pass the class, keep studying and you will get it next time!";

        if (grade >= 60 && !(grade >= 97))
        {
            int remainder = grade % 10;
            if (remainder >= 7)
                sign = "+";
            else if (remainder >= 3)
                sign = "";
            else
                sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        Console.WriteLine(message);
    }
}