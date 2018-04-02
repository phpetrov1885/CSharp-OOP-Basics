using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza()
    {
        toppings = new List<Topping>();
    }
    
    public Pizza(string name) : this()
    {
        Name = name;
        Dough = dough;
    }

    private double ToppingCalories
    {
        get
        {
            if (toppings.Count == 0)
            {
                return 0;
            }

            return toppings.Select(t => t.Calories).Sum();
        }
    }

    private double Calories => Dough.Calories + ToppingCalories;
    public string Name
    {
        get { return name; }
        set
        {
            Validations.ValidatePizzaName(value);
            name = value;
        }
    }
    private Dough Dough { get; set; }
    private List<Topping> Toppings { get; set; }

    public void SetDough(Dough dough)
    {
        if (this.Dough != null)
        {
            throw new  InvalidOperationException("Dough already set!");
        }
        Dough = dough;
    }
    public void AddTopping(Topping topping)
    {
        Validations.ValidatePizzaToppingCount(toppings);
        toppings.Add(topping);
    }

    public override string ToString()
    {
        return $"{Name} - {Calories:f2} Calories.";
    }
}

