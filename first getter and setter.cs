using System;
using System.Collections.Generic;
using System.Linq;

namespace AseanPhonebook
{
    class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public char Gender { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{CountryCode}-{AreaCode} {LastName}, {FirstName}, {PhoneNumber}, {StudentID}";
        }
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        private const string AllCountriesCode = "ALL";

        static void Main(string[] args)
        {
            int option;

            {
                Console.WriteLine("[1] Store to ASEAN phonebook");
                Console.WriteLine("[2] Edit entry in ASEAN phonebook");
                Console.WriteLine("[3] Search ASEAN phonebook by country");
                Console.WriteLine("[4] Exit");
                Console.Write("Enter an option: ");
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}