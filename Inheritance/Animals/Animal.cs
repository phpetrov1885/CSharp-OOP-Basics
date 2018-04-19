using System;
using System.Collections.Generic;
using System.Text;

public class Animal : ISountProducable
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public string Name
    {
        get { return name; }
        set
        {
            ValidateProperties(value);
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }
    public string Gender
    {
        get { return gender; }
        set
        {
            ValidateProperties(value);
            gender = value;
        }
    }

    public void ValidateProperties(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Invalid input!");
        }
    }
    public virtual string ProduceSound()
    {
        return "noise...";
    }

    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        sb.AppendLine($"{GetType().Name}")
            .AppendLine($"{Name} {Age} {Gender}")
            .AppendLine(ProduceSound());

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

