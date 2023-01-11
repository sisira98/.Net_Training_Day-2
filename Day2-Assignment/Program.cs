int balance = 100000;
bool CheckCredentails()
{
    bool credential = false;
    Console.WriteLine("Please enter the 5 digit card number");
    int inputCardNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the 4 digit pin number");
    int inputPin = Convert.ToInt32(Console.ReadLine());

    if (inputCardNumber == 23456 && inputPin == 1234)
    {
        credential = true;
    }
    return credential;
}
string Menu()
{
    Console.WriteLine("Please choose one of the options");
    Console.WriteLine("Enter A for Check balance");
    Console.WriteLine("Enter B for Withdraw the amount");
    Console.WriteLine("Enter C for Deposit the amount");
    Console.WriteLine("Enter Q for Quit the program");
    return Console.ReadLine();
}

void AtmOperations(string option)
{
    switch (option)
    {
        case "A":
            CheckBalance();
            break;
        case "B":
            WithdrawMoney();
            break;
        case "C":
            Deposit();
            break;
        case "Q":
            Console.WriteLine("Thank you. Please visit again.");
            break;
        default:
            Console.WriteLine("Please choose correctly");
            break;
    }
}

bool checkCredentail = CheckCredentails();
if (checkCredentail)
{
    string choice;
    do
    {
        choice = Menu();
        AtmOperations(choice);

    }
    while (!choice.Equals("Q"));
}

else
{
    Console.WriteLine("Invalid credentails, Please try again");
}

void CheckBalance()
{

    Console.WriteLine($"Your account balance is {balance}");
}
void WithdrawMoney()
{

    Console.WriteLine("Enter the amount to withdraw");
    int withdrawMoney = Convert.ToInt32(Console.ReadLine());
    if (withdrawMoney > balance)
    {
        Console.WriteLine("Insufficient balance, Please try again.");
    }
    else if (withdrawMoney < balance && withdrawMoney != 0)
    {
        Console.WriteLine($"Please accept yoyr money. Your account balance is {balance - withdrawMoney}");

    }
    else if (withdrawMoney == 0)
    {
        Console.WriteLine("Not enough amonut to witdraw. Please repeat the process");
    }
}
void Deposit()
{
    Console.WriteLine("Enter the amont to deposit");
    int deposit = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your account balance is ₹{balance + deposit}");

}

