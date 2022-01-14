// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

AddressBookSystem.Contact contact = new AddressBookSystem.Contact();
bool flag = true;
while (flag)
{
    Console.WriteLine("Enter your Choice Number to Execute the Address Program Press-\n 1-Contacts, \n 2-Add Contact, \n 3-Edit Contact, \n 4-Delete Contact, \n 5-Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the Contact Information in Format of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
            AddressBookSystem.Contact newContact = new AddressBookSystem.Contact();
            newContact.FirstName = Console.ReadLine();
            newContact.LastName = Console.ReadLine();
            newContact.Address = Console.ReadLine();
            newContact.City = Console.ReadLine();
            newContact.State = Console.ReadLine();
            newContact.Zip = Console.ReadLine();
            newContact.PhoneNumber = Console.ReadLine();
            newContact.Email = Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
            Console.WriteLine("Enter the Contact to be Add: ");
            AddressBookSystem.Contact contact1 = new AddressBookSystem.Contact();
            AddressBookSystem.AddressBook addressBook = new AddressBookSystem.AddressBook();
            addressBook.AddContact(contact1);
            contact1.FirstName = Console.ReadLine();
            contact1.LastName = Console.ReadLine();
            contact1.Address = Console.ReadLine();
            contact1.City = Console.ReadLine();
            contact1.State = Console.ReadLine();
            contact1.Zip = Console.ReadLine();
            contact1.PhoneNumber = Console.ReadLine();
            contact1.Email = Console.ReadLine();
            addressBook.Display();
            break;
        case 3:
            Console.WriteLine("Enter the Contact Name to be Edited: ");
            string name = Console.ReadLine();
            AddressBookSystem.AddressBook ab = new AddressBookSystem.AddressBook();
            ab.EditContact(name);
            ab.Display();
            break;
        case 4:
            Console.WriteLine("Enter the Contact Name to be Deleted: ");
            string user = Console.ReadLine();
            AddressBookSystem.AddressBook abb = new AddressBookSystem.AddressBook();
            abb.DeleteContact(user);
            abb.Display();
            break;
        case 5:
            flag = false;
            break;
    }
}
