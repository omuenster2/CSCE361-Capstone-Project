using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Define the connection string
        string connectionString = "Server=localhost;Database=CSCE361 Capstone Project;Integrated Security=True;";

        // Create a connection
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful.");

                // Create a command to execute a SQL query or stored procedure
                SqlCommand command = new SqlCommand("SELECT customerID, userName FROM customer", connection);

                // Execute the command and read data
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Column1: {reader["customerID"]}, Column2: {reader["userName"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}