using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    private string name;
    private decimal money;

    public Product(string name, decimal money)
    {
        Name = name;
        Money = money;
    }
    public string Name
    {
        get { return name; }
        set
        {
            Validator.NameValidator(value);
            name = value;
        }
    }
    public decimal Money
    {
        get { return money; }
        set
        {
            Validator.MoneyValidator(value);
            money = value;
        }
    }

    public override string ToString()
    {
        return Name;
    }
}

