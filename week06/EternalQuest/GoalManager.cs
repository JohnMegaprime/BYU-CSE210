
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
    }

    public void Start()
    {
        int option = 0;

        while (option != 6)
        {   
            CheckLevel();
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options");

            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");

            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
                CreateGoal();
            else if (option == 2)
                ListGoalsDetails();
            else if (option == 3)
                SaveGoals();
            else if (option == 4)
                LoadGoals();
            else if (option == 5)
                RecordEvent();

            Console.WriteLine();

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You are in Level {_level}");
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalsDetails()
    {
        int i = 1;
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            Console.WriteLine(goal.GetDetailsString());
            i++;
        }
    }

    public void ListGoalsNames()
    {
        int i = 1;
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            Console.WriteLine(goal.GetName());
            i++;
        }
    }

    public void CreateGoal()
    {
        int option;
        Console.WriteLine("The types of Goals are: ");

        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        option = int.Parse(Console.ReadLine());

            Console.Write("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
        if (option == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        if (option == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name,description,points);
            _goals.Add(eternalGoal);
        }
        if (option == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }

    }

    public void RecordEvent()
    {
        int option;
        ListGoalsNames();
        Console.Write("Which goal did you accomplish? ");
        option = int.Parse(Console.ReadLine());

        int i = option -1;
        if (!(_goals[i].IsComplete()))
        {
            _goals[i].RecordEvent();
            _score += _goals[i].GetPoints();
            Console.WriteLine($"Congratulations! You have earned {_goals[i].GetPoints()} points!");
            Console.WriteLine($"You now have {_score} points");
            CheckLevel();
            Console.WriteLine($"You are now at level {_level}!");
        }
        else
            Console.WriteLine("This goal has already been completed.");
        

    }

    public void CheckLevel()
    {
        int points = _score;

        if (points >= 200)
            _level = 2;
        if (points >= 400)
            _level = 3;
        if (points >= 700)
            _level = 4;
        if (points >= 1000)
            _level = 5;
        if (points >= 1800)
            _level = 6;
        if (points >= 2600)
            _level = 7;
        if (points >= 4000)
            _level = 8;
        if (points >= 6000)
            _level = 9;
        if (points >= 10000)
            _level = 10;
    }

    public void SaveGoals()
    {
        string filename;

        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_level);
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> goalLines = lines.Skip(2).ToList();
        _score = int.Parse(lines[1]);
        _level = int.Parse(lines[0]);



        foreach (string line in goalLines)
        {
            string[] parts = line.Split(",");

            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            if (parts[0] == "SimpleGoal")

                if ( parts.Count() == 5)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, true);
                    _goals.Add(simpleGoal);
                }
                else
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                }
            else if (parts[0] == "EternalGoal")
            {
                int times = int.Parse(parts[4]);
                EternalGoal eternalGoal = new EternalGoal(name, description, points, times);
                    _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, completed);
                    _goals.Add(checklistGoal);
            }


        }
    }

}