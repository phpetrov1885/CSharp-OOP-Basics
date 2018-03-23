using System;
using System.Collections.Generic;
using System.Text;


class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;
    public Car()
    {
        Weight = "n/a";
        Color = "n/a";
    }
    public Car(string model, Engine engine):this()
    {
        Model = model;
        Engine = engine;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.model}:");
        sb.AppendLine($"  {this.Engine.Model}:");
        sb.AppendLine($"{this.engine.ToString()}");
        sb.AppendLine($"  Weight: {this.weight}");
        sb.Append($"  Color: {this.color}");
        return sb.ToString();
    }

}

