using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Journal instance to manage entries: Initializes a new Journal object called 'myJournal'
        Journal myJournal = new Journal();

        // List of prompts to be randomly shown to the user
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // A loop to keep the menu active until user chooses to exit
        while (true)
        {
            // Clears the console screen to prepare for displaying the menu
            Console.Clear();
            // Display the menu options to the user
            Console.WriteLine("Journal Program Menu:");  // Prints the menu header
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to CSV");
            Console.WriteLine("4. Load journal from CSV");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option (1-5): ");  // Asks the user to select an option

            // Get the user's choice as a string
            string choice = Console.ReadLine();  // Reads the user's input from the console as a string

            // Checks if the user input is '1'
            if (choice == "1")
            {
                // Create a random number generator
                Random rand = new Random();
                // Select a random prompt from the list
                int randomIndex = rand.Next(prompts.Length);  // Generates a random number between 0 and the length of the prompts array
                string randomPrompt = prompts[randomIndex];  // Uses the random number to select a prompt from the prompts array

                // Display the selected prompt
                Console.WriteLine($"Today's prompt: {randomPrompt}");  // Displays the selected prompt to the user
                // Ask the user for their response
                Console.Write("Your response: ");
                string response = Console.ReadLine();  // Reads the user's response from the console

                // Add the entry to the journal
                myJournal.AddEntry(randomPrompt, response);  // Calls the AddEntry method of the Journal object to store the prompt and the user's response
                // Confirm the entry was added
                Console.WriteLine("Entry added successfully!\nPress any key to continue...");  // Informs the user that the entry was successfully added
                // Wait for the user to press a key before continuing
                Console.ReadKey();  // Waits for the user to press a key before proceeding
            }
            // If the user chooses to display the journal entries
            else if (choice == "2")
            {
                // Display all journal entries
                myJournal.DisplayEntries();  // Calls the DisplayEntries method of the Journal object to show all journal entries
                Console.WriteLine("Press any key to continue...");  // Prompts the user to press any key to continue
                Console.ReadKey();
            }
            // If the user chooses to save the journal to a CSV file
            else if (choice == "3")
            {
                // Ask the user for the filename to save to
                Console.Write("Enter the filename to save to: ");
                string fileName = Console.ReadLine();

                // Save the journal entries to the specified file in CSV format
                myJournal.SaveToCSV(fileName);  // Calls the SaveToCSV method of the Journal object to save the entries in CSV format
                // Confirm the journal was saved
                Console.WriteLine("Journal saved successfully to CSV!\nPress any key to continue...");
                Console.ReadKey();
            }
            // If the user chooses to load the journal from a CSV file
            else if (choice == "4")
            {
                // Ask the user for the filename to load from
                Console.Write("Enter the filename to load from: ");
                string fileName = Console.ReadLine();

                // Load the journal entries from the specified CSV file
                myJournal.LoadFromCSV(fileName);  // Calls the LoadFromCSV method of the Journal object to load the journal entries from the CSV file
                // Confirm the journal was loaded
                Console.WriteLine("Journal loaded successfully from CSV!\nPress any key to continue...");
                Console.ReadKey();
            }
            // If the user chooses to exit the program
            else if (choice == "5")
            {
                // Exit the loop and end the program
                break;
            }
            // If the user enters an invalid choice
            else
            {
                // Inform the user that the choice is invalid
                Console.WriteLine("Invalid choice. Please choose again.");
                Console.ReadKey();
            }
        }
    }
}

/*
    What I have done to exceed the requirements:

    - **Implemented CSV saving and loading functionality**:
      I added the ability for the journal to be saved and loaded as a CSV (Comma-Separated Values) file. This allows users to export their journal entries to a file that can be opened and analyzed in Excel or any other spreadsheet software. The CSV file format is simple, widely used, and allows for easy sharing of journal entries.

    - **Escaped special characters (commas and quotes)**:
      To ensure that the CSV format is valid, I implemented logic to escape commas and quotation marks in the journal entries. This prevents issues when exporting responses that may contain commas or quotes, ensuring that the CSV can be parsed correctly when loaded back into the application.

    - **Improved data portability and usability**:
      This feature exceeds the basic requirements by making the journal more portable. Users can now easily store and share their journal entries in a format that can be opened with commonly used tools like Excel. It also enhances the flexibility of the journal system, making it easier for users to keep a backup or perform data analysis if desired.
*/
