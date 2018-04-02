using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Team
{
    private string name;
    private int rating;
    private List<Player> players;

    public Team()
    {
        players=new List<Player>();
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
    public int Rating
    {
        get
        {
            return this.rating =
                (int)Math.Round((this.Players.Sum(p => p.Endurance) +
                                 this.Players.Sum(p => p.Sprint) +
                                 this.Players.Sum(p => p.Dribble) +
                                 this.Players.Sum(p => p.Passing) +
                                 this.Players.Sum(p => p.Shooting)) / 5.0);
        }
    }
    public List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public void RemovePlayer(string playerName,Team team,Player player)
    {
        Validators.ValidatePlayerExistance(playerName,team);
        team.players.Remove(player);
    }
    public void AddPlayer( Player player, Team team)
    {
        team.players.Add(player);
    }

    public override string ToString()
    {
        return $"{Name} - {Rating}";
    }
}

