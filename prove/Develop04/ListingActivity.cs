class ListingActivity : MindfulnessActivity
{
    private readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Start()
    {
        DisplayStartingMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string randomPrompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(randomPrompt);
        Countdown(5);

        Console.WriteLine("Start listing as many items as you can...");
        Thread.Sleep(duration * 2000);

        int itemCount = new Random().Next(5, 15);
        Console.WriteLine($"Number of items entered: {itemCount}");
        Countdown(2);

        DisplayEndingMessage("Listing");
    }
}