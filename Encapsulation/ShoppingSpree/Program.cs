
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        List<Product> products = new List<Product>();

        string[] personsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        try
        {
            SplitPersonInputAndAddToCollection(persons, personsInput);

            SplitProductInputAndAddToCollection(products, productsInput);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
      

        string shopping = Console.ReadLine();

        while (shopping != "END")
        {
            BuyWantedPersonsProducts(persons, products, shopping);
            
            shopping = Console.ReadLine();
        }

        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }
    }

    private static void BuyWantedPersonsProducts(List<Person> persons, List<Product> products, string shopping)
    {
        string[] shoppingArgs = shopping.Split();
        string personName = shoppingArgs[0];
        string productName = shoppingArgs[1];

        Person person = persons.First(p => p.Name == personName);
        Product product = products.First(p => p.Name == productName);

        string result = person.BuyProduct(product);
        Console.WriteLine(result);
    }

    private static void SplitProductInputAndAddToCollection(List<Product> products, string[] productsInput)
    {
        foreach (var count in productsInput)
        {
            string[] tokens = count.Split('=');
            string productName = tokens[0];
            decimal productPrice = decimal.Parse(tokens[1]);

            Product product = new Product(productName, productPrice);
            products.Add(product);
        }
    }

    private static void SplitPersonInputAndAddToCollection(List<Person> persons, string[] personsInput)
    {
        foreach (var count in personsInput)
        {
            string[] tokens = count.Split('=');
            string personName = tokens[0];
            decimal personMoney = decimal.Parse(tokens[1]);

            Person person = new Person(personName, personMoney);
            persons.Add(person);
        }
    }
}

