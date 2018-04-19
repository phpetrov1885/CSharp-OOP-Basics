using System;
using System.Collections.Generic;
using System.Text;


public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName,string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName
    {
        get { return firstName; }
        set
        {
            Validators.ValidateFirstName(value,nameof(firstName));
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            Validators.ValidateLastName(value, nameof(lastName));
            lastName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        sb.AppendLine();
        sb.AppendLine($"First Name: {FirstName}")
            .AppendLine($"Last Name: {LastName}");

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

