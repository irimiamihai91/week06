using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DeletePublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.; Initial Catalog = BookPublisher; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //PrintPublisherById(conn);

            //DeletePublisherUsingStructureWithParameter(conn);

            //DeleteBooksByPublisherId(conn);

            Console.ReadKey();

        }

        private static void DeleteBooksByPublisherId(SqlConnection conn)
        {
            Console.WriteLine("Please insert Publisher Id and we will delete the books");
            int PublisherId = Convert.ToInt32(Console.ReadLine());

            SqlCommand command = new SqlCommand("DeleteBookByPublisherId", conn);

            //Create Procedure DeleteBookByPublisherId(@PublisherId int)
            //AS
            //Delete from Book Where PublisherId = @PublisherId

            command.CommandType = CommandType.StoredProcedure;

            SqlParameter PublisherIdParam;

            PublisherIdParam = command.Parameters.Add("@PublisherId", SqlDbType.Int);
            PublisherIdParam.Value = PublisherId;

            command.ExecuteNonQuery();

            Console.WriteLine($"Books Have been deleted ");

            conn.Close();
        }

        private static void DeletePublisherUsingStructureWithParameter(SqlConnection conn)
        {
            Console.WriteLine("Please insert Publisher Id that should be deleted : ");
            int PublisherId = Convert.ToInt32(Console.ReadLine());

            SqlCommand command = new SqlCommand("DeletePublisher1", conn);

            //Create Procedure DeletePublisher1(@PublisherId int)
            //AS
            //Delete from Publisher Where PublisherId = @PublisherId

            command.CommandType = CommandType.StoredProcedure;

            SqlParameter PublisherIdParam;

            PublisherIdParam = command.Parameters.Add("@PublisherId", SqlDbType.Int);
            PublisherIdParam.Value = PublisherId;

            command.ExecuteNonQuery();

            Console.WriteLine($"Publisher {PublisherId} has been deleted ");

            conn.Close();
        }

        private static void PrintPublisherById(SqlConnection conn)
        {
            Console.WriteLine("Please insert Publisher Id");
            int publisherId = Convert.ToInt32(Console.ReadLine());

            SqlParameter publisherIdParam = new SqlParameter() { Value = publisherId, ParameterName = "publisherId" };


            string selectPublisher = "select * from Publisher where PublisherId = @publisherId";
            SqlCommand command = new SqlCommand(selectPublisher, conn);
            command.Parameters.Add(publisherIdParam);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"PublisherId: {reader[0]}, Name : {reader["Name"]}");
            }

            reader.Close();
            conn.Close();
        }
    }
}
