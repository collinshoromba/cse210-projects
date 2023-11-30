class MindfulnessApp
{
    public void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Start();
    }

    public void StartReflectionActivity()
    {
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.Start();
    }

    public void StartListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Start();
    }
}