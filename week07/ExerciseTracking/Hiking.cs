public class Hiking : Activity
{
    private double _elevationGain; // Elevation gain in meters

    public double ElevationGain
    {
        get { return _elevationGain; }
        private set { _elevationGain = value; }
    }

    // Constructor: date, duration (minutes), and elevation gain (meters)
    public Hiking(DateTime date, int duration, double elevationGain) : base(date, duration)
    {
        _elevationGain = elevationGain;
    }

    // Override method to calculate distance based on elevation gain and slope
    public override double GetDistance()
    {
        // Assuming a 10% slope, distance can be calculated as elevation gain / slope.
        // This means for every 1 meter of elevation, you hike 10 meters horizontally.
        return (_elevationGain * 10) / 1000.0; // Distance in kilometers
    }

    // Override method to calculate speed in kilometers per hour
    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; // Speed in kilometers per hour
    }

    // Override method to calculate pace (minutes per kilometer)
    public override double GetPace()
    {
        return Duration / GetDistance(); // Pace in minutes per kilometer
    }

    // Define units for distance, speed, and pace
    protected override string GetDistanceUnits()
    {
        return "km";
    }

    protected override string GetSpeedUnits()
    {
        return "kph";
    }

    protected override string GetPaceUnits()
    {
        return "min per km";
    }
}
