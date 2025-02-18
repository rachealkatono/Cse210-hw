public class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get { return _laps; }
        private set { _laps = value; }
    }

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return Duration / GetDistance(); // Pace in minutes per mile
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