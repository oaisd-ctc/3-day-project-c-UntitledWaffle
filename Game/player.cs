public class Player
{
    private string name;
    public int stepsTaken;

    private Item[] items;
    public Player(string name)
    {
        this.name = name;
        stepsTaken = 0;
        items = new Item[4];
    }

    public string GetName()
    {
        return name;
    }

    public void Move()
    {
        stepsTaken++;
        Console.WriteLine($"{name} moved one step forward.");

    }

    public void DisplayStats()
    {
        Console.WriteLine($"{name}'s Steps: {stepsTaken}");

    }

}