using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Dictionary
{
    class ContactManager
    {
        private Dictionary<string, string> contacts = new Dictionary<string, string>();

        public void AddContact(string name, string phoneNumber)
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact with name '{name}' already exists. Please use a unique name.");
            }
            else
            {
                contacts[name] = phoneNumber;
                Console.WriteLine("Contact added successfully!");
            }
        }

        public void DeleteContact(string name)
        {
            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
                Console.WriteLine($"Contact '{name}' has been deleted.");
            }
            else
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }

        public void SearchContact(string name)
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact: {name}");
                Console.WriteLine($"Phone Number: {contacts[name]}");
            }
            else
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                Console.WriteLine("Contacts:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }
            }
        }
    }
}
