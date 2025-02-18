public class Cycling : Activity
{
    private double _speed; // speed in miles per hour

    public double Speed
    {
        get { return _speed; }
        private set { _speed = value; }
    }

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Duration) / 60; // distance in miles
    }

    public override double GetSpeed()
    {
        return _speed; // speed in miles per hour
    }

    public override double GetPace()
    {
        return 60 / _speed; // pace in minutes per mile
    }

    protected override string GetDistanceUnits()
    {
        return "miles";
    }

    protected override string GetSpeedUnits()
    {
        return "mph";
    }

    protected override string GetPaceUnits()
    {
        return "min per mile";
    }
}