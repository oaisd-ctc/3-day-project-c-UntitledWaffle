using System.Collections;
using System.Globalization;
using System.Transactions;

public class Player
{
    private string name;
    protected int Maxhealth;

public int Fatigue;
    public int rest;
    public int stepsTaken;
    private Item[] items;
    
    // Add new properties here (e.g., Health, Fatigue, Inventory)

    

    public Player(string name)
    {
        this.name = name;
        stepsTaken = 0;
        items = new Item[4];
        Maxhealth =10;
        Fatigue = 0;
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
        Random rnd = new Random();
for(int n = 1; n == 1; n ++){
int i = rnd.Next(1,10);
if(i == stepsTaken){
Console.WriteLine("oh no a enemy youve taken 5 damage!");
for(int e =0; e <5;e++){
Maxhealth--;
if(Maxhealth == 0){
    Console.Clear();
    GameOver();
    break;
}
}

}
break;
}
    }
public void Explore()
{
Console.WriteLine("you found nothing");
}

public void GameOver(){
    if(Maxhealth == 0){
        Console.WriteLine("your health is:" + Maxhealth);
        Console.WriteLine("Game Over! you died");
        return;
    }
}
public void Gamewin(){
    if(stepsTaken==10){
        Console.Clear();
        Console.WriteLine("You Won!");
    }
}
    public void Rest(){
            for(int h =0; h <5;h++){

        if (Maxhealth < 10){
        Maxhealth++;
        }
            }
        if (Fatigue > 0){
            Fatigue--;
        }
        
        Console.WriteLine($"{name} takes a rest.");
        
    }

    public void DisplayStats()
    {
        Console.WriteLine($"{name}'s Steps: {stepsTaken}");
        // Display additional stats here
        Console.WriteLine($"{name}'s Health:{Maxhealth}");

        Console.WriteLine($"{name}'s fatigue:{Fatigue}");
    }

    // Add additional methods for player interactions here
}