using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library2
{   [Serializable]
    class XMLSerializable {

        
        public static void SaveAsXML(string FileName,List<Book> books)
            {
           

                using (var writer = new System.IO.StreamWriter(FileName))
                {
                    var serializer = new XmlSerializer(books.GetType());
                    serializer.Serialize(writer, books);
                    writer.Flush();
                }

            }

       

        public static List<Book> LoadAsXML(string FileName)
            {
                using (var stream = System.IO.File.OpenRead(FileName))
                {
                    var serializer = new XmlSerializer(typeof(List<Book>));
                    return serializer.Deserialize(stream) as List<Book>;
                }
            }

            public static void PrintXML(string fileName)
            {
                var XMLList = XMLSerializable.LoadAsXML(fileName);
                foreach (var book in XMLList)
                {
                    Console.WriteLine($"{book.BookId}, {book.Title}");
                }
            }
        }
    }

