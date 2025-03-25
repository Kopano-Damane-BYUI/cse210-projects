using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }
    private Word mostRecentlyHiddenWord;  // Track the most recently hidden word for highlighting

    // Constructor for single verse scripture
    public Scripture(Reference reference, string scriptureText)
    {
        Reference = reference;
        Words = new List<Word>();

        // Split the scripture text into words and create Word objects
        string[] wordArray = scriptureText.Split(' ');
        foreach (var word in wordArray)
        {
            Words.Add(new Word(word));
        }
    }

    // Constructor for multiple verses scripture
    public Scripture(Reference reference, string[] scriptureText)
    {
        Reference = reference;
        Words = new List<Word>();

        // Add words from multiple verses to the list
        foreach (var text in scriptureText)
        {
            string[] wordArray = text.Split(' ');
            foreach (var word in wordArray)
            {
                Words.Add(new Word(word));
            }
        }
    }

    // Method to display the scripture
    public void Display()
    {
        // Display the reference
        Console.WriteLine(Reference.ToString());

        // Display the words, hiding the ones that have been marked
        foreach (var word in Words)
        {
            if (word.IsHidden)
            {
                // Highlight the most recently hidden word with color
                if (word == mostRecentlyHiddenWord)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;  // Unique color for the most recent word
                    Console.Write("____ ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("____ ");  // Keep the word hidden with underscores
                }
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }

        Console.WriteLine();  // New line after displaying the scripture
    }

    // Method to hide a random word from the scripture and highlight the most recently hidden word
    public void HideRandomWord(bool isFirstTime = false)
    {
        Random random = new Random();
        List<Word> unhiddenWords = Words.FindAll(w => !w.IsHidden);

        if (unhiddenWords.Count > 0)
        {
            int index = random.Next(unhiddenWords.Count);
            Word wordToHide = unhiddenWords[index];
            wordToHide.IsHidden = true;

            // Always set the most recently hidden word
            mostRecentlyHiddenWord = wordToHide;
        }
    }


    // Method to check if the guessed word is correct
    public bool CheckGuess(string guess)
    {
        // Find the word in the scripture that is hidden and check if it matches the guess
        foreach (var word in Words)
        {
            if (word.IsHidden && word.Text.Equals(guess, StringComparison.OrdinalIgnoreCase))
            {
                // The word stays hidden, whether guessed correctly or not
                return true;
            }
        }
        return false; // Return false if no match is found
    }

    // Method to get the original text of the scripture (without any hidden words)
    public string GetOriginalText()
    {
        // Get all the words in their original form (without any hidden words)
        return string.Join(" ", Words.Select(w => w.Text));
    }
}
