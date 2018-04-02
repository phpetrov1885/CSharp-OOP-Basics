using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person()
    {
    }
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} is {age} years old.";
    }
}

