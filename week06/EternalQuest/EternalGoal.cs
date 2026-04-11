
public class EternalGoal : Goal
{
    private int _times;
    public EternalGoal(string name, string description, int points) : base(name,description,points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _times = 0;
    }
    public EternalGoal(string name, string description, int points, int times) : base(name,description,points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _times = times;
    }

    public override void RecordEvent()
    {
        _times++;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        string details;

        details = $"[ ] {_shortName} ({_description} -- Times achieved: {_times})";

        return details;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points},{_times}";
    }

}