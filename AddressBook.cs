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
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        public void AddContact(Contact contact) // This Method Will Add the Details of Customer
        {
            addressList.Add(contact);
        }
        public void Display() // This Method wii Display the Details
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);
            }
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("What is Required to be Edited");
                }
            }
        }

        public void DeleteContact(string user) // This Method Will Delete Particular Contact Detail Provided by User
        {
            Contact delete = new Contact();
            foreach (var contact in addressList)
            {
                if (contact.FirstName == user || contact.LastName == user)
                {
                    addressList.Remove(contact);
                }
            }
        }
        public void AddUniqueContact(string nam)
        {
            foreach (var contact in addressList)
            {
                if (addressList.Contains(contact))
                {
                    string uniqueName = Console.ReadLine();
                    dict.Add(uniqueName, addressList);
                }
            }
        }
        public void DisplayUniqueContacts()
        {
            // Maintain Dictionary of Addressbook Name to Addressbook
            Console.WriteLine("enter name of dictionary to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in dict)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact of " + data.FirstName + " Details are\n:" + data.FirstName + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
            }
            Console.WriteLine("Oops UniqueContacts does not exist!! Please create a UniquecontactList");
            return;
        }
    }

}

