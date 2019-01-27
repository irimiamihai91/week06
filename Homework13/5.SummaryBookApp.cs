using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SummaryBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = .; Initial Catalog = BookPublisher; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //ShowBookByYear(conn);

            //BookPublishedInMaxYear(conn);

            //BookPublishedInMaxYear2Selects(conn);

            //Top5Books(conn);

            Console.ReadKey();


        }

        private static void Top5Books(SqlConnection conn)
        {
            SqlCommand command = new SqlCommand("Top5Books", conn);

            //Create Procedure Top5Books
            //AS
            //SELECT TOP 5 Title,Year,Price FROM Book;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Title:{reader["Title"]},Year: {reader["Year"]}, Price: {reader["Price"]}");
            }

            reader.Close();
            conn.Close();
        }

        private static void BookPublishedInMaxYear2Selects(SqlConnection conn)
        {
            string maxYear = "SELECT Max(Year) as MaxYear from Book";
            SqlCommand command = new SqlCommand(maxYear, conn);

            int yearMax = (int)command.ExecuteScalar();
            Console.WriteLine($"Maximum year : {yearMax}");

            SqlParameter yearMaxParam = new SqlParameter() { Value = yearMax, ParameterName = "yearMax" };

            string booksInYearMax = "Select * from Book where Year = @yearMax";
            SqlCommand command1 = new SqlCommand(booksInYearMax, conn);
            command1.Parameters.Add(yearMaxParam);

            SqlDataReader reader = command1.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Book Id : {reader["BookId"]},Title:{reader["Title"]},Year: {reader["Year"]}, Price: {reader["Price"]}");
            }

            reader.Close();
            conn.Close();
        }

        private static void BookPublishedInMaxYear(SqlConnection conn)
        {
            string selectBookInMaxYear = "SELECT * FROM Book WHERE Year in (SELECT MAX(Year) FROM Book)";
            SqlCommand command = new SqlCommand(selectBookInMaxYear, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Book Id : {reader["BookId"]},Title:{reader["Title"]},Year: {reader["Year"]}, Price: {reader["Price"]}");
            }
            reader.Close();
            conn.Close();
        }

        private static void ShowBookByYear(SqlConnection conn)
        {
            Console.WriteLine("Please insert year");
            int year = Convert.ToInt32(Console.ReadLine());

            SqlParameter yearParam = new SqlParameter() { Value = year, ParameterName = "year" };

            string selectBookByYear = "select * from book where Year = @year";
            SqlCommand command = new SqlCommand(selectBookByYear, conn);
            command.Parameters.Add(yearParam);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                do
                {
                    string book = $"Title:{reader["Title"]},Year: {reader["Year"]}, Price: {reader["Price"]}";
                    Console.WriteLine($"{book}");
                } while (reader.Read());

            }

            else
            {
                Console.WriteLine("We do not have any books published in that year");
            }
        }

    }
    }

