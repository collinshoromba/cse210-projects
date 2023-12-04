// NegativeGoal.cs
class NegativeGoal : Goal
{
    public NegativeGoal(string name) : base(name) { }

    public override void RecordEvent()
    {
        Points -= 50; // Negative points for each instance
        System.Console.WriteLine($"Oops! You engaged in {Name}. Deducted 50 points.");
    }

    public override string Save()
    {
        return $"Negative,{base.Save()}";
    }

    public override void Load(string data)
    {
        base.Load(data);
    }
}

