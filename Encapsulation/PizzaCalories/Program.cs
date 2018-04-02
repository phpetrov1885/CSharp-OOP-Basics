using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            string pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = new Pizza(pizzaName);

            AddDough(pizza);

            string command = Console.ReadLine();

            while (command != "END")
            {
                AddToppings(pizza, command);

                command = Console.ReadLine();
            }

            Console.WriteLine(pizza);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void AddToppings(Pizza pizza,string command)
    {
        string[] toppingArgs = command.Split();
        string name = toppingArgs[1];
        double weight = double.Parse(toppingArgs[2]);
        
        Topping topping=new Topping(name ,weight);
        pizza.AddTopping(topping);
    }

    private static void AddDough(Pizza pizza)
    {
        string[] doughInput = Console.ReadLine().Split();
        string flourType = doughInput[1];
        string bakingTechnique = doughInput[2];
        double doughWeight = double.Parse(doughInput[3]);

        Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
        pizza.SetDough(dough);
    }
}

