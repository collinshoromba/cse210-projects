class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return 60.0 / speed; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Speed: {speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}