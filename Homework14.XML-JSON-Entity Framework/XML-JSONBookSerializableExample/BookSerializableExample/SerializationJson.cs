using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BookSerializableExample
{
    class SerializationJson
    {
        public static void Save1(string FileName)
        {
            List<Book> books1 = new List<Book>();
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
            books1.Add(book2);
            books1.Add(book1);
            books1.Add(book2);


            using (var writer = new System.IO.StreamWriter(FileName))
            {

                using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
                {
                    JsonSerializer ser = new JsonSerializer();
                    ser.Serialize(jsonWriter, books1);
                    jsonWriter.Flush();
                }
            }

        }

        public static List<Book> Load1(string FileName)
        {
            using (StreamReader reader = new StreamReader(FileName))
            using (JsonTextReader jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer ser = new JsonSerializer();
                return ser.Deserialize(jsonReader) as List<Book>;
            }
        }
    }
}
