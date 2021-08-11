using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Address Book Program");
            Console.WriteLine("Enter your FirstName");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter your Lastname");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            String address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            String city = Console.ReadLine();
            Console.WriteLine("Enter your State");
            String state = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Email ID");
            String eMail = Console.ReadLine();
            Contacts obj = new Contacts();
            obj.Contacts_Of_People();

        }
    }
}
