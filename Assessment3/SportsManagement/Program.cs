using System;

class Program
{
    static void Main(string[] args)
    {
        SportsManagementSystem sportsManagementSystem = new SportsManagementSystem();

        while (true)
        {
            Console.WriteLine("Sports Management System");
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Remove Player");
            Console.WriteLine("3. Add Tournament");
            Console.WriteLine("4. Remove Tournament");
            Console.WriteLine("5. Add Sport");
            Console.WriteLine("6. Remove Sport");
            Console.WriteLine("7. Add Scoreboard Entry");
            Console.WriteLine("8. Update Scoreboard Entry");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice (1/2/3/4/5/6/7/8/9): ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    sportsManagementSystem.AddPlayer();
                    break;
                case "2":
                    sportsManagementSystem.RemovePlayer();
                    break;
                case "3":
                    sportsManagementSystem.AddTournament();
                    break;
                case "4":
                    sportsManagementSystem.RemoveTournament();
                    break;
                case "5":
                    sportsManagementSystem.AddSport();
                    break;
                case "6":
                    sportsManagementSystem.RemoveSport();
                    break;
                case "7":
                    sportsManagementSystem.AddScoreboardEntry();
                    break;
                case "8":
                    sportsManagementSystem.UpdateScoreboardEntry();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
