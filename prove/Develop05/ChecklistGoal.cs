// ChecklistGoal.cs
class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int targetCount) : base(name)
    {
        this.targetCount = targetCount;
        completedCount = 0;
    }

    public override void RecordEvent()
    {
        Points += 50; // Points for each instance
        completedCount++;

        if (completedCount == targetCount)
        {
            Points += 500; // Bonus points for completing the checklist
            Completed = true;
            System.Console.WriteLine($"Congratulations! You completed the checklist and earned a bonus of 500 points!");
        }
    }

    public override string Save()
    {
        return $"Checklist,{base.Save()},{targetCount},{completedCount}";
    }

    public override void Load(string data)
    {
        base.Load(data);

        string[] parts = data.Split(',');

        // Make sure the array has enough elements before accessing them
        if (parts.Length >= 5)
        {
            targetCount = int.Parse(parts[3]);

            // Parse the boolean value safely
            if (int.TryParse(parts[4], out int parsedCompleted))
            {
                Completed = (parsedCompleted != 0); // Convert to boolean
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

    public override void DisplayProgress()
    {
        System.Console.WriteLine($"{Name} - [{(Completed ? 'X' : ' ')}] - Completed {completedCount}/{targetCount} times - Points: {Points}");
    }
}



