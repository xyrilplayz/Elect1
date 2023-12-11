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
                    do
                    {
                        Console.Write("Enter new Phone Number: ");
                        string newPhoneNumber = Console.ReadLine();

                        if (IsValidPhoneNumber(newPhoneNumber))
                        {
                            student.PhoneNumber = newPhoneNumber;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid phone number (containing only digits).");
                        }
                    } while (true);
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