using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideStudent
{
    class Student : ICloneable, IComparable<Student>
    {

        public Student(string firstName, string midleName, string lastName, int SSN)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MidleName = midleName;
            this.SSN = SSN;

        }
        public string FirstName { get; set; }

        public string MidleName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }


        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null)
            {
                return false;
            }

            return this.FirstName == student.FirstName &&
                   this.MidleName == student.MidleName &&
                   this.LastName == student.LastName &&
                   this.SSN == student.SSN;

        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                   this.MidleName.GetHashCode() ^
                   this.LastName.GetHashCode() ^
                   this.SSN.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }


        public override string ToString()
        {
            return $"Student: {FirstName}, {MidleName}, {LastName},{SSN}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Print()
        {
            Console.WriteLine($"First Name : {FirstName},{MidleName},{LastName},{SSN}");
        }

        public int CompareTo(Student s1)
        {
            if (this.SSN > s1.SSN) return 1;
            if (this.SSN < s1.SSN) return -1;
            return 0;

        }
    }

    public enum Specialties
    {
        Specialty1, Specialty2, Specialty3,
    }

    public enum Universities
    {
        University1, University2, University3,
    }

    public enum Faculties
    {
        Faculty1, Faculty2, Faculty3,
    }
