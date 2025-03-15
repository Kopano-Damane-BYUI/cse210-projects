using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void AddEntry(string prompt, string response)
    {
        string currentDate = DateTime.Now.ToShortDateString();
        JournalEntry newEntry = new JournalEntry(prompt, response, currentDate);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    // Save journal entries to a CSV file
    public void SaveToCSV(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                // Escape quotes and commas in entries and wrap values in quotes
                string date = EscapeCsvValue(entry.Date);
                string prompt = EscapeCsvValue(entry.Prompt);
                string response = EscapeCsvValue(entry.Response);

                // Write the entry as a CSV row
                writer.WriteLine($"{date},{prompt},{response}");
            }
        }
        Console.WriteLine("Journal saved to CSV successfully!");
    }

    // Load journal entries from a CSV file
    public void LoadFromCSV(string fileName)
    {
        entries.Clear();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            // Split by commas, but handle cases where commas are inside quotes
            string[] parts = ParseCsvLine(line);

            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                JournalEntry entry = new JournalEntry(prompt, response, date);
                entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded from CSV successfully!");
    }

    // Escape a value to handle commas and quotes correctly in CSV
    private string EscapeCsvValue(string value)
    {
        // If the value contains commas or quotes, escape them
        if (value.Contains(",") || value.Contains("\""))
        {
            value = "\"" + value.Replace("\"", "\"\"") + "\"";
        }
        return value;
    }

    // Parse a CSV line considering commas inside quoted text
    private string[] ParseCsvLine(string line)
    {
        var result = new List<string>();
        var currentField = string.Empty;
        var insideQuote = false;

        for (int i = 0; i < line.Length; i++)
        {
            char currentChar = line[i];

            if (currentChar == '"' && (i == 0 || line[i - 1] != '"'))
            {
                // Toggle quote status when encountering unescaped quote
                insideQuote = !insideQuote;
            }
            else if (currentChar == ',' && !insideQuote)
            {
                // Comma outside of quotes indicates a new field
                result.Add(currentField);
                currentField = string.Empty;
            }
            else
            {
                // Append character to the current field
                currentField += currentChar;
            }
        }
        result.Add(currentField); // Add the last field

        return result.ToArray();
    }
}
