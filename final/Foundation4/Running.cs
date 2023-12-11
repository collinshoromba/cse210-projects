class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (minutes / 60.0); // Speed in miles per hour
    }

    public override double GetPace()
    {
        return minutes / distance; // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}