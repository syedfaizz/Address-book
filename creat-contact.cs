using System;

namespace AddressBook
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// display contact information.
        /// </summary>
        public void displayContact()
        {
            Console.WriteLine("FirstName: " + this.FirstName + " LastName: " + this.LastName + " Address: " + this.Address +
                                " City: " + this.City + " State: " + this.State + " Zip: " + this.Zip +
                                  " PhoneNumber: " + this.PhoneNumber + " Email: " + this.Email);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email \n");
            Program program = new Program()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            program.displayContact();
        }
    }
}