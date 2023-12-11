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

    Console.WriteLine("Select your country:");
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

    do
    {
        Console.Write("Enter Phone number: ");
        string phoneNumber = Console.ReadLine();

        if (IsValidPhoneNumber(phoneNumber))
        {
            student.PhoneNumber = phoneNumber;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid phone number (containing only digits).");
        }
    } while (true);

    students.Add(student);
    Console.WriteLine("Student stored successfully.");
}

static bool IsValidStudentNumber(string studentNumber)
{
    return !string.IsNullOrWhiteSpace(studentNumber) && studentNumber.All(char.IsDigit);
}

static bool IsValidName(string name)
{
    return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter);
}

static bool IsValidPhoneNumber(string phoneNumber)
{
    return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.All(char.IsDigit);
}