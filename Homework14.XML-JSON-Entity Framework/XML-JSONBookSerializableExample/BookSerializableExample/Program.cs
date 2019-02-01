using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace BookSerializableExample
{
    class Program
    {

        static void Main(string[] args)
        {
            //SerializationXML.Save("Text.txt");
            //List<Book> books = SerializationXML.Load("Text.txt");

            //SerializationJson.Save1("Text2.txt");
            //List<Book> books1 = SerializationXML.Load("Text.txt");

            PrintDataFromXMLFile("Text.txt");


            Console.ReadKey();


        }

        public static void PrintDataFromXMLFile(string fileName)
        {
            var listFromXMLFile = SerializationXML.Load(fileName);
            foreach (var book in listFromXMLFile)
            {
                Console.WriteLine($"{book.BookId}, {book.Title}");
            }
        }
    }
}
