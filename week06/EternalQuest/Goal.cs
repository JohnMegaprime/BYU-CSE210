
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string details;

        if (IsComplete())
        {
            details = $"[X] {_shortName} ({_description})";
        }
        else
        {
            details = $"[ ] {_shortName} ({_description})";
        }
        return details;
    }

    public string GetName()
    {
        return _shortName;
    }
    public int GetPoints()
    {
        return _points;
    }

}