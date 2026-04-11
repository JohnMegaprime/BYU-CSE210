using System;
//EXCEEDING THE REQUIREMENTS
//I added a levelling system, based on the quantity of points
//also added to every eternal goal, a counter to show how many times the user achieved the goal since it
//never ends.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();

    }
}