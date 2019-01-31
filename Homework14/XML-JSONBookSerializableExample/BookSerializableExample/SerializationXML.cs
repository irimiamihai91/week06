using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookSerializableExample
{
    public class SerializationXML
    {
        public static void Save(string FileName)
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book()
            {
                BookId = 1,
                Title = "Cartea Cartilor",
                Year = 1995

            };

            Book book2 = new Book()
            {
                BookId = 2,
                Title = "Achile",
                Year = 2000,
                Price = 20,

            };

            books.Add(book1);
            books.Add(book2);


            using (var writer = new System.IO.StreamWriter(FileName))
            {
                var serializer = new XmlSerializer(books.GetType());
                serializer.Serialize(writer, books);
                writer.Flush();
            }

        }

        public static List<Book> Load(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(List<Book>));
                return serializer.Deserialize(stream) as List<Book>;
            }
        }
    }
}
