class Activity
{
    protected DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class does not store distance
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class does not store speed
    }

    public virtual double GetPace()
    {
        return 0; // Base class does not store pace
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} (Generic Activity - {minutes} min)";
    }
}