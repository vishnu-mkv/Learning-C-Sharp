// C# code for College Sports Management System
using Microsoft.Data.SqlClient;

public class SportsManagementSystem
{
    private string connectionString = "Data Source=DESKTOP-AC9THNH;Initial Catalog=Practice;Integrated Security=True;Encrypt=False;";

    public SportsManagementSystem()
    {
        createTables();
    }

    void createTables()
    {
        if (!TableExists("Sports"))
        {
            // Create Sports table
            CreateSportsTable();
        }

        // Check if Scoreboards table exists
        if (!TableExists("Scoreboards"))
        {
            // Create Scoreboards table
            CreateScoreboardsTable();
        }

        // Check if Tournaments table exists
        if (!TableExists("Tournaments"))
        {
            // Create Tournaments table
            CreateTournamentsTable();
        }

        // Check if Players table exists
        if (!TableExists("Players"))
        {
            // Create Players table
            CreatePlayersTable();
        }
    }

    bool TableExists(string tableName)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @TableName";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TableName", tableName);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
    }


    void CreateSportsTable()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(
                @"CREATE TABLE Sports
                (
                    SportID INT IDENTITY(1,1) PRIMARY KEY ,
                    SportName VARCHAR(50),
                    Description VARCHAR(255)
                )", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Sports table created successfully.");
            }
        }
    }

    void CreateScoreboardsTable()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Create Scoreboard table
            string createScoreboardQuery = @"
                CREATE TABLE Scoreboard (
                    ScoreboardID INT PRIMARY KEY IDENTITY(1,1),
                    PlayerID INT,
                    Score INT,
                    FOREIGN KEY (PlayerID) REFERENCES Players (PlayerID)
                )";
            using (SqlCommand command = new SqlCommand(createScoreboardQuery, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Scoreboard table created successfully.");
            }
        }
    }

    void CreateTournamentsTable()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(
                @"CREATE TABLE Tournaments
                (
                    TournamentID IDENTITY(1,1) INT PRIMARY KEY,
                    TournamentName VARCHAR(50),
                    SportID INT,
                    FOREIGN KEY (SportID) REFERENCES Sports (SportID)
                )", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Tournaments table created successfully.");
            }
        }
    }

    void CreatePlayersTable()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(
                @"CREATE TABLE Players
                (
                    PlayerID INT IDENTITY(1,1) PRIMARY KEY,
                    PlayerName VARCHAR(50),
                    TournamentID INT,
                    FOREIGN KEY (TournamentID) REFERENCES Tournaments (TournamentID)
                )", connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Players table created successfully.");
            }
        }
    }

    public void AddSport()
    {
        Console.WriteLine("Enter the name of the sport:");
        string sportName = Console.ReadLine()!;
        Console.WriteLine("Enter the description of the sport:");
        string description = Console.ReadLine()!;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(
                @"INSERT INTO Sports (SportName, Description)
                VALUES (@SportName, @Description); SELECT SCOPE_IDENTITY()", connection))
            {
                command.Parameters.AddWithValue("@SportName", sportName);
                command.Parameters.AddWithValue("@Description", description);
                int newSportID = Convert.ToInt32(command.ExecuteScalar());
                if (newSportID > 0)
                {
                    Console.WriteLine("Sport added successfully with SportID: " + newSportID);
                }
                else
                {
                    Console.WriteLine("Failed to add sport.");
                }
            }
        }
    }

    public void AddTournament()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Enter TournamentName: ");
            string tournamentName = Console.ReadLine()!;
            Console.WriteLine("Enter SportID: ");
            int sportId = Convert.ToInt32(Console.ReadLine());

            string query = $@"INSERT INTO Tournaments (TournamentName, SportID)
                        VALUES ('{tournamentName}', {sportId});
                        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            object result = command.ExecuteScalar();
            if (result != null)
            {
                int tournamentId = Convert.ToInt32(result);
                Console.WriteLine($"TournamentID: {tournamentId} has been created successfully.");
            }
        }
    }

    public void RemoveSport()
    {
        Console.WriteLine("Enter SportID to remove: ");
        int sportId = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Check if the sport exists in the Sports table
            string checkQuery = $"SELECT COUNT(*) FROM Sports WHERE SportID = {sportId}";
            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (count > 0)
            {
                // Remove the sport from the Sports table
                string removeQuery = $"DELETE FROM Sports WHERE SportID = {sportId}";
                SqlCommand removeCommand = new SqlCommand(removeQuery, connection);
                int rowsAffected = removeCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Sport with SportID: {sportId} has been removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to remove sport with SportID: {sportId}.");
                }
            }
            else
            {
                Console.WriteLine($"Sport with SportID: {sportId} does not exist in the system.");
            }
        }
    }

    public void RemoveTournament()
    {

        Console.WriteLine("Enter Tournament id: ");
        int tournamentId = Convert.ToInt32(Console.ReadLine()!);

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Delete tournament from Tournaments table
            string deleteTournamentQuery = "DELETE FROM Tournaments WHERE TournamentID = @TournamentID";
            using (SqlCommand command = new SqlCommand(deleteTournamentQuery, connection))
            {
                command.Parameters.AddWithValue("@TournamentID", tournamentId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Tournament with ID {tournamentId} has been removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Tournament with ID {tournamentId} not found.");
                }
            }
        }
    }

    // Method to add a player
    public void AddPlayer()
    {
        Console.WriteLine("Enter player name: ");
        string playerName = Console.ReadLine()!;

        Console.WriteLine("Enter tournament ID: ");
        int tournamentId = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Insert player into Players table
            string insertPlayerQuery = "INSERT INTO Players (PlayerName, TournamentID) VALUES (@PlayerName, @TournamentID); SELECT SCOPE_IDENTITY()";
            using (SqlCommand command = new SqlCommand(insertPlayerQuery, connection))
            {
                command.Parameters.AddWithValue("@PlayerName", playerName);
                command.Parameters.AddWithValue("@TournamentID", tournamentId);

                int playerId = Convert.ToInt32(command.ExecuteScalar());
                Console.WriteLine($"Player with ID {playerId} has been added successfully.");
            }
        }
    }


    // Method to remove a player by player ID
    public void RemovePlayer()
    {
        Console.Write("Enter Player ID: ");
        int playerId = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Delete player from Players table
            string deletePlayerQuery = "DELETE FROM Players WHERE PlayerID = @PlayerID";
            using (SqlCommand command = new SqlCommand(deletePlayerQuery, connection))
            {
                command.Parameters.AddWithValue("@PlayerID", playerId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Player with ID {playerId} has been removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Player with ID {playerId} not found.");
                }
            }
        }
    }


    // Method to add a scoreboard entry
    public void AddScoreboardEntry()
    {
        Console.WriteLine("Enter player ID: ");
        int playerId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Insert scoreboard entry into Scoreboard table
            string insertScoreboardQuery = "INSERT INTO Scoreboard (PlayerID, Score) VALUES (@PlayerID, @Score)";
            using (SqlCommand command = new SqlCommand(insertScoreboardQuery, connection))
            {
                command.Parameters.AddWithValue("@PlayerID", playerId);
                command.Parameters.AddWithValue("@Score", score);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Scoreboard entry added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add scoreboard entry.");
                }
            }
        }
    }


    // Method to update a scoreboard entry
    // Method to update a scoreboard entry
    public void UpdateScoreboardEntry()
    {
        Console.WriteLine("Enter player ID: ");
        int playerId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Update scoreboard entry in Scoreboard table
            string updateScoreboardQuery = "UPDATE Scoreboard SET Score = @Score WHERE PlayerID = @PlayerID";
            using (SqlCommand command = new SqlCommand(updateScoreboardQuery, connection))
            {
                command.Parameters.AddWithValue("@PlayerID", playerId);
                command.Parameters.AddWithValue("@Score", score);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Scoreboard entry updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update scoreboard entry. Please make sure the PlayerID is valid.");
                }
            }
        }
    }



}

