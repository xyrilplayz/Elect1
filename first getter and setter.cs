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
}