using System;

class Program
{
    static void Main(string[] args)
    {
        MindfulnessApp mindfulnessApp = new MindfulnessApp();

        while (true)
        {
            Console.WriteLine("Mindfulness App Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    mindfulnessApp.StartBreathingActivity();
                    break;

                case "2":
                    mindfulnessApp.StartReflectionActivity();
                    break;

                case "3":
                    mindfulnessApp.StartListingActivity();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}