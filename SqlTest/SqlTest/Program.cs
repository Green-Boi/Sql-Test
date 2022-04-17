using System;
using Microsoft.Data.Sqlite;

namespace SqlTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ok");
            string connectionString = @"Data Source=SqlTest.db";
            using (var connection = new SqliteConnection(connectionString))
            {

                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText =
                    @"CREATE TABLE IF NOT EXISTS drinking_water (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date TEXT,
                        Quantity INTEGER
                        )";

                tableCmd.ExecuteNonQuery();

                connection.Close();
                

            }

        
        }
    }
}
