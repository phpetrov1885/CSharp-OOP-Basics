using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Validators
{
    private const int MIN_STATS = 0;
    private const int MAX_STATS = 100;
    public static void ValidateStats(double stats, string statsName)
    {
        if (stats < MIN_STATS || stats > MAX_STATS)
        {
            throw new ArgumentException($"{statsName} should be between {MIN_STATS} and {MAX_STATS}.");
        }
    }
    public static void ValidatePlayerName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A name should not be empty.");
        }
    }
    public static void ValidatePlayerExistance (string playerName, Team team)
    {
        if (!team.Players.Any(t=>t.Name==playerName))
        {
            throw new ArgumentException($"Player {playerName} is not in {team.Name} team.");
        }
    }
    public static void ValidateTeamExistance(string teamName, Team team)
    {
        if (team==null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
    }

}
