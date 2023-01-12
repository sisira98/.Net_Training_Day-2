//Memory Based Address Book

    AddressBook addressBook = new AddressBook();
    bool stopFlag = false;
List<Contact> cachedList = new List<Contact>();
    for(int i = 0; i <= 3; i++)
    {
    if(i== 3)
        {
            Console.WriteLine("Storage full !");
            break;
        }
    Console.WriteLine("Enter details to add to contact");
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
    var contact = new Contact(firstName, lastName, phone, email);
    addressBook.AddContact(contact);
    cachedList.Add(contact);
    Console.WriteLine("Enter E to stop and enter any key  to continue");
     if (Console.ReadLine() == "E")
        {
            stopFlag = true;
            break;
        }

    }
    if (stopFlag)
    {

    Console.WriteLine("Enter name of the contact to remove");
    string name = Console.ReadLine();
    int index = 0;
    for(int i = 0; i<=cachedList.Count+1; i++)
    {
        if (cachedList[i].FirstName == name)
        {
            index += i;
            addressBook.RemoveContact(index);
            Console.WriteLine("Contact removed");
            break
;        }
        
        
    }
    Console.WriteLine("Sorted Contact list based on Name");
    addressBook.SortContact();
    Console.WriteLine("Contact List");
    addressBook.PrintContact();
    }


