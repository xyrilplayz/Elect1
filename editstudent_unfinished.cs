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