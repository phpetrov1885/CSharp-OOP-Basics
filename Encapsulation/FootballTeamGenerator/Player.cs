using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player()
    {
        
    }
    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }
    public string Name
    {
        get { return name; }
        set
        {
            Validators.ValidatePlayerName(value);
            name = value;
        }
    }
    public int Endurance
    {
        get { return endurance; }
        set
        {
            Validators.ValidateStats(value, "Endurance");
            endurance = value;
        }
    }
    public int Sprint
    {
        get { return sprint; }
        set
        {
            Validators.ValidateStats(value, "Sprint");
            sprint = value;
        }
    }
    public int Dribble
    {
        get { return dribble; }
        set
        {
            Validators.ValidateStats(value, "Dribble");
            dribble = value;
        }
    }
    public int Passing
    {
        get { return passing; }
        set
        {
            Validators.ValidateStats(value, "Passing");
            passing = value;
        }
    }
    public int Shooting
    {
        get { return shooting; }
        set
        {
            Validators.ValidateStats(value, "Shooting");
            shooting = value;
        }
    }
}

