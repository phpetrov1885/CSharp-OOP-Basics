using System;
using System.Collections.Generic;
using System.Text;

class Validator
{
    public static void MoneyValidator(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Money cannot be negative");
        }
    }
    public static void NameValidator(string nameValue)
    {
        if (string.IsNullOrWhiteSpace(nameValue))
        {
            throw new ArgumentException("Name cannot be empty");
        }
    }
}

