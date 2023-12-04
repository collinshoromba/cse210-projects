// Program.cs
using System;


class Program
{
    static List<Goal> goals = new List<Goal>();
    static User currentUser;

    static void Main(string[] args)
    {
        LoadGoalsFromFile();

        while (true)
        {
            Console.WriteLine("Eternal Quest - Goal Tracking Program");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        DisplayGoals();
                        break;
                    case 2:
                        AddNewGoal();
                        break;
                    case 3:
                        RecordEvent();
                        break;
                    case 4:
                        SaveGoalsToFile();
                        break;
                    case 5:
                        SaveGoalsToFile(); // Save before exiting
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine();
        }
    }

    static void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to display. Add a new goal to get started.");
        }
        else
        {
            foreach (var goal in goals)
            {
                goal.DisplayProgress();
            }
        }
    }

    static void AddNewGoal()
    {
        Console.Write("Enter the name of the new goal: ");
        string goalName = Console.ReadLine();

        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");

        if (int.TryParse(Console.ReadLine(), out int goalType))
        {
            switch (goalType)
            {
                case 1:
                    goals.Add(new Goal(goalName));
                    Console.WriteLine("Simple goal added.");
                    break;
                case 2:
                    goals.Add(new EternalGoal(goalName));
                    Console.WriteLine("Eternal goal added.");
                    break;
                case 3:
                    Console.Write("Enter the number of times the goal must be completed: ");
                    if (int.TryParse(Console.ReadLine(), out int targetCount))
                    {
                        goals.Add(new ChecklistGoal(goalName, targetCount));
                        Console.WriteLine("Checklist goal added.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for target count. Please enter a number.");
                    }
                    break;
                case 4:
                    goals.Add(new NegativeGoal(goalName));
                    Console.WriteLine("Negative goal added.");
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please enter a number between 1 and 4.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input for goal type. Please enter a number.");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= goals.Count)
        {
            goals[goalIndex - 1].RecordEvent();
            Console.WriteLine($"Event recorded for {goals[goalIndex - 1].Name}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

    static void SaveGoalsToFile()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Save());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoalsFromFile()
    {
        if (File.Exists("goals.txt"))
        {
            string[] goalData = File.ReadAllLines("goals.txt");
            foreach (var data in goalData)
            {
                string[] parts = data.Split(',');
                Goal goal;
                switch (parts[0])
                {
                    case "Eternal":
                        goal = new EternalGoal(parts[1]);
                        break;
                    case "Checklist":
                        goal = new ChecklistGoal(parts[1], int.Parse(parts[4]));
                        break;
                    case "Negative":
                        goal = new NegativeGoal(parts[1]);
                        break;
                    default:
                        goal = new Goal(parts[1]);
                        break;
                }
                goal.Load(data);
                goals.Add(goal);
            }
        }
    }
}
