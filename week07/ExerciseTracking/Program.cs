using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 4.8);
        Console.WriteLine(runningActivity.GetSummaryString());
        Console.WriteLine();
        StationaryBikeACtivity stationaryBikeACtivity = new StationaryBikeACtivity("16 Apr 2024", 20, 19);
        Console.WriteLine(stationaryBikeACtivity.GetSummaryString());
        Console.WriteLine();
        SwimmingActivity swimmingActivity = new SwimmingActivity("20 May 2026", 18, 10);
        Console.WriteLine(swimmingActivity.GetSummaryString());

    }
}