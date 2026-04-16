
public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummaryString()
    {
        return $"{_date} {GetActivityName()} ({_length} min): Distance {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(),2)} kph, Pace: {Math.Round(GetPace()), 2} min per km";
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityName();


}