// Page: ReflectionActivity.cs
// This class defines the reflection activity.

using System;

public class ReflectionActivity : BaseActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        activityName = "Reflection Activity";
        activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void StartActivity()
    {
        ShowStartingMessage();
        AddSpacing();  // Add space before showing prompt
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000);

        foreach (var question in questions)
        {
            AddSpacing();  // Add space before each question
            Console.WriteLine(question);
            PauseWithAnimation();
        }

        AddSpacing();  // Add space before finishing message
        ShowFinishingMessage();
    }
}
