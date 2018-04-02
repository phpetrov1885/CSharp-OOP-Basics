using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    const int MIN_LENGHT = 3;
    const decimal MIN_SALARY = 460;
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
        set
        {
            NameValidation(value, "First");
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            NameValidation(value, "Last");
            lastName = value;
        }
    }
    public string FullName
    {
        get { return firstName + " " + lastName; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }
    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < MIN_SALARY)
            {
                throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
            }
            salary = value;
        }
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

    public void NameValidation(string value, string nameField)
    {
        if (value.Length < MIN_LENGHT)
        {
            throw new ArgumentException($"{nameField} name cannot contain fewer than {MIN_LENGHT} symbols!");
        }
    }
    public override string ToString()
    {
        return $"{FirstName} {lastName} receives {Salary:f2} leva.";
    }
}

