// Page: BreathingActivity.cs
// This class defines the breathing activity.

using System;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        activityName = "Breathing Activity";
        activityDescription = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public override void StartActivity()
    {
        ShowStartingMessage();  // Show the common starting message

        // Show "Get ready..." message
        Console.WriteLine("Get ready...");

        // Show the spinner directly under "Get ready..." without any divider space
        PauseWithSpinner();

        // Start breathing instructions
        Console.WriteLine("Breathe in...");
        StartCountdown(duration / 2);  // Half of the duration for breathing in
        AddSpacing();  // Add space before the next part

        Console.WriteLine("Breathe out...");
        StartCountdown(duration / 2);  // Half of the duration for breathing out

        ShowFinishingMessage();
    }

    // Function to start the countdown for "Breathe in..." and "Breathe out..."
    private void StartCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);  // Move the cursor back to the start of the line
            Console.Write($"( {i} )");  // Display the countdown in place
            Thread.Sleep(1000);  // Wait for 1 second
        }
    }

    // Function for showing a spinner during the "Get ready..." message
    private void PauseWithSpinner()
    {
        // Spinner animation (just one cycle)
        string[] spinner = { "/", "-", "\\", "|" };
        foreach (var symbol in spinner)
        {
            Console.Write(symbol);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}
