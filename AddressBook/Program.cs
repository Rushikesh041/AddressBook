using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEL-COME");
            ContactDetails contact = new ContactDetails()
            {
                FirstName = "Rushikesh",
                LastName = "Jadhav",
                MobileNumber = 7666153455,
                Email = "jadhavrushi041@gmail.com",
                Address = "Aanand Nagar",
                City = "Udgir",
                State = "Maharashtra",
                zip = 413517
            };
            ContactDetails contact1 = new ContactDetails()
            {
                FirstName = "Vaibhav",
                LastName = "Goradwar",
                MobileNumber = 7218134907,
                Email = "vaibhav123@gmail.com",
                Address = "Vaman Nagar",
                City = "Nanded",
                State = "Maharashtra",
                zip = 411606
            };



            ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
            contactDetailsRepository.AddContactDetails(contact);
            contactDetailsRepository.AddContactDetails(contact1);
            contactDetailsRepository.DisplayContact();
        }
    }
}