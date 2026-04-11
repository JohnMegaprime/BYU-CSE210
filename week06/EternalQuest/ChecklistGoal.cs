
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    public override string GetDetailsString()
    {
        string details;
        if (IsComplete())
            details = $"[X] {_shortName} ({_description} -- Currently completed: {_amountCompleted}/{_target})";
        else
            details = $"[ ] {_shortName} ({_description} -- Currently completed: {_amountCompleted}/{_target})";
        return details;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
            return true;
        else
            return false;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete())
            _points += _bonus;

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }

}