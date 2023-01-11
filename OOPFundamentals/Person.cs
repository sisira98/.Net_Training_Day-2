
public class Person

    //cunstructor
{
    public Person(string firstName, string lastName, int age)
    { 
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    //properties 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //field
    private double _salary;

    //method
    public double GetSalary()
    {
        return _salary;
    }

    public void SetSalary(double salary)
    {
        _salary = salary;
    }

    public string GetFullName()
    {
    return FirstName+ " " + LastName;

    }
    public string GetFullName(string middleName)
    {
        return FirstName + " " + middleName+ " " + LastName;

    }


}