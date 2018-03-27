using System;
using System.Collections.Generic;
using System.Text;


class Engine
{
    private const string offset = "  ";

    public string model;
    public int power;
    public int displacement;
    public string efficiency;

    public Engine(string model, int power)
    {
        Model = model;
        Power = power;
    }
    public Engine(string model, int power, int displacement) : this(model, power)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = "n/a";
    }
    public Engine(string model, int power, string efficiency)
    {
        Model = model;
        Power = power;
        Displacement = -1;
        Efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }
    public int Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }
    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}{1}:\n", offset, this.model);
        sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
        sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.displacement == -1 ? "n/a" : this.displacement.ToString());
        sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.efficiency);

        return sb.ToString();
    }
}

