using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student("Mihai", "Daniel", "Irimia", 191);
            //Student s2 = (Student)s1.Clone();
            //s2.Print();
            //s1.CompareTo(s2);
            //Console.Write(s1.CompareTo(s2));

            Person p1 = new Person();
            p1.Name = "Mihai";

            p1.Print(p1.ToString());


            Console.ReadKey();
        }

       
    }
}
