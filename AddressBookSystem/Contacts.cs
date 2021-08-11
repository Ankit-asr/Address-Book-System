using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }

        public void CheckContactAvailable(List<Contacts> listContacts)
        {
            bool checkContacts = false;
            Console.WriteLine("Enter first name");
            String firstName;
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
                    Console.WriteLine("Record Updated successfully..");
                    checkContacts = true;
                }
            }
            if (checkContacts == false)
                Console.WriteLine("Record not present");
        }
        public void ShowAllRecords(List<Contacts> listContacts)
        {
            int count = 1;
            if ((listContacts.Capacity) > 0)
            {
                foreach (Contacts contacts1 in listContacts)
                {
                    Console.WriteLine("Contact Record :" + count);
                    Console.WriteLine("First name :" + contacts1.FirstName);
                    Console.WriteLine("Last name :" + contacts1.LastName);
                    Console.WriteLine("Address :" + contacts1.Address);
                    Console.WriteLine("City :" + contacts1.City);
                    Console.WriteLine("State :" + contacts1.State);
                    Console.WriteLine("Zip :" + contacts1.Zip);
                    Console.WriteLine("Phone Number :" + PhoneNumber);
                    Console.WriteLine("Email :" + contacts1.Email);
                    count++;
                }
            }
            else
                Console.WriteLine("Contacts record is empty");
        }

    }
}
