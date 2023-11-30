abstract class MindfulnessActivity
{
    protected int duration;

    protected void DisplayStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"{activityName} Activity\n{description}");
        Console.Write("Enter the duration (in seconds): ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin. Starting in...");
        Countdown(3);
    }

    protected void DisplayEndingMessage(string activityName)
    {
        Console.WriteLine($"Great job! You have completed the {activityName} activity.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Countdown(5);
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(2000);
        }
        Console.WriteLine();
    }

    public abstract void Start();
}
