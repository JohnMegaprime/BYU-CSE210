
public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int length, int laps) : base(date,length)
    {
        _date = date;
        _length = length;
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.00;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetActivityName()
    {
        return "Swimming in the Lap Pool";
    }
}