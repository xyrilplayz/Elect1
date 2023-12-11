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