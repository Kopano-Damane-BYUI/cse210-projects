using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your GPA? ");
        String gpa = Console.ReadLine();
        int gpaNum = int.Parse(gpa);
        Console.WriteLine();

        String letter;
        if (gpaNum >= 90)
        {
            letter = "A";
        }
        else if (gpaNum >= 80)
        {
            letter = "B";
        }
        else if (gpaNum >= 70)
        {
            letter = "C";
        }
        else if (gpaNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");
        Console.WriteLine();

        if (gpaNum >= 70)
        {
            Console.Write("Your GP is >= 70: Congratulations, You have passed this course.");
        }
        else
        {
            Console.Write("Your GP is below 70: Sorry, You have not made it through this course. You need to practise more and you will pass next time!!");
        }

    }
}