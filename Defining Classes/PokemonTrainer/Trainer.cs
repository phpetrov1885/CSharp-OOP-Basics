using System;
using System.Collections.Generic;
using System.Text;


class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer()
    {
        this.pokemons = new List<Pokemon>();
    }
    public Trainer(string name,int badges) : this()
    {
        this.Name = name;
        this.Badges = badges;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }
    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public void AddBadge()
    {
        Badges++;
    }

    public void RemovePokemon(Pokemon pokemon)
    {
        Pokemons.Remove(pokemon);
    }
}

