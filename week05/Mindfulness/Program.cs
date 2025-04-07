// Page: Program.cs
// This class is the entry point for the program and handles the menu system.

using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---\n"); // Add a title and space before the menu
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            Console.Clear();  // Clear the screen after user input

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.StartActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.StartActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                AddSpacing(); // Add some space after invalid input
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear(); // Clear the screen to go back to the main menu after a pause
        }
    }

    // Helper function for adding extra spaces for better readability in the main menu
    static void AddSpacing()
    {
        Console.WriteLine("\n"); // Add a line 
    }
}