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