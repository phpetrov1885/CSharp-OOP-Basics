using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Validators
{
    public static void ValidateAuthorSecondName(string name)
    {
        string[] authorNames = name.Split();
        if (authorNames.Length == 2 && char.IsDigit(authorNames[1][0]))
        {
            throw new ArgumentException("Author not valid!");
        }
    }
    public static void ValidateTitle(string title)
    {
        if (title.Length < 3)
        {
            throw new ArgumentException("Title not valid!");
        }
    }
    public static void ValidatePrice(decimal price)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Price not valid!");
        }
    }
}

