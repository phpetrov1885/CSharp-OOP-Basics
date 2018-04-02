using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person()
    {
    }
    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
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
    public string FullName
    {
        get { return firstName + " " + lastName; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (Age > 30)
        {
            salary += salary * percentage / 100;
        }
        else
        {
            salary += salary * percentage / 200;
        }
    }
    public override string ToString()
    {
        return $"{FullName} receives {Salary:f2} leva.";
    }
}

