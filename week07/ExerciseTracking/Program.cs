// Program.cs
// Main entry point for the exercise tracking program

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Display a welcome message with an introduction
        Console.WriteLine("EXERCISE TRACKING PROGRAM");
        Console.WriteLine("----------------------------------------");

        // Create a list to hold different types of activities
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0)); // Running
        activities.Add(new CyclingActivity(new DateTime(2022, 11, 4), 45, 12.0)); // Cycling
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 5), 60, 40));  // Swimming

        // Iterate through the list and print the summary for each activity
        foreach (var activity in activities)
        {
            // Display a heading based on the activity type
            Console.WriteLine($"Activity Type: {activity.GetType().Name}");
            Console.WriteLine(new string('-', 40)); // Print a separator line for better readability
            Console.WriteLine(activity.GetSummary()); // Print the summary of the activity
            Console.WriteLine(); // Add a blank line for separation between activities
        }
    }
}

