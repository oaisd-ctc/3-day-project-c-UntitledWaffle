public static class GameStats
{
    public static int TotalStepsTaken { get; private set; }

    public static void IncrementSteps()
    {
        TotalStepsTaken++;
    }

    public static void DisplayGlobalStats()
    {
        Console.WriteLine($"Total Steps Taken by All Players: {TotalStepsTaken}");
    }
}