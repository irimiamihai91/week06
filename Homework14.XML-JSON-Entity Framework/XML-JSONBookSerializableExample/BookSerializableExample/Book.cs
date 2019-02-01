using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace BookSerializableExample
{
    public class Book
    {
 
        public int BookId { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Title { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }


    }
}
