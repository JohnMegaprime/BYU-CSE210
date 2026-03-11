using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume myResume = new Resume();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2023;

        job2._company = "Samsung";
        job2._jobTitle = "Salesman";
        job2._startYear = 2025;
        job2._endYear = 2026;

        myResume._name = "João Gabriel";

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.Display();

    }
}