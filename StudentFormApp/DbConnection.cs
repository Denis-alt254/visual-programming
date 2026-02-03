using Microsoft.Data.SqlClient;

namespace StudentFormApp
{
    public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True";


            return new SqlConnection(connStr);
        }
    }
}
