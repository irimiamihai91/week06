using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InsertPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.; Initial Catalog = BookPublisher; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            PrintPublisherNameWhereIdIs1(conn);

            //InsertPublisherIdAndNameFromConsoleAndRetrieveId(conn);

        }

        private static void InsertPublisherIdAndNameFromConsoleAndRetrieveId(SqlConnection conn)
        {
            Console.WriteLine("Please insert Publisher Id : (int)");
            int PublisherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert Publisher Name : (string)");
            String Name = Console.ReadLine();

            SqlParameter PublisherIdParam = new SqlParameter()
            {
                Value = PublisherId,
                ParameterName = "PublisherId"
            };

            SqlParameter PublisherNameParam = new SqlParameter()
            {
                Value = Name,
                ParameterName = "Name"
            };

            string insertPublisherCommand = "Insert into Publisher (PublisherId,Name) output INSERTED.PublisherId VALUES (@PublisherId,@Name);";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = insertPublisherCommand;
            command.Parameters.Add(PublisherIdParam);
            command.Parameters.Add(PublisherNameParam);

            try
            {
                int NewId = (int)command.ExecuteScalar();
                Console.WriteLine($"Publisher has been added with success. Publisher id {NewId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            conn.Close();
        }

        private static void PrintPublisherNameWhereIdIs1(SqlConnection conn)
        {


            string selectPublisher = "Select Name from Publisher where PublisherId=1";
            SqlCommand command = new SqlCommand(selectPublisher, conn);

            string Name = (string)command.ExecuteScalar();
            Console.WriteLine(Name);
            Console.ReadKey();
            conn.Close();
        }
    }
}
