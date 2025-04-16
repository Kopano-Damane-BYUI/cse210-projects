// CyclingActivity.cs
// Derived class for cycling activity

using System;

public class CyclingActivity : Activity
{
    // Private member variable for speed
    private double _speedInMph;

    // Constructor to initialize cycling activity
    public CyclingActivity(DateTime date, double lengthInMinutes, double speedInMph)
        : base(date, lengthInMinutes)
    {
        _speedInMph = speedInMph;
    }

    // Override to get distance for cycling activity
    public override double GetDistance()
    {
        return (_speedInMph * base._lengthInMinutes) / 60; // Distance in miles
    }

    // Override to get speed for cycling activity
    public override double GetSpeed()
    {
        return _speedInMph;
    }

    // Override to get pace for cycling activity
    public override double GetPace()
    {
        return 60 / _speedInMph; // Pace in minutes per mile
    }
}
