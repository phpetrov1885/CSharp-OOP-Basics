using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
    private const int DEFAULT_MULTIPLIER = 2;
    private Dictionary<string, double> validToppingTypes = new Dictionary<string, double>
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    private string type;
    private double weight;
    
    public Topping(string type, double weight)
    {
        Type = type;
        Validations.ValidateWeightTopping(weight, type);
        Weight = weight;
    }
   
    private double ToppingMultiplier => validToppingTypes[type];
    public double Calories => DEFAULT_MULTIPLIER * Weight * ToppingMultiplier;
    public string Type
    {
        get { return type; }
        set
        {
            Validations.ValidateTypeTopping(validToppingTypes, value);
            type = value.ToLower();
        }
    }
    public double Weight
    {
        get { return weight; }
        set
        {
            weight = value;
        }
    }
}

