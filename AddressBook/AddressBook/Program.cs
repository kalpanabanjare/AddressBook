using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Contacts
    {
        public string FirstName = "";
        public string LastName = "";
        public string Address = "";
        public string City = "";
        public string State = "";
        public int ZipCode = 0;
        public int PhoneNumber = 0;
        public string Email = "";        
        public Contacts(string FirstName, string LastName, string Address, string City, string State, int ZipCode, int PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
        public string ToString()
        {
            return "Details of " + FirstName + " " + LastName + "are: " + "Address- " + Address + " City- " + City + "\n"
                                 + "                                  " + "State- " + State + " ZipCode- " + ZipCode + "\n"
                                 + "                                  " + "PhoneNumber- " + PhoneNumber + " Email- " + Email;
        }
    }
    class AddressBook
    {
        private int numOfPerson = 0;
        private ArrayList contactDetailIsList;
        private Dictionary<string, Contacts> contactDetailIsMap;
        public AddressBook()
        {
            contactDetailIsList = new ArrayList();
            contactDetailIsMap = new Dictionary<string, Contacts>();
        }
        public void AddDeatails(string FirstName, string LastName, string Address, string City, string State, int ZipCode, int PhoneNumber, string Email)
        {
            Contacts contactsDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            contactDetailIsList.Add(contactsDetails);
            contactDetailIsMap.Add(FirstName, contactsDetails);
        }
        public void EditDetails(string FirstName, string LastName, string address, string city, string state, int zip, int phoneNumber1, int phoneNumber2, String email)
        {
            Contacts contactDetails = new Contacts(FirstName, LastName, address, city, state, zip, phoneNumber1, email);
            int index = Convert.ToInt32(Console.ReadLine());
            contactDetailIsList[index] = contactDetails;
            contactDetailIsMap[FirstName] = contactDetails;
        }       
        public void ComputeDetails()
        {
            foreach (Contacts contact in contactDetailIsList)
            {
                Console.WriteLine(contact.ToString());
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook Details = new AddressBook();            
            Console.WriteLine("Enter the number of person: ");
            int noOfPersons = Convert.ToInt32(Console.ReadLine());
            for (int numOfPerson = 1; numOfPerson <= noOfPersons; numOfPerson++)
            {
                Console.Write("Enter First Name: ");
                string FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                string LastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                string Address = Console.ReadLine();
                Console.Write("Enter City: ");
                string City = Console.ReadLine();
                Console.Write("Enter State: ");
                string State = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Email Address: ");
                string Email = Console.ReadLine();
                Console.WriteLine("\n");
                Details.AddDeatails(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            }
            Details.ComputeDetails();
            
            Console.WriteLine("Number of person to edit: ");
            int noOfEdits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 0 to edit: ");
            int Option = Convert.ToInt32(Console.ReadLine());
            if (Option == 0)
            {
                for (int numOfPerson = 1; numOfPerson <= noOfEdits; numOfPerson++)
                {
                    Console.Write("Enter First Name: ");
                    string FirstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string LastName = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string Address = Console.ReadLine();
                    Console.Write("Enter City: ");
                    string City = Console.ReadLine();
                    Console.Write("Enter State: ");
                    string State = Console.ReadLine();
                    Console.Write("Enter Zip Code: ");
                    int ZipCode = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Phone Number: ");
                    int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Email Address: ");
                    string Email = Console.ReadLine();
                    Details.AddDeatails(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
                }
                Details.ComputeDetails();          
            }
        }
    }
}