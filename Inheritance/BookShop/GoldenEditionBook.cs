using System;
using System.Collections.Generic;
using System.Text;


public class GoldenEditionBook : Book
{
    private const decimal IncreasePriceMultiplier = 1.3m;
    public GoldenEditionBook(string author,string title, decimal price) : base(author, title, price)
    {
    }

    public override decimal Price
    {
        get { return base.Price; }
        set { base.Price = value * IncreasePriceMultiplier; }
    }
}

