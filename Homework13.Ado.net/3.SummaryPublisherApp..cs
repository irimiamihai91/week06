using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _3.SummaryPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = BookPublisher ; Integrated Security = True");
            conn.Open();

            //NumberOfRowsOnPublisherTable(conn);

            //ShowTop5Publishers(conn);

            //NumbersOfBooksPerPublisher(conn);

            //TotalPriceForBooksForAPublisher(conn);

            Console.ReadKey();

        }

        private static void TotalPriceForBooksForAPublisher(SqlConnection conn)
        {
            SqlCommand command = new SqlCommand("TotalPriceForBooksForAPublisher", conn);

            //Create Procedure  TotalPriceForBooksForAPublisher
            //AS
            //Select p.Name, Sum(b.Price)
            //from Book b
            //left
            //join Publisher p ON p.PublisherId = b.PublisherId
            //Group by p.Name

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string rows = $"{reader[0]} , {reader[1]}";
                Console.WriteLine(rows);
            }

            conn.Close();
        }

        private static void NumbersOfBooksPerPublisher(SqlConnection conn)
        {
            SqlCommand command = new SqlCommand("NumbersOfBooksPerPublisher", conn); // stored procedure

        //Create Procedure NumbersOfBooksPerPublisher
        //AS
        //Select p.Name, Count(b.BookId) as NumberOfBooks
        //From Publisher p
        //Left Join Book b On p.PublisherId = b.PublisherId
        //Group By p.Name

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string rows = $"{reader["Name"]} , {reader["NumberOfBooks"]}";
                Console.WriteLine(rows);
            }
            conn.Close();
        }

        private static void ShowTop5Publishers(SqlConnection conn)
        {
            SqlCommand command = new SqlCommand("Select Top 5 * from Publisher ", conn);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string rows = $"{reader["PublisherId"]} , {reader["Name"]}";
                Console.WriteLine(rows);
            }

           
            conn.Close();
        }

        private static void NumberOfRowsOnPublisherTable(SqlConnection conn)
        {
            SqlCommand command = new SqlCommand("Select Count(*) from Publisher", conn);

            int No = (int)command.ExecuteScalar();

            Console.WriteLine(No);
            
            conn.Close();
        }
    }
}
