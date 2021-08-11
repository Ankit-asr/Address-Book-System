using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_System
{
    class Contacts
    {
        //variables
        String firstName;
        bool checkContacts;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
        /// <summary>
        /// Check contact available if it presents than edit in its data
        /// </summary>
        /// <param name="listContacts"></param>
        public void CheckContactAvaible(List<Contacts> listContacts)
        {
            checkContacts = false;
            Console.WriteLine("Enter first name to check record");
            firstName = Console.ReadLine();
            foreach (Contacts contacts in listContacts)
            {
                if (contacts.FirstName.Equals(firstName))
                {
                    Console.WriteLine("Enter First Name");
                    contacts.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name");
                    contacts.LastName = Console.ReadLine();
                    Console.WriteLine("Enter address");
                    contacts.Address = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    contacts.City = Console.ReadLine();
                    Console.WriteLine("Enter state");
                    contacts.State = Console.ReadLine();
                    Console.WriteLine("Enter zip code");
                    contacts.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter phone number");
                    contacts.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter email");
                    contacts.Email = Console.ReadLine();
                    Console.WriteLine("Record Updated successfully...");
                    checkContacts = true;
                }
            }
            if (checkContacts == false)
                Console.WriteLine("Record not present");
        }
        /// <summary>
        /// Delete specific record from contacts
        /// </summary>
        /// <param name="listContacts"></param>
        public void DeleteContacts(List<Contacts> listContacts)
        {
            checkContacts = false;
            Console.WriteLine("Enter first name");
            firstName = Console.ReadLine();
            foreach (Contacts contacts in listContacts)
            {
                if (contacts.FirstName.Equals(firstName))
                {
                    listContacts.Remove(contacts);
                    Console.WriteLine("Record Deleted Successfully...");
                    checkContacts = true;
                    break;
                }
            }
            if (checkContacts == false)
                Console.WriteLine("Record not found");
        }
        /// <summary>
        /// Add multiple person record 
        /// </summary>
        /// <param name="listContacts"></param>
        public void AddMultiplePerson(List<Contacts> listContacts)
        {
            Console.WriteLine("How many person do you want to add");
            int personCount = Convert.ToInt32(Console.ReadLine());
            for (int count = 0; count < personCount; count++)
            {
                Contacts contacts = new Contacts();
                Console.WriteLine("Fill record of person :" + count + 1);
                Console.WriteLine("Enter First Name");
                contacts.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                contacts.LastName = Console.ReadLine();
                Console.WriteLine("Enter address");
                contacts.Address = Console.ReadLine();
                Console.WriteLine("Enter city");
                contacts.City = Console.ReadLine();
                Console.WriteLine("Enter state");
                contacts.State = Console.ReadLine();
                Console.WriteLine("Enter zip code");
                contacts.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                contacts.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter email");
                contacts.Email = Console.ReadLine();
                Console.WriteLine("Person added successully...");
                listContacts.Add(contacts);
            }
        }
        /// <summary>
        /// Show all record of contacts
        /// </summary>
        /// <param name="listContacts"></param>
        public void ShowAllRecords(List<Contacts> listContacts)
        {
            int count = 1;
            if ((listContacts.Capacity) > 0)
            {
                foreach (Contacts contacts1 in listContacts)
                {
                    Console.WriteLine("...Contact Record :" + count + "...");
                    Console.WriteLine("First name :" + contacts1.FirstName);
                    Console.WriteLine("Last name :" + contacts1.LastName);
                    Console.WriteLine("Address :" + contacts1.Address);
                    Console.WriteLine("City :" + contacts1.City);
                    Console.WriteLine("State :" + contacts1.State);
                    Console.WriteLine("Zip :" + contacts1.Zip);
                    Console.WriteLine("Phone Number :" + PhoneNumber);
                    Console.WriteLine("Email :" + contacts1.Email);
                    Console.WriteLine();
                    count++;
                }
            }
            else
                Console.WriteLine("Contacts record is empty");
        }
    }
}