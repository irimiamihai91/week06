using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp78
{
    class Database
    {
        public static SqlConnection ConnectToDatabase()
        {
            string connectionString = "Data Source = .;Initial Catalog = BookPublisher;Integrated Security  =true";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void ReaderBook(SqlConnection conn, string dcommand)
        {
            SqlCommand command = new SqlCommand(dcommand, conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["BookId"]},{reader["Title"]},{reader["Year"]},{reader["Price"]}");
                }
            }
        }
    }
}
