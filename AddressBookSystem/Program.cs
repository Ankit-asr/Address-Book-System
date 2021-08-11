using System;
using System.Collections.Generic;


namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, address, city, state, email;
            int zip, userChoice;
            long phoneNumber;
            List<Contacts> listContacts = new List<Contacts>();

            while (true)
            {
                Console.WriteLine("Press 1 : Add new contacts to Address Book");
                Console.WriteLine("Press 0 : to Stop Execution");
                Console.WriteLine("Enter your choice");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 0)
                    break;
                switch (userChoice)
                {
                    case 1:
                        GetUserData();
                        Contacts contacts = new Contacts()
                        {
                            FirstName = firstName,
                            Lastname = lastName,
                            Address = address,
                            City = city,
                            State = state,
                            Zip = zip,
                            PhoneNumber = phoneNumber,
                            Email = email
                        };
                        listContacts.Add(contacts);
                        break;


                }
            }
            foreach (Contacts contacts1 in listContacts)
            {
                Console.WriteLine("Contact Created With First name :" + contacts1.FirstName);
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
