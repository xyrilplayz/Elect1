        static void StoreStudent()
        {
            Student student = new Student();
            Console.Write("Enter the Student number: ");
            student.StudentID = Console.ReadLine();
            Console.Write("Enter first name: ");
            student.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            student.LastName = Console.ReadLine();
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