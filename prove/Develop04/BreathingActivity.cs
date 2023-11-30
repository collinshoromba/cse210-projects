class BreathingActivity : MindfulnessActivity
{
    public override void Start()
    {
        DisplayStartingMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.WriteLine("Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(2000);
        }

        DisplayEndingMessage("Breathing");
    }
}
