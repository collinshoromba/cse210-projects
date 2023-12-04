// EternalGoal.cs
class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name) { }

    public override void RecordEvent()
    {
        Points += 100; // Points for each instance
        CheckForLevelUp();
    }

    private void CheckForLevelUp()
    {
        if (Points % 500 == 0) // Level up every 500 points
        {
            System.Console.WriteLine($"Congratulations! You leveled up! Current level: {Points / 500}");
        }
    }

    public override string Save()
    {
        return $"Eternal,{base.Save()}";
    }

    public override void Load(string data)
    {
        base.Load(data);
    }
}


