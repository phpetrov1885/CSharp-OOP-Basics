using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml.Schema;


class Engine
{
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public Engine()
    {
        Displacement = "n/a";
        Efficiency = "n/a";
    }
    public Engine(string model, string power) : this()
    {
        Model = model;
        Power = power;
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Power
    {
        get { return power; }
        set { power = value; }
    }
    public string Displacement
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
        sb.AppendLine($"    Power: {this.power}");
        sb.AppendLine($"    Displacement: {this.displacement}");
        sb.Append($"    Efficiency: {this.efficiency}");

        return sb.ToString();
    }

}
