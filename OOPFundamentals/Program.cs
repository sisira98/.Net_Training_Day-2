// See https://aka.ms/new-console-template for more information
string firstName = string.Empty;
var lastName = string.Empty;
int age = 0;
double salary = 0.0;

Console.Write("Please enter your name: ");

firstName = Console.ReadLine();
Console.Write("Please enter your name: ");

lastName = Console.ReadLine();

Console.Write("Please enter your age: ");

age = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter your salary:");
salary = Convert.ToDouble(Console.ReadLine());


Person person = new Person( firstName, lastName, age);
person.SetSalary(salary);



Console.WriteLine($"Entered name : {person.GetFullName(firstName)}");
Console.WriteLine($"Entered age : {person.Age}");
Console.WriteLine($"Entered salary :{person.GetSalary()}");
