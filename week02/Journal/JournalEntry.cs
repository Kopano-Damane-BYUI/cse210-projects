using System;

public class JournalEntry
{
    // Properties to hold the journal entry details
    // Get the 'Prompt' property text of the journal entry (what the user is responding to)
    public string Prompt { get; set; }

    // Get the 'Response' property user's response to the journal prompt
    public string Response { get; set; }

    // Get the 'Date' property of the journal entry (the day it was written)
    public string Date { get; set; }

    // Store the Prompt, Response, and Date entered by the user for later use
    public JournalEntry(string prompt, string response, string date)
    {
        // Store the 'Prompt' property with the passed 'prompt' argument
        Prompt = prompt;

        // Store the 'Response' property with the passed 'response' argument
        Response = response;

        // Store the 'Date' property with the passed 'date' argument
        Date = date;
    }

    // Display the entry's content: details (date, prompt, and response) to the console
    public void DisplayEntry()
    {
        // Print the 'Date' of the journal entry in a user-friendly format
        Console.WriteLine($"Date: {Date}");

        // Print the 'Prompt' that was given to the user
        Console.WriteLine($"Prompt: {Prompt}");

        // Print the 'Response' that the user gave to the prompt
        Console.WriteLine($"Response: {Response}");

        // Print an empty line for better readability between entries
        Console.WriteLine();
    }
}
