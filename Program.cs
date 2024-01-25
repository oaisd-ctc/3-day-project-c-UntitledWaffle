public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Shark RPG, please enter your player name.");
        string name = Console.ReadLine();
        Player player = new Player(name);

        while (true)
        {
            Console.WriteLine("\nChoose an action: \n1. Move \n2. Rest \n3. Explore \n4. Check Stats \n5. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    player.Move();
                    GameStats.IncrementSteps();
                    break;
                case "2":
                    // Implement Rest logic here
                    player.Rest();
                    break;
                case "3":
                    // Implement Explore logic here
                    player.Explore();
                    break;
                case "4":
                    player.DisplayStats();
                    GameStats.DisplayGlobalStats();
                    break;
                
                case "5":
        
                    Console.WriteLine("Exiting game...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

//The most basic code structure goes to the credit of Mr.Mart