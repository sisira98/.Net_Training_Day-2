// See https://aka.ms/new-console-template for more information

int cardNumber = 23456;
int pin = 1234;
int deposit;
int balance = 100000;


Console.WriteLine("Please enter the 5 digit card number");
int inputCardNumber = Convert.ToInt32(Console.ReadLine());

        if (cardNumber == inputCardNumber)
        {

        Console.WriteLine("Please enter the 4 digit pin number");
        int inputPin = Convert.ToInt32(Console.ReadLine());
            if (pin == inputPin)
            {
                Console.WriteLine("Please choose one of the options");
                Console.WriteLine("Enter A for Check balance");
                Console.WriteLine("Enter B for Withdraw the amount");
                Console.WriteLine("Enter C for Deposit the amount");
                Console.WriteLine("Enter Q for Quit the program");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "A":
                        BalanceOpt();
                        break;
                    case "B":
                        WithdrawOpt();
                        break;
                    case "C":
                        DepositOpt();
                        break;
                    case "Q":
                        Console.WriteLine("Thank you. Please visit again.");
                        break;
                    default:
                        Console.WriteLine("Please choose correctly");
                        break;
                }
            }
            if ( pin != inputPin)
            {
                Console.WriteLine("Invalid Pin, Please try again");
            }
        
        }
        else if (cardNumber != inputCardNumber)
        {
            Console.WriteLine("Invalid Account number, Please try again");
        }

void BalanceOpt()
{

        Console.WriteLine($"Your account balance is {balance}");
}
void WithdrawOpt()
{

    Console.WriteLine("Enter the amount to withdraw");
        int withdrawMoney = Convert.ToInt32( Console.ReadLine() );
        if(withdrawMoney > balance)
        {
            Console.WriteLine("Insufficient balance, Please try again.");
        }
        else if (withdrawMoney < balance && withdrawMoney != 0) 
        {
        Console.WriteLine($"Please accept yoyr money. Your account balance is {balance- withdrawMoney}");
       
        }else if(withdrawMoney == 0)
        {
            Console.WriteLine("Not enough amonut to witdraw. Please repeat the process");
        }
}
void DepositOpt()
{
    Console.WriteLine("Enter the amont to deposit");
    deposit = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your account balance is ₹{balance + deposit}");

}

