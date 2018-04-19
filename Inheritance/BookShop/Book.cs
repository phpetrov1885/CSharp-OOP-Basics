using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    private string author;
    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        Author = author;
        Title = title;
        Price = price;
    }
    public string Author
    {
        get { return author; }
        set
        {
            Validators.ValidateAuthorSecondName(value);
            author = value;
        }
    }

    public string Title
    {
        get { return title; }
        set
        {
            Validators.ValidateTitle(value);
            title = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            Validators.ValidatePrice(value);
            price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        sb.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:F2}");

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

