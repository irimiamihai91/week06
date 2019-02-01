using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _4.CrudBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = .; Initial Catalog = BookPublisher; Integrated Security  = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //InsertABookAndPrintTheId(conn);

            //UpdateTitlePublisherIdYearPriceFromBook(conn);

            //DeleteBookUsingBookId(conn);

            //ReadABookUsingBookId(conn);

            Console.ReadKey();


        }

        private static void ReadABookUsingBookId(SqlConnection conn)
        {
            Console.WriteLine("Please insert Book Id to be visualized : ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            SqlParameter bookIdParam = new SqlParameter() { Value = bookId, ParameterName = "bookId" };

            string selectBook = "select * from book where BookId= @bookId";
            SqlCommand command = new SqlCommand(selectBook, conn);
            command.Parameters.Add(bookIdParam);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string book = $"{reader["BookId"]}, {reader["Title"]},{reader["Year"]},{reader["Price"]}";
                Console.WriteLine(book);
            }

            conn.Close();
        }

        private static void DeleteBookUsingBookId(SqlConnection conn)
        {
            

            try
            {
                Console.WriteLine("Please insert BookId to be deleted");
                int bookId = Convert.ToInt32(Console.ReadLine());

                SqlParameter bookIdParam = new SqlParameter() { Value = bookId, ParameterName = "bookId" };

                string deleteBookCommand = "Delete from book where BookId = @bookId";

                SqlCommand command = new SqlCommand(deleteBookCommand, conn);

                command.Parameters.Add(bookIdParam);

                command.ExecuteNonQuery();

                Console.WriteLine($"Book with Id {bookId} has been deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }

            
        }

        private static void UpdateTitlePublisherIdYearPriceFromBook(SqlConnection conn)
        {
            Console.WriteLine("Please insert Book Id to be updated");
            int bookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert new Title");
            string title = Console.ReadLine();
            Console.WriteLine("Please insert new PublisherId ");
            int publisherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert new Year ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert new Price ");
            double price = Convert.ToDouble(Console.ReadLine());

            SqlParameter bookIdParam = new SqlParameter() { Value = bookId, ParameterName = "bookId" };
            SqlParameter titleParam = new SqlParameter() { Value = title, ParameterName = "title" };
            SqlParameter publisherIddParam = new SqlParameter() { Value = publisherId, ParameterName = "publisherId" };
            SqlParameter yeardParam = new SqlParameter() { Value = year, ParameterName = "year" };
            SqlParameter pricedParam = new SqlParameter() { Value = price, ParameterName = "Price" };

            string updateBookCommand = "Update Book Set Title = @title, PublisherId = @publisherId, Year = @year, Price = @price Where BookId = @bookId";
            SqlCommand command = new SqlCommand(updateBookCommand, conn);
            command.Parameters.Add(bookIdParam);
            command.Parameters.Add(titleParam);
            command.Parameters.Add(publisherIddParam);
            command.Parameters.Add(yeardParam);
            command.Parameters.Add(pricedParam);

            command.ExecuteNonQuery();
            Console.WriteLine($"Book with Id {bookId} has been updated .New values Title : {title}, PublisherId: {publisherId}, Year:{year}, Price : {price}");
            conn.Close();
        }

        private static void InsertABookAndPrintTheId(SqlConnection conn)
        {
            Console.WriteLine("Please insert Book Title (string)");
            string title = Console.ReadLine();
            Console.WriteLine("Please insert Publisher Id(Int 1 to 8)");
            int publisherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert Year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert Price");
            double price = Convert.ToDouble(Console.ReadLine());

            SqlParameter TitleParam = new SqlParameter()
            {
                Value = title,
                ParameterName = "Title"
            };

            SqlParameter PublisherIdParam = new SqlParameter()
            {
                Value = publisherId,
                ParameterName = "PublisherId"
            };
            SqlParameter YearParam = new SqlParameter()
            {
                Value = year,
                ParameterName = "Year"
            };
            SqlParameter PriceParam = new SqlParameter()
            {
                Value = price,
                ParameterName = "Price"
            };


            string insertBookCommand = "Insert Into Book (Title,PublisherId,Year,Price) Values (@Title,@PublisherId,@Year,@Price); SELECT CAST(scope_identity() AS int)";
            SqlCommand command = new SqlCommand(insertBookCommand);
            command.Connection = conn;
            command.Parameters.Add(TitleParam);
            command.Parameters.Add(PublisherIdParam);
            command.Parameters.Add(YearParam);
            command.Parameters.Add(PriceParam);
            
            int Id = (int)command.ExecuteScalar();
            Console.WriteLine("Book has been inserted");
            Console.WriteLine($"Inserted BookID {Id}");


            conn.Close();
        }
    }
}
