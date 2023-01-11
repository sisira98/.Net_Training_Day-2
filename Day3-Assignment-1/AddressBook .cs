
class AddressBook 
    {
    List<Contact> contactList = new List<Contact>
    {

    };
    public void AddContact()
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        string email = string.Empty;
        long phone = 0;
        int limit = 5;
        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();
        Console.Write("Please enter your email: ");
        email = Console.ReadLine();
        Console.Write("Please enter your phone number:");
        phone = Convert.ToInt64(Console.ReadLine());
        contactList.Add(new Contact(firstName, lastName, phone, email));
    }

    public void RemoveContact(string firstName)
    {
        int index = 0;
        foreach (Contact contact in contactList)
        {
            if (contact.FirstName == firstName)
            {
            index += contactList.IndexOf(contact);
             contactList.RemoveAt(index);
             Console.WriteLine("Contact removed");
            }
            else
            {

            Console.WriteLine("No contact found for this name");
                break;
            }
        }
    }
    public void PrintContact()
    {

        foreach (Contact contact in contactList)
        {
            Console.WriteLine($"Contact: {contact.FirstName + " " + contact.LastName}:{contact.Email}:{contact.Phone}");
        }

    }

    public void SortContact() 
    {
        List<Contact> sortedList = contactList.OrderBy(o => o.FirstName).ToList();
        foreach (Contact contact in sortedList)
        {
            Console.WriteLine($"Contact: {contact.FirstName + " " + contact.LastName}:{contact.Email}:{contact.Phone}");
        }

    }
}
