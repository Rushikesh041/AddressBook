using AddressBook.Model;
using AddressBook.Repository;
using System;
using System.Net;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEL-COME");
            ContactDetails contact = null;
            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();

            Console.WriteLine("Enter y to Enter Contact Details : ");
            var input = Console.ReadLine();

            while (input == "y")
            {
                Console.WriteLine("Enter First Name : ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name :");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Mobile Number :");
                long mobileNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter Email ID : ");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City : ");
                string city = Console.ReadLine();

                Console.WriteLine("Enter State : ");
                string state = Console.ReadLine();

                Console.WriteLine("Enter Zip Code : ");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter y to Enter Contact Details or otherwise enter any key : ");
                input = Console.ReadLine();

                contact = new ContactDetails()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MobileNumber = mobileNumber,
                    Email = email,
                    Address = address,
                    State = state,
                    City = city,
                    Zip = zip

                };
                contactDetailsRepository.AddContactDetails(contact);
            }
            Console.Write("Enter 'm' to edit contact using mobile number : ");
            var edit = Console.ReadLine();
            while (edit == "m")
            {
                Console.Write("Enter Mobile Number : ");
                contactDetailsRepository.EditContactDetails(Convert.ToInt64(Console.ReadLine()));

                Console.Write("Enter 'm' to edit contact using mobile number otherwise Enter any key : ");
                edit = Console.ReadLine();
            }
            Console.Write("Enter 'd' to delete contact using Mobile Number : ");
            var delete = Console.ReadLine();
            while (delete == "d")
            {
                Console.Write("Enter Mobile Number Which you want to Delete Contact : ");
                contactDetailsRepository.DeleteContact(Convert.ToInt64(Console.ReadLine()));
                Console.Write("Enter 'd' to Delete contact using mobile number otherwise Enter any key : ");
                delete = Console.ReadLine();
            }
            contactDetailsRepository.DisplayContact();

        }
    }
}