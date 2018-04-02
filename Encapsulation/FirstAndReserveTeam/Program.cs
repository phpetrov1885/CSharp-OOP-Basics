using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
       
        for (int i = 0; i < lines; i++)
        {
            SplitPersonArgsAndAddtoCollection(persons);
        }
       
        var team=new Team();
        foreach (var person in persons)
        {
            team.AddPlayerToTeam(person);
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
   
    private static void SplitPersonArgsAndAddtoCollection(List<Person> persons)
    {
        string[] personArgs = Console.ReadLine().Split();
        string firstName = personArgs[0];
        string lastName = personArgs[1];
        int age = int.Parse(personArgs[2]);
        decimal salary = decimal.Parse(personArgs[3]);

        Person currentPerson = new Person(firstName, lastName, age, salary);
        persons.Add(currentPerson);
    }
}

