// ========================================
// File: GoalManager.cs
// Description: Manages list of goals, score, level system, save/load
// ========================================
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore() => _score;
    public int GetLevel() => _score / 1000;

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type!!");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Goal chosen choice: ");
        string choice = Console.ReadLine();

        Console.Write("Name of the Goal: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string desc = Console.ReadLine();
        Console.Write("Points this goal is worth when [Completed]: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points when [completed]: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }

    public void DisplayGoals()
    {
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index++}. {goal.GetStatus()}");
        }
    }

    public void RecordGoal()
    {
        DisplayGoals();
        Console.Write("Which goal did you complete? ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;

            if (index >= 0 && index < _goals.Count)
            {
                int gained = _goals[index].RecordEvent();
                _score += gained;

                Console.WriteLine($"You earned {gained} points!");

                if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
                {
                    Console.WriteLine($"🎉 You earned a badge for completing '{_goals[index].GetName()}'!");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save (e.g. goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("✅ Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load (e.g. goals.txt): ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] data = parts[1].Split('|');

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(data[3]);
                        var simple = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        if (isComplete)
                        {
                            // Hacky but simple way to force it to complete
                            simple.RecordEvent();
                        }
                        _goals.Add(simple);
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;

                    case "ChecklistGoal":
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        int bonus = int.Parse(data[3]);
                        int target = int.Parse(data[4]);
                        int progress = int.Parse(data[5]);
                        var checklist = new ChecklistGoal(name, description, points, target, bonus);

                        // Set current progress
                        for (int j = 0; j < progress; j++)
                        {
                            checklist.RecordEvent();
                        }
                        _goals.Add(checklist);
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type in file: {type}");
                        break;
                }
            }

            Console.WriteLine("✅ Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("❌ File not found.");
        }
    }
}