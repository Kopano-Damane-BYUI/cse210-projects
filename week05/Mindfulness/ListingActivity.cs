// Page: ListingActivity.cs
// This class defines the listing activity.

using System;

public class ListingActivity : BaseActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        activityName = "Listing Activity";
        activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void StartActivity()
    {
        ShowStartingMessage();
        AddSpacing();  // Add space before showing prompt
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000);

        Console.WriteLine("\nYou may begin listing now. Press 'Enter' after each item.");
        AddSpacing();  // Add space before starting the list

        DateTime startTime = DateTime.Now;
        int itemCount = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter item: ");
            Console.ReadLine(); // Let the user input their list item
            itemCount++;
            AddSpacing();  // Add space after each input
        }

        Console.WriteLine($"You listed {itemCount} items.");
        AddSpacing();  // Add space before finishing message
        ShowFinishingMessage();
    }
}