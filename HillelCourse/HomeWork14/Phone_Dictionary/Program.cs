namespace Phone_Dictionary
{
    class Program
    {
        static void Main()
        {
            ContactManager contactManager = new ContactManager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Delete a contact by name");
                Console.WriteLine("3. Search for a contact by name");
                Console.WriteLine("4. View contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the name of the new contact: ");
                            string name = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(name))
                            {
                                Console.WriteLine("Name cannot be empty.");
                                break;
                            }

                            Console.Write("Enter the phone number of the new contact: ");
                            string phoneNumber = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(phoneNumber))
                            {
                                Console.WriteLine("Phone number cannot be empty.");
                                break;
                            }

                            contactManager.AddContact(name, phoneNumber);
                            break;

                        case 2:
                            Console.Write("Enter the name of the contact to delete: ");
                            string nameToDelete = Console.ReadLine();
                            contactManager.DeleteContact(nameToDelete);
                            break;

                        case 3:
                            Console.Write("Enter the name of the contact to search: ");
                            string nameToSearch = Console.ReadLine();
                            contactManager.SearchContact(nameToSearch);
                            break;

                        case 4:
                            contactManager.DisplayContacts();
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a numeric option.");
                }
            }
        }
    }
}