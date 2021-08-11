using System;
using System.Collections.Generic;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string firstName, lastName, address, city, state, email;
            int zip, userChoice;
            long phoneNumber;
            //constants
            const int EXIT = 0, ADD_NEW_CONTACTS = 1, EDIT_CONTACTS = 2, DELETE_CONTACTS = 3, ALL_CONTACTS = 5, ADD_MULTIPLE_RECORDS = 4;
            List<Contacts> listContacts = new List<Contacts>();
            Dictionary<string, List<Contacts>> contactsUniqueList = new Dictionary<string, List<Contacts>>();
            while (true)
            {
                Console.WriteLine("Press 1 : Add new contacts to Address Book");
                Console.WriteLine("Press 2 : Edit existing contact");
                Console.WriteLine("Press 3 : Delete contact");
                Console.WriteLine("Press 4 : Add multiple records to Address Book");
                Console.WriteLine("Press 5 : Show all contacts");
                Console.WriteLine("Press 0 : to Stop Execution");
                Console.WriteLine("Enter your choice");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == EXIT)
                    break;
                switch (userChoice)
                {
                    case ADD_NEW_CONTACTS:
                        GetUserData();
                        Contacts contacts = new Contacts()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Address = address,
                            City = city,
                            State = state,
                            Zip = zip,
                            PhoneNumber = phoneNumber,
                            Email = email
                        };
                        listContacts.Add(contacts);
                        contactsUniqueList.Add(contacts.FirstName, listContacts);
                        break;
                    case EDIT_CONTACTS:
                        Contacts contact = new Contacts();
                        contact.CheckContactAvaible(contactsUniqueList);
                        break;
                    case ALL_CONTACTS:
                        Contacts contactAllRecord = new Contacts();
                        contactAllRecord.ShowAllRecords(contactsUniqueList);
                        break;
                    case DELETE_CONTACTS:
                        Contacts contectDelete = new Contacts();
                        contectDelete.DeleteContacts(contactsUniqueList);
                        break;
                    case ADD_MULTIPLE_RECORDS:
                        Contacts contactAddMulRecords = new Contacts();
                        contactAddMulRecords.AddMultiplePerson(contactsUniqueList);
                        break;
                    default:
                        Console.WriteLine("Enter a right choice");
                        break;
                }
            }
            void GetUserData()
            {
                Console.WriteLine("Enter First Name");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter address");
                address = Console.ReadLine();
                Console.WriteLine("Enter city");
                city = Console.ReadLine();
                Console.WriteLine("Enter state");
                state = Console.ReadLine();
                Console.WriteLine("Enter zip code");
                zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
            }
        }
    }
}