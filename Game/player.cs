public class Player
{
    private string name;
    public int stepsTaken;

    private Item[] items;
    
    // Add new properties here (e.g., Health, Fatigue, Inventory)
    
    public Player(string name)
    {
        this.name = name;
        stepsTaken = 0;
        items = new Item[4];
        // Initialize new properties here
    }

    public string GetName()
    {
        return name;
    }

    // Add methods for Rest, Explore, and other actions here

    public void Move()
    {
        stepsTaken++;
        Console.WriteLine($"{name} moved one step forward.");

        // Implement the chance of a random encounter below:
    }

    public void DisplayStats()
    {
        Console.WriteLine($"{name}'s Steps: {stepsTaken}");
        // Display additional stats here

    }

    // Add additional methods for player interactions here
}