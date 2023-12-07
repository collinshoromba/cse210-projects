// Goal.cs
using System;

class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public Goal(string name)
    {
        Name = name;
        Points = 0;
        Completed = false;
    }

    public virtual void RecordEvent()
    {
        Points += 100; // Default points for simple goals
        Completed = true;
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"{Name} - [{(Completed ? 'X' : ' ')}] - Points: {Points}");
    }

    public virtual string Save()
    {
        return $"{Name},{Points},{Completed}";
    }

    public virtual void Load(string data)
    {
        string[] parts = data.Split(',');

        
        if (parts.Length >= 3)
        {
            Name = parts[0];
            // Parse the integer values safely
            if (int.TryParse(parts[1], out int parsedPoints))
            {
                Points = parsedPoints;
            }
            else
            {
                Console.WriteLine($"Error parsing points for goal '{Name}'. Defaulting to 0 points.");
                Points = 0;
            }

            if (bool.TryParse(parts[2], out bool parsedCompleted))
            {
                Completed = parsedCompleted;
            }
            else
            {
                Console.WriteLine($"Error parsing completion status for goal '{Name}'. Defaulting to 'false'.");
                Completed = false;
            }
        }
        else
        {
            Console.WriteLine($"Error loading goal '{Name}'. Invalid data format.");
        }
    }
}

