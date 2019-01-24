using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideStudent
{
    class Person
    {
        public string Name { get; set; }
        public int ? Age{get;set;}

        public override string ToString()
        {
            if (Age == null)
            {
                return $"{this.Name}, Age is not specified";
            }
            else return $"{this.Name}, {this.Age}";
        }

        public void Print(string arg)
        {
            Console.WriteLine(arg);
        }
    }
}
