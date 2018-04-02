using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;


class Program
{
    static void Main()
    {
        string commands = Console.ReadLine();
        List<Team> teams = new List<Team>();
        while (commands != "END")
        {
            string[] args = commands.Split(";");

            switch (args[0])
            {
                case "Team":
                    CreateTeam(args, teams);
                    break;
                case "Add":
                    AddPlayerToTeam(args, teams);
                    break;
                case "Remove":
                    RemovePlayerFromTeam(args, teams);
                    break;
                case "Rating":
                    PrintTeamRating(args, teams);
                    break;
            }

            commands = Console.ReadLine();
        }

    }

    private static void PrintTeamRating(string[] args, List<Team> teams)
    {
        try
        {
            string teamName = args[1];
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            Validators.ValidateTeamExistance(teamName, team);
            Console.WriteLine(team);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void RemovePlayerFromTeam(string[] args, List<Team> teams)
    {
        try
        {
            string teamName = args[1];
            string playerName = args[2];

            Team team = teams.FirstOrDefault(t => t.Name == teamName);
            Player player = new Player();
            foreach (var t in teams)
            {
                foreach (var currentPlayer in t.Players)
                {
                    if (currentPlayer.Name == playerName)
                    {
                        player = currentPlayer;
                    }
                }
            }

            team.RemovePlayer(playerName, team, player);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void CreateTeam(string[] args, List<Team> teams)
    {
        try
        {
            Team team = new Team(args[1]);
            teams.Add(team);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void AddPlayerToTeam(string[] args, List<Team> teams)
    {
        try
        {
            string teamName = args[1];
            string playerName = args[2];
            int endurance = int.Parse(args[3]);
            int sprint = int.Parse(args[4]);
            int dribble = int.Parse(args[5]);
            int passing = int.Parse(args[6]);
            int shooting = int.Parse(args[7]);

            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            Validators.ValidateTeamExistance(teamName, team);
            team.AddPlayer(player, team);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

