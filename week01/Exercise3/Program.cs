using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int mNum = random.Next(1, 101);

        Console.Write("What is your guess? ");
        string num2 = Console.ReadLine();
        int guess = int.Parse(num2);

        while (guess != mNum)
        {
            if (guess < mNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > mNum)
            {
                Console.WriteLine("Lower");
            }

            // Ask for another guess inside the loop
            Console.Write("What is your guess? ");
            num2 = Console.ReadLine();
            guess = int.Parse(num2);  // Update the guess
        }

        Console.WriteLine("You guessed it!");

    }
}