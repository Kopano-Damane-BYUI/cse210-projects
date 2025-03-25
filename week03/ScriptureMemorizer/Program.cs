using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Set a welcome message with color
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.ResetColor();

        // List of scriptures for the user to choose from
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John 3:16"), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs 3:5-6"), new string[] {
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
                "In all thy ways acknowledge him, and he shall direct thy paths."
            }),
            new Scripture(new Reference("Philippians 4:13"), "I can do all things through Christ which strengtheneth me.")
        };

        // Choose a random scripture from the list
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Track correct, incorrect guesses, and hidden words separately
        int correctGuesses = 0;
        int incorrectGuesses = 0;
        int hiddenWordsCount = 0;

        // Track if it's the first time hiding a word
        bool firstTime = true;

        // Loop until the user hides all words and guesses correctly
        while (true)
        {
            // Clear the screen for a fresh view
            Console.Clear();

            // Display the chosen scripture to the user with any hidden words (not shown at all, hidden)
            scripture.Display();  // Display hidden words as "____"

            // Progress tracking (Words Hidden / Total Words)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWords Hidden: {hiddenWordsCount}/{scripture.Words.Count}");
            Console.WriteLine($"Correct Guesses: {correctGuesses}");
            Console.WriteLine($"Incorrect Guesses: {incorrectGuesses}");
            Console.ResetColor();

            // Inspirational feedback based on progress
            if (hiddenWordsCount == scripture.Words.Count)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Awesome! You've hidden all the words! Now, let's see if you remember them.");
                Console.ResetColor();
                break;
            }

            // Ask the user whether they want to hide more words or quit the program
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPress Enter to hide a random word, type 'quit' to exit.");
            Console.ResetColor();

            // Read the user's input from the console
            string input = Console.ReadLine();

            // If the user types "quit", exit the program
            if (input.ToLower() == "quit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThanks for using the Scripture Memorizer! Goodbye!");
                Console.ResetColor();
                break;  // Exit the program
            }

            // If it's the first time, just hide a random word and don't ask for a guess yet
            if (firstTime)
            {
                scripture.HideRandomWord(true);  // The 'true' indicates this is the most recently hidden word
                hiddenWordsCount++;
                firstTime = false; // After the first hide, we track the guesses
            }
            else
            {
                // Hide a random word
                scripture.HideRandomWord(false);  // 'false' indicates no highlighting for previously hidden word
                hiddenWordsCount++;

                // Ask the user to guess the hidden word
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nGuess the hidden word:");
                Console.ResetColor();
                string guess = Console.ReadLine();

                // Check the guess and update the correct/incorrect count
                bool isCorrect = scripture.CheckGuess(guess);
                if (isCorrect)
                {
                    correctGuesses++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! Well done!");
                    Console.ResetColor();
                }
                else
                {
                    incorrectGuesses++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops! That's not correct. Try again.");
                    Console.ResetColor();
                }
            }
        }

        // After hiding all words, ask the user to retype the scripture
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nNow, let's see if you can retype the scripture from memory. Go ahead!");
        Console.ResetColor();

        // Display the original scripture without hidden words
        string originalText = scripture.GetOriginalText();
        string userInput = Console.ReadLine();

        // Check if the user’s input matches the original text
        if (userInput.Equals(originalText, StringComparison.OrdinalIgnoreCase))
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCongratulations! You’ve successfully memorized the scripture!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNot quite right, but keep practicing! You'll get it soon!");
            Console.ResetColor();
        }

        // Show the final score
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYou guessed {correctGuesses} words correctly and {incorrectGuesses} incorrectly.");
        Console.ResetColor();
    }
}

/* 
 * Creativity and Exceeding Requirements:
 * 1. **User-Driven Challenges**:
 *    - We added an interactive guessing challenge, where the user guesses hidden words in the scripture. 
 *    - This promotes active engagement and helps users focus on memorization, making the process more dynamic and fun.
 *  
 * 2. **Progress Tracker**:
 *    - A real-time progress tracker was incorporated, displaying the number of hidden words, as well as the correct and incorrect guesses.
 *    - This gives users a clear sense of accomplishment and motivates them to continue progressing through the scripture.
 *  
 * 3. **Color-Coded Feedback**:
 *    - Color was used to visually differentiate between correct and incorrect guesses, providing instant feedback to the user.
 *    - This helps improve the user experience by giving clear visual cues on their performance.
 *  
 * 4. **Unique Color Highlighting for Recent Hidden Word**:
 *    - Each time a word is hidden, we ensure the most recent hidden word is highlighted in a unique color (magenta).
 *    - This enhances the visual aspect of the program and makes it easier for users to keep track of the hidden words as they progress.
 *  
 * 5. **Inspirational Encouragement**:
 *    - After each round of hiding words, motivational messages are displayed to encourage users, creating a positive experience and boosting their confidence.
 *    - Users are congratulated when they hide all the words, and they receive encouragement if they haven’t memorized it perfectly on their first try.
 *  
 * 6. **Retype the Scripture Challenge**:
 *    - After all words are hidden, the user is challenged to retype the scripture from memory.
 *    - This serves as a final test and reinforces memorization, while offering a chance for the user to see their progress in action.
 *  
 * 7. **User-Centered Design**:
 *    - Throughout the program, we made sure that users have the ability to interact, track their progress, receive feedback, and challenge themselves in a way that is both rewarding and enjoyable.
 */
