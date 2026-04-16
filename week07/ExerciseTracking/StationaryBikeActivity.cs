
public class StationaryBikeACtivity : Activity
{
    private double _speed;

    public StationaryBikeACtivity(string date, int length, double speed) : base(date, length)
    {
        _date = date;
        _length = length;
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _length / GetPace();
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetActivityName()
    {
        return "Stationary Cycling";
    }

}