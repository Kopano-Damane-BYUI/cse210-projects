// RunningActivity.cs
// Derived class for running activity

using System;

public class RunningActivity : Activity
{
    // Private member variable for distance
    private double _distanceInMiles;

    // Constructor to initialize running activity
    public RunningActivity(DateTime date, double lengthInMinutes, double distanceInMiles)
        : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    // Override to get distance for running activity
    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    // Override to get speed for running activity
    public override double GetSpeed()
    {
        return (_distanceInMiles / base._lengthInMinutes) * 60; // Speed in miles per hour
    }

    // Override to get pace for running activity
    public override double GetPace()
    {
        return base._lengthInMinutes / _distanceInMiles; // Pace in minutes per mile
    }
}
