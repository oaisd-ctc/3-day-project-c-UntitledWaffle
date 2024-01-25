public static class GameStats
{
    public static int TotalStepsTaken { get; private set; }
    // Add new static properties here (e.g., TotalItemsFound, TotalEncounters)

    public static void IncrementSteps()
    {
        TotalStepsTaken++;
    
    }

    public static void DisplayGlobalStats()
    {
        Console.WriteLine($"Total Steps Taken by All Players: {TotalStepsTaken}");
        
        // Display other global stats here
        
    }

    // Add other static methods for global game functionalities here
}