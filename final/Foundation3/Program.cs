using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main St", "Cityville", "CA", "USA");

        Event genericEvent = new Event("Generic Event", "An event for testing", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), eventAddress);
        Console.WriteLine("Standard Details:\n" + genericEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + genericEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + genericEvent.GetShortDescription());

        Lecture lectureEvent = new Lecture("Tech Talk", "Learn about new technologies", DateTime.Now.AddDays(14), new TimeSpan(18, 30, 0), eventAddress, "John Doe", 100);
        Console.WriteLine("\n\nStandard Details:\n" + lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + lectureEvent.GetShortDescription());

        Reception receptionEvent = new Reception("Networking Night", "Meet and greet with professionals", DateTime.Now.AddDays(21), new TimeSpan(19, 0, 0), eventAddress, "rsvp@example.com");
        Console.WriteLine("\n\nStandard Details:\n" + receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + receptionEvent.GetShortDescription());

        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "Enjoy the sun and fun activities", DateTime.Now.AddDays(30), new TimeSpan(12, 0, 0), eventAddress, "Sunny with a chance of clouds");
        Console.WriteLine("\n\nStandard Details:\n" + outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n" + outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:\n" + outdoorEvent.GetShortDescription());
    }
}