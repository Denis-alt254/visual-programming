using System;
using Microsoft.Data.SqlClient;

namespace SQLServerConnectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define connection string
            string connectionString = @"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True";
            
            // 2. Create SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // 3. Open connection
                    connection.Open();
                    Console.WriteLine("Connection to SQL Server successful!");

                    // 4. Define a query
                    string query = "SELECT TOP 5 * FROM Students"; // Example table

                    // 5. Create SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 6. Execute command and read data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming Students table has columns: Id, Name, Marks
                                Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Marks: {reader["Marks"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // 7. Close connection
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }

            Console.ReadLine(); // Keep console open
        }
    }
}
