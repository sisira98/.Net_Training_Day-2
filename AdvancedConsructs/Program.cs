// See https://aka.ms/new-console-template for more information
//methods
//returnType MethodName(paramType, paramName...) {}
//DRY - Don't Repeat youself
//with no return types
//with return type

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

Console.Write("Enter number 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition : {a+b}");
}

Add(num1, num2);
Add(1, 2);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b > largest)
    {
        largest = b;
    }
    if(c > largest )
    {
        largest = c;
    }
    return largest;
}
int largest = GreaterThan(10, 15, 20);
Console.WriteLine($"Largest number is : {largest}");


//string manipulation

string firstName = "Sisira";
string lastName = "J S";

string fullName = firstName + " " + lastName;

//length of a string

int length = firstName.Length;
Console.WriteLine($"Firstname length : {length}");

//Replace string parts
string newFirstName = firstName.Replace("isi", "a");
Console.WriteLine($"New First name is {newFirstName}");

//split

string[] names = lastName.Split(' ');
for(int i =0; i< names.Length;i++)
{
    Console.WriteLine(names[i]);
}

//compare

string? nullString = null;
//string emptyString = "";
string whiteSpaceString = " ";

if (string.IsNullOrEmpty(nullString))
    {
    Console.WriteLine("nullString is empty or null");
}
if(string.IsNullOrWhiteSpace(whiteSpaceString))
{
    Console.WriteLine("whiteSpaceString is whilte space or null");
}

if(firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("Firat and last names are equal");
}
if(string.Equals(firstName, lastName))
 {
    Console.WriteLine("Firat and last names are equal");
}


//Date time

//DateTime date = new DateTime();

//create DateTime from date
DateTime dob = new DateTime(1998, 11, 06);
Console.WriteLine($"Date of birth is {dob}");

//create DateTime from string
DateTime parseddate = DateTime.Parse("1/23/2023", CultureInfo.InvariantCulture);
Console.WriteLine($"pardes to date {parseddate}");

//create DateTime from current timeZone
DateTime now = DateTime.Now;
Console.WriteLine($"current ticks for now is {now}");

//date to ticks
Console.WriteLine($"current ticks for now is {now.Ticks}");

//add hours to DateTime
Console.WriteLine($"add 2 hours to now {now.AddHours(2)}");


//DateOnly
//DateOnly dateOfBirth = DateOnly.FromDateTime(dob);

//TimeOnly
//TimeOnly tob = TimeOnly.FromDateTime(dob);


//exception handling
Console.Write("Enter number 1 : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 2 : ");
int b = Convert.ToInt32(Console.ReadLine());

try
{
    double quo = a / b;
    Console.WriteLine($"Result is {quo}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");  
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("Exited the program");
}


//array
int[] marks = new int[5];

for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter your mark : ");
    int num = Convert.ToInt32(Console.ReadLine());
    
}

for (int i = 0; i < marks.Length;i++)
{
    Console.WriteLine(marks[i]);
}

string[] name = new string[] { "sisira", "jayanthi", "sasikumar" };
//Lists

List<string> devs = new List<string>();

string dev = string.Empty;

while(!dev.Equals("-1"))
{
    Console.WriteLine("Enter name of the dev : ");
    dev = Console.ReadLine();
    if(dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}

foreach (string nam in devs)
{
    Console.WriteLine(nam);
}