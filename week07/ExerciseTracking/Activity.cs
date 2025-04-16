// Activity.cs
// Base class representing a generic exercise activity

using System;

public abstract class Activity
{
    // Private member variables
    private DateTime _date;
    protected double _lengthInMinutes;

    // Constructor to initialize common properties
    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method to get a summary of the activity
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_lengthInMinutes} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
