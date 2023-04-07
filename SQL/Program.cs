using Microsoft.Data.SqlClient;

namespace SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string CONN_STRING = "Data Source=DESKTOP-AC9THNH;Initial Catalog=Practice;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(CONN_STRING);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Movies";

            SqlDataReader reader = cmd.ExecuteReader();
            
            while(reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetInt32(2));
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine(reader.GetString(4));
                Console.WriteLine();
            }

            conn.Close();
        }
    }
}