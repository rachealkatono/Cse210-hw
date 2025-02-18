public class Running : Activity
{
    private double _distance; // in miles

    public double Distance 
    {
        get { return _distance; }
        private set { _distance = value; }
    }

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance; // in miles
    }

    public override double GetSpeed()
    {
        return (_distance / Duration) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return Duration / _distance; // Pace in minutes per mile
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
