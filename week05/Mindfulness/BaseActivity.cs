// Page: BaseActivity.cs
// This class provides shared functionality for all activities.

using System;
using System.Threading;

public abstract class BaseActivity
{
    protected string activityName;
    protected string activityDescription;
    protected int duration; // duration in seconds
    private static int activitiesCompleted = 0;

    // Abstract method to start activity
    public abstract void StartActivity();

    // Common starting message displayed before the activity begins
    protected void ShowStartingMessage()
    {
        Console.Clear();  // Clear the screen to make it more readable
        Console.WriteLine($"--- {activityName} ---\n");
        Console.WriteLine($"{activityDescription}\n");
        Console.Write("Enter duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(2000);  // Simulate a pause
    }

    // Common finishing message displayed after the activity ends
    protected void ShowFinishingMessage()
    {
        activitiesCompleted++;
        Console.WriteLine("\nWell done! You've completed {0} for {1} seconds.", activityName, duration);
        Thread.Sleep(2000);  // Simulate a pause
        Console.WriteLine("\n--- Activity Complete ---");
        Thread.Sleep(2000);  // Simulate a pause
        LogActivityCompletion();  // Log the activity completion
    }

    // Helper function for pausing with animation (spinner)
    protected void PauseWithAnimation()
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    // Helper function for logging completed activity to a file
    private void LogActivityCompletion()
    {
        string logMessage = $"{activityName} completed for {duration} seconds.\n";
        System.IO.File.AppendAllText("activity_log.txt", logMessage);
        Console.WriteLine("Activity logged!");
    }

    // Helper function for adding extra spaces for better readability
    protected void AddSpacing()
    {
        Console.WriteLine("\n\n"); // Add two lines of space
    }
}