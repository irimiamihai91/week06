using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = .; Initial Catalog = Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            // sau connection.ConnectionString = connectionString
            connection.Open();

            //SelectBookIdTitlePriceFromBook(connection);

            //SelectTitleWhereBookIdIs1(connection);

            //InsertBookSimple(connection);

            //InsertBookParameters(connection);

            //InsertBookUsingConsole(connection);

            string connectionStringAltex = "Data Source=.; Initial Catalog = Altex; Integrated Security = True";
            SqlConnection AltexConnection = new SqlConnection(connectionStringAltex);
            AltexConnection.Open();

            SelectProductNameFromAltex(AltexConnection);

        }

        private static void SelectProductNameFromAltex(SqlConnection AltexConnection)
        {
            SqlCommand selectProductName = new SqlCommand("SELECT Name from Product", AltexConnection);

            SqlDataReader readerProduct = selectProductName.ExecuteReader();

            while (readerProduct.Read())
            {
                string ProductName = $"{readerProduct["Name"]}";
                Console.WriteLine(ProductName);

            }

            Console.ReadKey();
            readerProduct.Close();
            AltexConnection.Close();
        }

        private static void InsertBookUsingConsole(SqlConnection connection)
        {
            Console.WriteLine("Please insert Book Title (string)");
            string Title = Console.ReadLine();
            Console.WriteLine("Please insert PublisherId (int- from 1 to 5)");
            int PublisherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert Year (int)");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert Price (int)");
            double Price = Convert.ToDouble(Console.ReadLine());


            SqlParameter TitleParam = new SqlParameter();
            TitleParam.Value = Title;
            TitleParam.ParameterName = "Title";
            SqlParameter PublisherIdParam = new SqlParameter()
            {
                Value = PublisherId,
                ParameterName = "PublisherId"
            };
            SqlParameter YearParam = new SqlParameter();
            YearParam.Value = Year;
            YearParam.ParameterName = "Year";
            SqlParameter PriceParam = new SqlParameter();
            PriceParam.Value = Price;
            PriceParam.ParameterName = "Price";

            string InsertCommand = "Insert into Book (Title,PublisherId,Year,Price) Values (@Title,@PublisherId,@Year,@Price)";
            SqlCommand command = new SqlCommand(InsertCommand);
            command.Connection = connection;
            command.Parameters.Add(TitleParam);
            command.Parameters.Add(PublisherIdParam);
            command.Parameters.Add(YearParam);
            command.Parameters.Add(PriceParam);
            command.ExecuteNonQuery();
            Console.WriteLine("Book inserted");
            Console.ReadKey();
            
            connection.Close();
        }


        private static void InsertBookParameters(SqlConnection connection)
        {
            SqlParameter TitleParam = new SqlParameter();
            TitleParam.Value = "HelloWorld";
            TitleParam.ParameterName = "Title";
            SqlParameter PublisherIdParam = new SqlParameter()
            {
                Value = 2,
                ParameterName = "PublisherId"
            };
            SqlParameter YearParam = new SqlParameter();
            YearParam.Value = 2001;
            YearParam.ParameterName = "Year";
            SqlParameter PriceParam = new SqlParameter();
            PriceParam.Value = 21;
            PriceParam.ParameterName = "Price";

            string InsertCommand = "Insert into Book (Title,PublisherId,Year,Price) Values (@Title,@PublisherId,@Year,@Price)";
            SqlCommand command = new SqlCommand(InsertCommand);
            command.Connection = connection;
            command.Parameters.Add(TitleParam);
            command.Parameters.Add(PublisherIdParam);
            command.Parameters.Add(YearParam);
            command.Parameters.Add(PriceParam);
            command.ExecuteNonQuery();
            Console.WriteLine("Book inserted");
            Console.ReadKey();
            
            connection.Close();
        }

        private static void InsertBookSimple(SqlConnection connection)
        {
            string InsertCommand = "Insert into Book (Title,PublisherId,Year,Price) Values ('Cartea Cartilor',2,1991,12)";
            SqlCommand command = new SqlCommand(InsertCommand);
            command.Connection = connection;
            command.ExecuteNonQuery();
            Console.WriteLine("Book inserted");
            Console.ReadKey();
            
            connection.Close();
        }

        private static void SelectTitleWhereBookIdIs1(SqlConnection connection)
        {
            string selectScalarCommand = "Select Title from Book where BookId = 1";
            SqlCommand command = new SqlCommand(selectScalarCommand);
            command.Connection = connection;
            string i = (string)command.ExecuteScalar();
            Console.WriteLine(i);
            Console.ReadKey();
            
            connection.Close();
        }

        private static void SelectBookIdTitlePriceFromBook(SqlConnection connection)
        {
            string selectCommand = "Select * from Book";
            SqlCommand command = new SqlCommand(selectCommand);
            //selectCommand.CommandText = command;

            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    string book = $"{reader["BookId"]},\t{reader["Title"]},\t\t{reader["Price"]}";
                
            //    Console.WriteLine(book);
            //}


            Console.ReadKey();
            reader.Close();
            connection.Close();
        }
    }
}
