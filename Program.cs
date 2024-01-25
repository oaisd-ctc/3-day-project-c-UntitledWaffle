public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mystic Forest Adventure!");

        // Create a new player
        Player player = new Player("Hero");

        // Game loop - simplified for the starter code
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

//The base code credit goes to Mr.Mart himself