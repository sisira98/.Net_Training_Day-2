// See https://aka.ms/new-console-template for more information
string firstName = string.Empty;
string lastName = string.Empty;
string middleName = string.Empty;
int age = 0;
double salary = 0.0;

Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();
Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your salary:");
salary = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter your middle name: ");
middleName = Console.ReadLine();


Person person = new Person(firstName, lastName, age, salary);



if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Entered name : {person.GetFullName()}");
}
else
{
    Console.WriteLine($"Entered name : {person.GetFullName(middleName)}");
}
Console.WriteLine($"Entered age : {person.Age}");
Console.WriteLine($"Entered salary :{person.GetSalary()}");


//inheritance
Triangle tirangle = new Triangle()
{
    Height = 10, Width = 5
};

Rectangle rectangle = new Rectangle() { Height= 10, Width = 5 };
Rectangle square = new Rectangle() { Height= 10, Width = 10 };