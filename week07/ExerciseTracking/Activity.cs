using System;

public abstract class Activity
{
    // Private member variables
    private DateTime _date;
    private int _duration;  // in minutes

    // Public properties to access the private member variables
    public DateTime Date 
    { 
        get { return _date; }
        private set { _date = value; }  // Encapsulation: only allow setting through constructor
    }

    public int Duration 
    { 
        get { return _duration; }
        private set { _duration = value; }  // Encapsulation: only allow setting through constructor
    }

    // Constructor
    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get the summary in a specified format
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min): Distance {GetDistance()} {GetDistanceUnits()}, Speed: {GetSpeed()} {GetSpeedUnits()}, Pace: {GetPace()} {GetPaceUnits()}";
    }

    // Helper methods to specify units for each activity
    protected abstract string GetDistanceUnits();
    protected abstract string GetSpeedUnits();
    protected abstract string GetPaceUnits();
}
