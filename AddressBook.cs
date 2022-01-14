using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{

    public class AddressBook
    {
        List<Contact> addressList = new List<Contact>();
        public void AddContact(Contact contact1) // This Method Will Add the Details of Customer
        {
            addressList.Add(contact1);
        }
        public void Display() // This Method will Display the Details
        {
            foreach (var contact1 in addressList)
            {
                Console.WriteLine($"\n{contact1.FirstName}  {contact1.LastName}");
                Console.WriteLine($"Last Name:  {contact1.LastName}");
                Console.WriteLine($"Address :  {contact1.Address}");
                Console.WriteLine($"City :  {contact1.City}");
                Console.WriteLine($"State :  {contact1.State}");
                Console.WriteLine($"Zip :  {contact1.Zip}");
                Console.WriteLine($"PhoneNumber :  {contact1.PhoneNumber}");
                Console.WriteLine($"Email :  {contact1.Email}");
            }
        }
        public void EditContact(string name)
        {
            foreach (var contact1 in addressList)
            {
                if (contact1.FirstName == name || contact1.LastName == name)
                {
                    Console.WriteLine("What is Required to be Edited");
                }
            }
        }

        public void DeleteContact(string user) // This Method Will Delete Particular Contact Detail Provided by User
        {
            Contact delete = new Contact();
            foreach (var contact1 in addressList)
            {
                if (contact1.FirstName == user || contact1.LastName == user)
                {
                    addressList.Remove(contact1);
                }
            }
        }
    }

}

