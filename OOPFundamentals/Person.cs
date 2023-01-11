//immutable class
public class Person

    //cunstructor
{
    public Person(string firstName, string lastName, int age, double salary)
    { 
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        _salary= salary;
    }
    //properties 
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }

    //field
    private double _salary;

    //method
    public double GetSalary()
    {
        return _salary;
    }

    //public void setsalary(double salary)
    //{
    //    _salary = salary;
    //}

    public string GetFullName()
    {
    return FirstName+ " " + LastName;

    }
    public string GetFullName(string middleName)
    {
        return FirstName + " " + middleName+ " " + LastName;

    }


}