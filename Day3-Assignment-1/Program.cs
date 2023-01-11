//Memory Based Address Book

AddressBook addressBook = new AddressBook();
{
    bool stopFlag = false;
    for(int i = 0; i <= 3; i++)
    {
    if(i== 3)
        {
            Console.WriteLine("Storage full !");
            break;
        }
    Console.WriteLine("Enter details to add to contact");
    addressBook.AddContact();
    Console.WriteLine("Enter E to stop and press any key  to continue");
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
    addressBook.RemoveContact(name);
    Console.WriteLine("Sorted Contact list based on Name");
    addressBook.SortContact();
    Console.WriteLine("Contact List");
    addressBook.PrintContact();
    }

}

