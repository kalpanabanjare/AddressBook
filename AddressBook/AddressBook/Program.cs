using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AddressBook
{
    class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
<<<<<<< HEAD
        public int Zipcode;
        public int PhoneNumber;
        public string EmailId;
        public Contacts(string FirstName, string LastName, string Address, string City, string State, int Zipcode, int PhoneNumber, string EmailId)
=======
        public int ZipCode;
        public int PhoneNumber;
        public string Email;
        public Contacts(string FirstName, string LastName, string Address, string City, string State, int ZipCode, int PhoneNumber, string Email)
>>>>>>> UC4_DeletePerson
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;
        }
        public override string ToString()
        {
<<<<<<< HEAD
            return " Details of " + FirstName + " " + LastName + " are: " + "Address: " + Address           + " City: " + City + "\n"
                                  + "                                   " + " State:   " + State            + " Zipcode: " + Zipcode + "\n"
                                  + "                                   " + "Phone Number:" + PhoneNumber   + " EmailId: " + EmailId;
        }
    }
    class AddressBook
    {
        private ArrayList contactDetailsList;
        private Dictionary<string, Contacts> contactDetailsMap;
        public AddressBook()
        {
            contactDetailsList = new ArrayList();
            contactDetailsMap = new Dictionary<string, Contacts>();
        }
        public void AddDetails()
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            int ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Address");
            string Email = Console.ReadLine();
            Contacts contactDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            contactDetailsList.Add(contactDetails);
            contactDetailsMap.Add(FirstName, contactDetails);
        }
        public void EditDetails(string name)
        {
            if (contactDetailsMap.ContainsKey(name))
            {
                Console.WriteLine("Enter First name");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last name");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email Address");
                string Email = Console.ReadLine();
                Contacts contactDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
                contactDetailsList.Add(contactDetails);
                contactDetailsMap[FirstName] = contactDetails;
            }
            else
            {
                Console.WriteLine("First Name not found");
            }
        }
        public void ComputeDetails()
        {
            foreach (Contacts contact in contactDetailsList)
=======
            return " Details of " + FirstName + " " + LastName + " are: " + "Address: " + Address           + "City: " + City + "\n"
                                  + "                                   " + "State:   " + State             + "Zip Code: " + ZipCode + "\n"
                                  + "                                   " + "Phone Number: " + PhoneNumber  + "Email Address: " + Email;
        }
        class AddressBook
        {
            private ArrayList contactDetailsList;
            private Dictionary<string, Contacts> contactDetailsMap;
            public AddressBook()
>>>>>>> UC4_DeletePerson
            {
                contactDetailsList = new ArrayList();
                contactDetailsMap = new Dictionary<string, Contacts>();
            }
<<<<<<< HEAD
        }
        public static void Main(string[] args)
        {
            int Option = 0;
            Console.WriteLine("Welcome To Address Book Program");
            AddressBook details = new AddressBook();
            do
            {
                Console.WriteLine("1 To Add a Contact Details");               
                Console.WriteLine("2 To Edit a Contact Details");
                Console.WriteLine("0 To Exit");            
                Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            details.AddDetails();
                            details.ComputeDetails();
                            break;                           
                        case 2:
                            Console.WriteLine("Enter First Name to Edit");
                            string Name = Console.ReadLine();
                            details.EditDetails(Name);
                            details.ComputeDetails();
=======
            public void AddDetails()
            {
                Console.WriteLine("Enter First name");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last name");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone number");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email Address");
                string Email = Console.ReadLine();
                Contacts contactDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
                contactDetailsList.Add(contactDetails);
                contactDetailsMap.Add(FirstName, contactDetails);
            }           
            public void ComputeDetails()
            {
                foreach (Contacts contact in contactDetailsList)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
            public void EditDetails(string Name)
            {
                if (contactDetailsMap.ContainsKey(Name))
                {
                    Console.WriteLine("Enter First name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    string Address = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    string City = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    string State = Console.ReadLine();
                    Console.WriteLine("Enter Zip Code");
                    int ZipCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone number");
                    int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Email Address");
                    string Email = Console.ReadLine();
                    Contacts contactDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
                    contactDetailsList.Add(contactDetails);
                    contactDetailsMap[Name] = contactDetails;
                }
                else
                {
                    Console.WriteLine("Frist Name not found");
                }
            }
            public void DeleteContact()
            {
                Console.WriteLine("Enter Frist Name to Delete Contact ");
                string DName = Console.ReadLine();
                if (contactDetailsMap.ContainsKey(DName.ToLower()))
                {
                    contactDetailsMap.Remove(DName.ToLower());
                    Console.WriteLine("Deleted");
                }
                else
                {
                    Console.WriteLine("Frist Name not found");
                }
            }
            public static void Main(string[] args)
            {
                int Option = 0;
                Console.WriteLine("Welcome To Address Book");
                AddressBook details = new AddressBook();
                do
                {
                    Console.WriteLine("1 To Add a Contact Details");
                    Console.WriteLine("2 To Edit a Contact Details");
                    Console.WriteLine("3 To Delete Contact");
                    Console.WriteLine("4 to show contact details");
                    Console.WriteLine("0 To Exit");
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            Console.WriteLine("Enter the number of person that you want to add");
                            int addPerson = int.Parse(Console.ReadLine());
                            for (int numOfPerson = 1; numOfPerson <= addPerson; numOfPerson++)
                            {
                                details.AddDetails();
                                details.ComputeDetails();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter the number of person that you want to add");
                            int editPerson = int.Parse(Console.ReadLine());
                            for (int numOfPerson = 1; numOfPerson <= editPerson; numOfPerson++)
                            {
                                Console.WriteLine("Enter a First Name to Edit");
                                string Name = Console.ReadLine();
                                details.EditDetails(Name);
                                details.ComputeDetails();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the number of person that you want to add");
                            int deletePerson = int.Parse(Console.ReadLine());
                            for (int numOfPerson = 1; numOfPerson <= deletePerson; numOfPerson++)
                            {
                                details.DeleteContact();
                            }
                            break;
                        case 4:
                                details.ComputeDetails();
>>>>>>> UC4_DeletePerson
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            break;
                        default:
<<<<<<< HEAD
                            Console.WriteLine("Wrong opction");
                            break;
                    }                
=======
                            Console.WriteLine("Wrong Opction");
                            break;
                    }                    
                }
                while (Option != 0);
>>>>>>> UC4_DeletePerson
            }
            while (Option != 0);
        }
    }
}