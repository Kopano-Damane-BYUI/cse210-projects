using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        // Display the welcome message
        static void DisplayWelcome()  // This is a method with no parameters and no return value
        {
            Console.WriteLine("Welcome to the Program!");  // Prints a welcome message to the console
        }

        // Ask for and return the user's name
        static string PromptUserName()  // This method asks for the user's name and returns it as a string
        {
            Console.Write("Please enter your name: ");  // Prompts the user to enter their name
            string userName = Console.ReadLine();  // Reads the user's input (their name)
            return userName;  // Returns the user's name
        }

        // Ask for and return the user's favorite number
        static int PromptUserNumber()  // This method asks for the user's favorite number and returns it as an integer
        {
            Console.Write("Please enter your favorite number: ");  // Prompts the user to enter their favorite number
            int userNumber = int.Parse(Console.ReadLine());  // Converts the user input to an integer
            return userNumber;  // Returns the user's favorite number
        }

        // Accept an integer and return the number squared
        static int SquareNumber(int number)  // This method takes an integer as input and returns the square of that number
        {
            return number * number;  // Returns the square of the input number
        }

        // Display the result
        static void DisplayResult(string userName, int squaredNumber)  // This method takes the user's name and squared number as parameters
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");  // Prints the result to the console
        }

        // Call the functions
        DisplayWelcome();  // Calls the DisplayWelcome method to show the welcome message

        string name = PromptUserName();  // Calls PromptUserName method and stores the result (the user's name) in the 'name' variable
        int favoriteNumber = PromptUserNumber();  // Calls PromptUserNumber method and stores the result (the favorite number) in 'favoriteNumber'
        int squaredNumber = SquareNumber(favoriteNumber);  // Calls SquareNumber method to square the favorite number and stores the result in 'squaredNumber'

        DisplayResult(name, squaredNumber);  // Calls DisplayResult method to display the user's name and the squared number
    }
}