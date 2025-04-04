using System;

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // Test Math Assignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary()); // Summary
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Homework List

        // Test Writing Assignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary()); // Summary
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Writing Info
    }
}
