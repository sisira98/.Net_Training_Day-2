
 public class AddressBook 
    {
    private List<Contact> _contactList;
    public List<Contact> ContactList => _contactList;
    public AddressBook()
    {
        _contactList= new List<Contact>();
    }
    public void AddContact(Contact contact)
    {
        _contactList.Add(contact);
    }

    public void RemoveContact(int index)
    {
        Console.WriteLine(_contactList[index]);
       _contactList.RemoveAt(index);
    }
    public void PrintContact()
    {
        foreach (Contact contact2 in _contactList)
        {
            Console.WriteLine(contact2);
        }
        

       
    }

    public void SortContact() 
    {
        List<Contact> sortedList = _contactList.OrderBy(o => o.FirstName).ToList();
        foreach (Contact contact in sortedList)
        {
            Console.WriteLine($"Contact: {contact.FirstName + " " + contact.LastName}:{contact.Email}:{contact.Phone}");
        }

    }
}
