// namespace sportsManagement;

// public class print
// {

//      void PrintSportsTable()
//     {
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             connection.Open();

//             string query = "SELECT * FROM Sports";
//             SqlCommand command = new SqlCommand(query, connection);
//             SqlDataReader reader = command.ExecuteReader();

//             if (reader.HasRows)
//             {
//                 Console.WriteLine("Contents of Sports table:");
//                 Console.WriteLine("----------------------------------------------------------");
//                 Console.WriteLine("SportID | SportName | Description");
//                 Console.WriteLine("----------------------------------------------------------");

//                 while (reader.Read())
//                 {
//                     int sportId = reader.GetInt32(0);
//                     string sportName = reader.GetString(1);
//                     string description = reader.GetString(2);

//                     Console.WriteLine($"{sportId,-8} | {sportName,-10} | {description}");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Sports table is empty.");
//             }

//             reader.Close();
//         }
//     }

//     void PrintScoreboardTable()
//     {
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             connection.Open();

//             string query = "SELECT * FROM Scoreboard";
//             SqlCommand command = new SqlCommand(query, connection);
//             SqlDataReader reader = command.ExecuteReader();

//             if (reader.HasRows)
//             {
//                 Console.WriteLine("Contents of Scoreboard table:");
//                 Console.WriteLine("----------------------------------------------------------");
//                 Console.WriteLine("ScoreboardID | TournamentID | MatchID | TeamA | TeamB | ScoreA | ScoreB");
//                 Console.WriteLine("----------------------------------------------------------");

//                 while (reader.Read())
//                 {
//                     int scoreboardId = reader.GetInt32(0);
//                     int tournamentId = reader.GetInt32(1);
//                     int matchId = reader.GetInt32(2);
//                     string teamA = reader.GetString(3);
//                     string teamB = reader.GetString(4);
//                     int scoreA = reader.GetInt32(5);
//                     int scoreB = reader.GetInt32(6);

//                     Console.WriteLine($"{scoreboardId,-13} | {tournamentId,-13} | {matchId,-8} | {teamA,-10} | {teamB,-10} | {scoreA,-7} | {scoreB}");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Scoreboard table is empty.");
//             }

//             reader.Close();
//         }
//     }

//     void PrintPlayersTable()
//     {
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             connection.Open();

//             string query = "SELECT * FROM Players";
//             SqlCommand command = new SqlCommand(query, connection);
//             SqlDataReader reader = command.ExecuteReader();

//             if (reader.HasRows)
//             {
//                 Console.WriteLine("Contents of Players table:");
//                 Console.WriteLine("----------------------------------------------------------");
//                 Console.WriteLine("PlayerID | TournamentID | TeamName | PlayerName | Age");
//                 Console.WriteLine("----------------------------------------------------------");

//                 while (reader.Read())
//                 {
//                     int playerId = reader.GetInt32(0);
//                     int tournamentId = reader.GetInt32(1);
//                     string teamName = reader.GetString(2);
//                     string playerName = reader.GetString(3);
//                     int age = reader.GetInt32(4);

//                     Console.WriteLine($"{playerId,-10} | {tournamentId,-13} | {teamName,-10} | {playerName,-11} | {age}");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Players table is empty.");
//             }

//             reader.Close();
//         }
//     }

//     void PrintTournamentsTable()
//     {
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             connection.Open();

//             string query = "SELECT * FROM Tournaments";
//             SqlCommand command = new SqlCommand(query, connection);
//             SqlDataReader reader = command.ExecuteReader();

//             if (reader.HasRows)
//             {
//                 Console.WriteLine("Contents of Tournaments table:");
//                 Console.WriteLine("----------------------------------------------------------");
//                 Console.WriteLine("TournamentID | TournamentName | SportID");
//                 Console.WriteLine("----------------------------------------------------------");

//                 while (reader.Read())
//                 {
//                     int tournamentId = reader.GetInt32(0);
//                     string tournamentName = reader.GetString(1);
//                     int sportId = reader.GetInt32(2);

//                     Console.WriteLine($"{tournamentId,-13} | {tournamentName,-15} | {sportId}");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Tournaments table is empty.");
//             }

//             reader.Close();
//         }
//     }
// }
