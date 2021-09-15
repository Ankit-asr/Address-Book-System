using System;
using System.Collections.Generic;
using System.Linq;


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
            const int EXIT = 0, ADD_NEW_CONTACTS = 1, EDIT_CONTACTS = 2, DELETE_CONTACTS = 3, ALL_CONTACTS = 5, ADD_MULTIPLE_RECORDS = 4, DISPLAY_PERSON = 6, COUNT_PERSONS = 7, SORT_PERSON_NAME = 8, WRITE_TO_FILE = 9, READ_FILE_TEXT = 10, SORT_USER_CHOICE = 11;
            const string TEXT_FILE = @"C:\Users\ASR\Desktop\ADDRESS_BOOK_SYSTEM\AddressBookSystem\PersonContacts.txt";
            List<Contacts> listContacts = new List<Contacts>();
            Dictionary<string, List<Contacts>> contactsUniqueList = new Dictionary<string, List<Contacts>>();
            while (true)
            {
                Console.WriteLine("Press 1 : Add new contacts to Address Book");
                Console.WriteLine("Press 2 : Edit existing contact");
                Console.WriteLine("Press 3 : Delete contact");
                Console.WriteLine("Press 4 : Show all contacts");
                Console.WriteLine("Press 5 : Add multiple records to Address Book");
                Console.WriteLine("Press 6 : Display Person in city or state");
                Console.WriteLine("Press 7 : Get number of contact persons count by state or city");
                Console.WriteLine("Press 8 : Sort entries by Person's name");
                Console.WriteLine("Press 9 : Write data to Text File");
                Console.WriteLine("Press 10 : Read data from Text File");
                Console.WriteLine("Press 11 : Sort data according to user choice");
                Console.WriteLine("Press 0 : to Stop Execution");
                Console.WriteLine("Enter your choice");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == EXIT)
                    break;
                switch (userChoice)
                {
                    case ADD_NEW_CONTACTS:
                        GetUserData();
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
                    case DISPLAY_PERSON:
                        Contacts contactSearchPerson = new Contacts();
                        contactSearchPerson.DisplayPersonName(contactsUniqueList);
                        break;
                    case COUNT_PERSONS:
                        Contacts contactCountPerson = new Contacts();
                        contactCountPerson.DisplayCountOfPersons(contactsUniqueList);
                        break;
                    case SORT_PERSON_NAME:
                        Contacts contactSortPersonName = new Contacts();
                        contactSortPersonName.SortRecordByPersonName(contactsUniqueList);
                        break;
                    case WRITE_TO_FILE:
                        Contacts contactWriteFile = new Contacts();
                        contactWriteFile.ContactsWriteInTextFile(contactsUniqueList, TEXT_FILE);
                        break;
                    case READ_FILE_TEXT:
                        Contacts contactReadFile = new Contacts();
                        contactReadFile.ReadTextFileData(TEXT_FILE);
                        break;
                    case SORT_USER_CHOICE:
                        Contacts contactUserChoice = new Contacts();
                        contactUserChoice.SortData(contactsUniqueList);
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
                var personNameData = contactsUniqueList.Where(x => x.Key.Contains(firstName));
                if (personNameData.ToList().Count != 0)
                {
                    Console.WriteLine("............This name is already present try with other name...........");
                }
                else
                {
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
                }
            }
        }
    }
}