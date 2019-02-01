using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Library2
{
    class SerializationJson
    {
        public static void SaveAsJson(string FileName,List<Book> books)
        {
  
            using (var writer = new System.IO.StreamWriter(FileName))
            {

                using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
                {
                    JsonSerializer ser = new JsonSerializer();
                    ser.Serialize(jsonWriter, books);
                    jsonWriter.Flush();
                }
            }

        }

        public static List<Book> LoadAsJson(string FileName)
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
