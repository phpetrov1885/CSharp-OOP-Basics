using System;
using System.Collections.Generic;
using System.Text;



class Person
{
    private string name;
    private Company company;
    private Car car;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Child> childs;

    public Person()
    {
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.childs = new List<Child>();
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public Company Company
    {
        get { return company; }
        set { company = value; }
    }
    public Car Car
    {
        get { return car; }
        set { car = value; }
    }
    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }
    public List<Parent> Parents
    {
        get { return parents; }
        set { parents = value; }
    }
    public List<Child> Childs
    {
        get { return childs; }
        set { childs = value; }
    }

    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        sb.AppendLine(name);
        sb.AppendLine("Company: ");
        if (this.company!=null)
        {
            sb.AppendLine(this.company.ToString());
        }
        if (this.car != null)
        {
            sb.AppendLine(this.car.ToString());
        }
        sb.AppendLine($"Pokemon:");
        if (this.pokemons.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, this.pokemons));
        }
        sb.AppendLine($"Parents:");
        if (this.parents.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, this.parents));
        }
        if (this.childs.Count != 0)
        {
            sb.AppendLine($"Children:");
            sb.Append(string.Join(Environment.NewLine, this.childs));
        }
        else
        {
            sb.Append("Children:");
        }

        return sb.ToString();
    }
}

