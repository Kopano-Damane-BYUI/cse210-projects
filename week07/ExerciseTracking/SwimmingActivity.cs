// SwimmingActivity.cs
// Derived class for swimming activity

using System;

public class SwimmingActivity : Activity
{
    // Private member variable for number of laps
    private int _numLaps;

    // Constructor to initialize swimming activity
    public SwimmingActivity(DateTime date, double lengthInMinutes, int numLaps)
        : base(date, lengthInMinutes)
    {
        _numLaps = numLaps;
    }

    // Override to get distance for swimming activity
    public override double GetDistance()
    {
        return (_numLaps * 50 / 1000) * 0.62; // Distance in miles
    }

    // Override to get speed for swimming activity
    public override double GetSpeed()
    {
        double distanceInMiles = GetDistance();
        return (distanceInMiles / base._lengthInMinutes) * 60; // Speed in miles per hour
    }

    // Override to get pace for swimming activity
    public override double GetPace()
    {
        double distanceInMiles = GetDistance();
        return base._lengthInMinutes / distanceInMiles; // Pace in minutes per mile
    }
}
