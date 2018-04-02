using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Validations
{
    private const int MIN_WEIGHT_DOUGH = 1;
    private const int MAX_WEIGHT_DOUGH = 200;

    private const int MIN_WEIGHT_TOPPING = 1;
    private const int MAX_WEIGHT_TOPPING = 50;

    private const int MIN_NAME_WENGHT = 1;
    private const int MAX_NAME_WENGHT = 15;

    private const int MIN_TOPPINGS_COUNT = 0;
    private const int MAX_TOPPINGS_COUNT = 10;

    //Validations for the dough
    public static void ValidateTypeDought(Dictionary<string, double> dictionary, string value)
    {
        if (!dictionary.Any(f => f.Key == value.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
        }
    }
    public static void ValidateWeightDought(double value)
    {
        if (value < MIN_WEIGHT_DOUGH || value > MAX_WEIGHT_DOUGH)
        {
            throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT_DOUGH}..{MAX_WEIGHT_DOUGH}].");
        }
    }

    //Validations for the toppings
    public static void ValidateTypeTopping(Dictionary<string, double> dictionary, string value)
    {
        if (!dictionary.Any(f => f.Key == value.ToLower()))
        {
            throw new ArgumentException($"Cannot place {value} on top of your pizza.");
        }
    }
    public static void ValidateWeightTopping(double value, string type)
    {
        if (value < MIN_WEIGHT_TOPPING || value > MAX_WEIGHT_TOPPING)
        {
            throw new ArgumentException($"{type} weight should be in the range [{MIN_WEIGHT_TOPPING}..{MAX_WEIGHT_TOPPING}].");
        }
    }

    //Validations for the pizza
    public static void ValidatePizzaName(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_WENGHT)
        {
            throw new ArgumentException($"Pizza name should be between {MIN_NAME_WENGHT} and {MAX_NAME_WENGHT} symbols.");
        }
    }
    public static void ValidatePizzaToppingCount(List<Topping>toppings)
    {
        if (toppings.Count>MAX_TOPPINGS_COUNT)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS_COUNT}..{MAX_TOPPINGS_COUNT}].");
        }
    }
}

