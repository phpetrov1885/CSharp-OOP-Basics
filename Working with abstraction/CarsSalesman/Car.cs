using System;
using System.Collections.Generic;
using System.Text;


class Car
{
    private const string offset = "  ";

    public string model;
    public Engine engine;
    public int weight;
    public string color;

    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
        Weight = -1;
        Color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = "n/a";
    }

    public Car(string model, Engine engine, string color)
    {
        Model = model;
        Engine = engine;
        Weight = -1;
        Color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
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

    public int Weight
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
        sb.AppendFormat("{0}:\n", this.model);
        sb.Append(this.engine.ToString());
        sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? "n/a" : this.weight.ToString());
        sb.AppendFormat("{0}Color: {1}", offset, this.color);

        return sb.ToString();
    }
}

