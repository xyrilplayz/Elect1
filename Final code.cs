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

            do
            {
                Console.WriteLine("[1] Store to ASEAN phonebook");
                Console.WriteLine("[2] Edit entry in ASEAN phonebook");
                Console.WriteLine("[3] Search ASEAN phonebook by country");
                Console.WriteLine("[4] Exit");
                Console.Write("Enter an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        StoreMultipleEntries();
                        break;
                    case 2:
                        EditStudent();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            } while (option != 4);
        }

        static void StoreMultipleEntries()
        {
            string continueStoring;
            do
            {
                StoreStudent();

                Console.Write("Do you want to add another entry? (Y/N): ");
                continueStoring = Console.ReadLine().ToUpper();

                if (continueStoring != "Y" && continueStoring != "N")
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                }

            } while (continueStoring == "Y");
        }

        static void StoreStudent()
        {
            Student student = new Student();

            do
            {
                Console.Write("Enter the Student number: ");
                string studentNumber = Console.ReadLine();

                if (IsValidStudentNumber(studentNumber))
                {
                    student.StudentID = studentNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid student number (containing only digits).");
                }
            } while (true);

            do
            {
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();

                if (IsValidName(firstName))
                {
                    student.FirstName = firstName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid first name (containing only alphabetic characters).");
                }
            } while (true);

            do
            {
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                if (IsValidName(lastName))
                {
                    student.LastName = lastName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid last name (containing only alphabetic characters).");
                }
            } while (true);

            Console.Write("Enter occupation: ");
            student.Occupation = Console.ReadLine();

            do
            {
                Console.Write("Enter gender (M for male, F for female): ");
                char gender;
                if (char.TryParse(Console.ReadLine(), out gender))
                {
                    gender = char.ToUpper(gender);
                    if (gender == 'M' || gender == 'F')
                    {
                        student.Gender = gender;
                        break;
                    }
                }

                Console.WriteLine("Invalid input. Please enter either 'M' for male or 'F' for female.");
            } while (true);

            Console.WriteLine("Select the country code:");
            Console.WriteLine("[1] Malaysia");
            Console.WriteLine("[2] Indonesia");
            Console.WriteLine("[3] Philippines");
            Console.WriteLine("[4] Singapore");
            Console.WriteLine("[5] Thailand");

            int countryCodeChoice;

            do
            {
                Console.Write("Enter your choice (1-5): ");
                if (!int.TryParse(Console.ReadLine(), out countryCodeChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (countryCodeChoice < 1 || countryCodeChoice > 5)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;
                }

                student.CountryCode = GetUserChoiceCountryCode(countryCodeChoice);
                Console.WriteLine("Your country code is: " + student.CountryCode);

                break;

            } while (true);

            Console.Write("Enter area code: ");
            student.AreaCode = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            student.PhoneNumber = Console.ReadLine();

            students.Add(student);
            Console.WriteLine("Student stored successfully.");
        }

        static bool IsValidStudentNumber(string studentNumber)
        {
            return !string.IsNullOrWhiteSpace(studentNumber) && studentNumber.All(c => char.IsDigit(c) || c == 'c');
        }

        static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(c=>char.IsLetter(c)||c == ' ');
        }

        static void EditStudent()
        {
            Console.Write("Enter student number: ");
            string studentID = Console.ReadLine();

            var student = students.FirstOrDefault(s => s.StudentID == studentID);

            if (student == null)
            {
                Console.WriteLine("No student found for the given student number.");
            }
            else
            {
                bool continueEditing = true;

                while (continueEditing)
                {
                    Console.WriteLine($"{student} , {student.Gender}");
                    Console.WriteLine("Choose what you want to edit \n[1] Student number \n[2] Firstname \n[3] Lastname \n[4] Gender (M or F) \n[5] Occupation \n[6] Country Code \n[7] Area Code \n[8] Phone number \n[9] None");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter new student number: ");
                            do
                            {
                                string newStudentNumber = Console.ReadLine();

                                if (IsValidStudentNumber(newStudentNumber))
                                {
                                    student.StudentID = newStudentNumber;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid student number (containing only digits).");
                                }
                            } while (true);
                            break;
                        case "2":
                            Console.Write("Enter new Firstname: ");
                            student.FirstName = Console.ReadLine();
                            break;
                        case "3":
                            Console.Write("Enter new Lastname: ");
                            student.LastName = Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("Enter new gender (M for male, F for female): ");
                            student.Gender = char.ToUpper(Console.ReadKey().KeyChar);
                            Console.WriteLine();
                            break;
                        case "5":
                            Console.Write("Enter new Occupation: ");
                            student.Occupation = Console.ReadLine();
                            break;
                        case "6":
                            Console.Write("Enter new Country Code: ");
                            student.CountryCode = Console.ReadLine();
                            break;
                        case "7":
                            Console.Write("Enter new Area Code: ");
                            student.AreaCode = Console.ReadLine();
                            break;
                        case "8":
                            Console.Write("Enter new Phone Number: ");
                            student.PhoneNumber = Console.ReadLine();
                            break;
                        case "9":
                            continueEditing = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine("Student updated successfully.");
                }
            }
        }

        static void SearchStudent()
        {
            Console.WriteLine("Search ASEAN phonebook by country:");

            List<string> selectedCountryCodes = new List<string>();

            int userChoice;

            do
            {
                Console.Write("\n[1] Malaysia \n[2] Indonesia \n[3] Philippines \n[4] Singapore \n[5] Thailand \n[6] All Countries  \nEnter your choice and 0 to finish: ");

                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (userChoice < 0 || userChoice > 6)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                    continue;
                }

                if (userChoice == 0)
                {
                    break;
                }

                string countryCode = GetUserChoiceCountryCode(userChoice);
                selectedCountryCodes.Add(countryCode);

            } while (true);

            var results = students
                .Where(student =>
                {
                    if (selectedCountryCodes.Contains(AllCountriesCode))
                        return true;
                    else
                        return selectedCountryCodes.Contains(student.CountryCode);
                })
                .OrderBy(student => student.LastName)
                .ThenBy(student => student.FirstName)   
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No students found for the given country code(s).");
            }
            else
            {
                var selectedCountryNames = selectedCountryCodes
                    .Select(code => GetCountryName(code))
                    .Where(name => name != null)
                    .Distinct();

                Console.WriteLine($"Here are the students from {string.Join(" and ", selectedCountryNames)}:");

                foreach (var student in results)
                {
                    string genderDescription = student.Gender == 'M' ? "He" : "She";

                    Console.WriteLine($"{student.LastName}, {student.FirstName} with student number: {student.StudentID} is a {student.Occupation}. {genderDescription} has Phone number that is {student.CountryCode}-{student.AreaCode}-{student.PhoneNumber}.");
                }
            }
        }

        static string GetUserChoiceCountryCode(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "60"; // Malaysia
                case 2:
                    return "62"; // Indonesia
                case 3:
                    return "63"; // Philippines
                case 4:
                    return "65"; // Singapore
                case 5:
                    return "66"; // Thailand
                case 6:
                    return AllCountriesCode;  // Show results for all countries
                default:
                    return null;
            }
        }

        static string GetCountryName(string countryCode)
        {
            switch (countryCode)
            {
                case "60":
                    return "Malaysia";
                case "62":
                    return "Indonesia";
                case "63":
                    return "Philippines";
                case "65":
                    return "Singapore";
                case "66":
                    return "Thailand";
                default:
                    return null;
            }
        }
    }
}
