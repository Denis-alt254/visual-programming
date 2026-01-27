using MySql.Data.MySqlClient;

namespace StudentFormApp
{
    public class DbConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connStr =
                "server=localhost;" +
                "user=root;" +
                "password=Deno8758@!;" +
                "database=schooldb;";

            return new MySqlConnection(connStr);
        }
    }
}
