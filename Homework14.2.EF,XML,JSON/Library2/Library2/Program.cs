using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Library2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library2 library = new Library2();

            Database.InsertBook("rata", new Publisher(2), 1111, 11);

            Database.DeleteBook(39);

            List<Book> books = Database.ListBooks();

            Database.PrintBooks(books);

            XMLSerializable.SaveAsXML("XMLFile.xml", books);

            SerializationJson.SaveAsJson("XMLFile.json", books);


            Console.ReadKey();
            
        }
    }
}
