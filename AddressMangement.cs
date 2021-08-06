using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_book
{
    class AddressManagement
    {
        public static void ReadInput()
        {
            //// creating the object for the class address book 
            AddressBookMain addressBookMain = new AddressBookMain();
            bool CONTINUE = true;

            //// the loop continues until the user exit.
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Add contacts");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Edit Details");
                Console.WriteLine("4.Delete Contact");
                Console.WriteLine("0.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddDetails(addressBookMain);
                        break;
                    case 2:
                        addressBookMain.DisplayContact();
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name of person");
                        string name = Console.ReadLine();
                        addressBookMain.EditContact(name);
                        break;
                    case 4:
                        string firstName = Console.ReadLine();
                        addressBookMain.DeleteContact(firstName);
                        break;
                    case 0:
                        CONTINUE = false;
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// This method is used to add multipl contacts.
        /// </summary>
        /// <param name="addressBookMain"></param>
        public static void AddDetails(AddressBookMain addressBookMain)
        {
            Console.WriteLine("Enter first Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            long zipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            addressBookMain.AddContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }
    }
}