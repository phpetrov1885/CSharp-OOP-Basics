using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person()
    {
        products = new List<Product>();
    }

    public Person(string name, decimal money) : this()
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
    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public string BuyProduct(Product product)
    {
        if (money < product.Money)
        {
            return ($"{Name} can't afford {product.Name}");
        }
        else
        {
            products.Add(product);
            money -= product.Money;
            return ($"{Name} bought {product.Name}");
        }
    }

    public override string ToString()
    {
        string result;
        if (Products.Count <= 0)
        {
            result = $"{Name} - Nothing bought";
        }
        else
        {
            result = $"{Name} - {string.Join(", ", Products)}";
        }

        return result;
    }
}

