using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class Dough
{
    private const int DEFAULT_MULTIPLIER = 2;

    private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0
    };
    private Dictionary<string, double> validBakingTechnique = new Dictionary<string, double>
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0,
    };

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType,string bakingTechnique,double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }
    private double FlourMultiplier => validFlourTypes[flourType];
    private double BakingTechniqueMultiplier => validBakingTechnique[bakingTechnique];
    public double Calories => DEFAULT_MULTIPLIER * Weight * FlourMultiplier * BakingTechniqueMultiplier;

    public string FlourType
    {
        get { return flourType; }
        set
        {
            Validations.ValidateTypeDought(validFlourTypes, value);
            flourType = value.ToLower();
        }
    }
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            Validations.ValidateTypeDought(validBakingTechnique, value);
            bakingTechnique = value.ToLower();
        }
    }
    public double Weight
    {
        get { return weight; }
        set
        {
            Validations.ValidateWeightDought(value);
            weight = value;
        }
    }
}

