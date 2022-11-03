﻿using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        public Dictionary<long, ContactDetails> contactDetailDictionary = new Dictionary<long, ContactDetails>();

        public void AddContactDetails(ContactDetails contactDetails)
        {
            contactDetailDictionary.Add(Convert.ToInt64(contactDetails.MobileNumber), contactDetails);
        }
        public void EditContactDetails(long mobilenumber)
        {
            var obj = contactDetailDictionary[mobilenumber];
            Console.WriteLine("Select Which Detail you want to Edit : \n1. First Name \n2. Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. District \n8. State \n9. Zip Code");
            int editDetail = Convert.ToInt32(Console.ReadLine());
            switch (editDetail)
            {
                case 1:
                    Console.Write("Enter First Name to Update : ");
                    string firstName = Console.ReadLine();
                    obj.FirstName = firstName;
                    break;
                case 2:
                    Console.Write("Enter Last Name to Update : ");
                    string lastName = Console.ReadLine();
                    obj.LastName = lastName;
                    break;
                case 3:
                    Console.Write("Enter Mobile Number to Update : ");
                    long mobNumber = Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobNumber;
                    break;
                case 4:
                    Console.Write("Enter Email ID to Update : ");
                    string email = Console.ReadLine();
                    obj.Email = email;
                    break;
                case 5:
                    Console.Write("Enter Address to Update : ");
                    string address = Console.ReadLine();
                    obj.Address = address;
                    break;
                case 6:
                    Console.Write("Enter City to Update : ");
                    string city = Console.ReadLine();
                    obj.City = city;
                    break;
                case 7:
                    Console.Write("Enter State to Update : ");
                    string state = Console.ReadLine();
                    obj.State = state;
                    break;
                case 8:
                    Console.Write("Enter Zip to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    obj.Zip = zipcode;
                    break;
            }

        }
        public void DisplayContact()
        {
            foreach (var item in contactDetailDictionary)
            {
                Console.WriteLine("First Name is : " + item.Value.FirstName);
                Console.WriteLine("Last Name is : " + item.Value.LastName);
                Console.WriteLine("Mobile Number is : " + item.Value.MobileNumber);
                Console.WriteLine("Email ID is : " + item.Value.Email);
                Console.WriteLine("Address is : " + item.Value.Address);
                Console.WriteLine("City is : " + item.Value.City);
                Console.WriteLine("State is : " + item.Value.State);
                Console.WriteLine("Zip Code is : " + item.Value.Zip);
                Console.WriteLine();
            }
        }
    }
}
