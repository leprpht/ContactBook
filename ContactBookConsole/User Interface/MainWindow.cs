using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ContactBookLib;


namespace ContactBookConsole.User_Interface
{
    public static class MainWindow
    {
        public static void Show(ContactBook contactBook)
        {
            Screen.DisplayMainMessageLine("Welcome to the Contact Book!");
            Screen.DisplayLine("1. Add a contact");
            Screen.DisplayLine("2. Update a contact");
            Screen.DisplayLine("3. Get contact info");
            Screen.DisplayLine("4. List all contacts");
            Screen.DisplayLine("5. Exit");
            Screen.DisplayLine("\nEnter your choice: ");
        }
        public static ConsoleKeyInfo ReadInput()
        {
            return Console.ReadKey(true);
        }
        public static void Options(ConsoleKeyInfo key, ContactBook contactBook)
        {
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    AddContact(contactBook);
                    break;
                case ConsoleKey.D2:
                    UpdateContact(contactBook);
                    break;
                case ConsoleKey.D3:
                    GetContactInfo(contactBook);
                    break;
                case ConsoleKey.D4:
                    ListAllContacts(contactBook);
                    break;
                case ConsoleKey.D5:
                    Exit();
                    break;
                default:
                    Screen.DisplayLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public static void AddContact(ContactBook contactBook)
        {
            Screen.DisplayLine("Enter contact name, email, phone, and address separated by commas:");
            string[] contactInfo = Console.ReadLine().Split(',');
            if (contactInfo.Length != 4)
            {
                Screen.DisplayLine("Invalid input. Please try again.");
                Console.ReadKey(true);
                Console.Clear();
            }
            else
            {
                Contact contact = new Contact(contactInfo[0].Trim(), contactInfo[1].Trim(), contactInfo[2].Trim(), contactInfo[3].Trim());
                contactBook.AddContact(contact);
                Screen.DisplayLine("Contact added successfully.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        public static void UpdateContact(ContactBook contactBook)
        {
            Screen.DisplayLine("Enter contact name, email, phone, and address separated by commas:");
            string[] contactInfo = Console.ReadLine().Split(',');
            if (contactInfo.Length != 4)
            {
                Screen.DisplayLine("Invalid input. Please try again.");
                Console.ReadKey(true);
                Console.Clear();
            }
            else
            {
                contactBook.UpdateContact(contactInfo[0].Trim(), contactInfo[1].Trim(), contactInfo[2].Trim(), contactInfo[3].Trim());
                Screen.DisplayLine("Contact updated successfully.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        public static void GetContactInfo(ContactBook contactBook)
        {
            Screen.DisplayLine("Enter contact name:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Screen.DisplayLine("Invalid input. Please try again.");
                Console.ReadKey(true);
                Console.Clear();
            }
            else
            {
                Screen.DisplayLine(contactBook.GetContactInfo(name));
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        public static void ListAllContacts(ContactBook contactBook)
        {
            Screen.DisplayByLine(contactBook.ListAllContacts());
            Console.ReadKey(true);
            Console.Clear();
        }
        public static void Exit()
        {
            Screen.DisplayLine("Goodbye!");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        public static void MainMethod()
        {
            ContactBook contactBook = new ContactBook();
            while (true)
            {
                Show(contactBook);
                Options(ReadInput(), contactBook);
            }
        }
        public static void MainMethodTest()
        {
            ContactBook contactBook = new ContactBook();
            contactBook.AddContact(new Contact("John Doe", "john.doe@email.com", "555 - 1234", "123 Elm St Springfield IL"));
            contactBook.AddContact(new Contact("Jane Smith", "jane.smith@email.com", "555-5678", "456 Oak St Rivertown TX"));
            contactBook.AddContact(new Contact("Tom Brown", "tom.brown@email.com", "555-8765", "789 Pine St Lakeview CA"));
            contactBook.AddContact(new Contact("Sara Lee", "sara.lee@email.com", "555-4321", "101 Maple St Greenfield WI"));
            contactBook.AddContact(new Contact("Mike Johnson", "mike.johnson@email.com", "555-2345", "202 Birch St Clearwater FL"));
            contactBook.AddContact(new Contact("Anna White", "anna.white@email.com", "555-6789", "303 Cedar St Pleasantville NY"));
            contactBook.AddContact(new Contact("Chris Davis", "chris.davis@email.com", "555-9876", "404 Cherry St Hilltop OH"));
            contactBook.AddContact(new Contact("Olivia Wilson", "olivia.wilson@email.com", "555-5432", "505 Walnut St Brooksville KY"));
            contactBook.AddContact(new Contact("David Harris", "david.harris@email.com", "555-1122", "606 Pineapple St Fairview CO"));
            contactBook.AddContact(new Contact("Emily Clark", "emily.clark@email.com", "555-3456", "707 Magnolia St Midtown NC"));
            while (true)
            {
                Show(contactBook);
                Options(ReadInput(), contactBook);
            }
        }
    }
}
