using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>();

        DateTime date1 = new DateTime(2022, 11, 3);
        Activity runningActivity = new Running(date1, 30, 3.0);
        activities.Add(runningActivity);

        DateTime date2 = new DateTime(2022, 11, 3);
        Activity cyclingActivity = new Cycling(date2, 45, 15.0);
        activities.Add(cyclingActivity);

        DateTime date3 = new DateTime(2022, 11, 3);
        Activity swimmingActivity = new Swimming(date3, 20, 10);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}