using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    public Team()
    {
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
    }
    public Team(string name):this()
    {
        Name = name;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return firstTeam; }
    }
    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }

    public void AddPlayerToTeam(Person player)
    {
        if (player.Age < 40)
        {
            firstTeam.Add(player);
        }
        else
        {
            reserveTeam.Add(player);
        }
    }
}

