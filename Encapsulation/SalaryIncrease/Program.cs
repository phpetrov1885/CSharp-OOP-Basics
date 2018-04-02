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
        var bonus = decimal.Parse(Console.ReadLine());
       
        PrintPersons(persons,bonus);

    }
    private static void PrintPersons(List<Person> persons,decimal bonus)
    {
        foreach (var person in persons)
        {
            person.IncreaseSalary(bonus);
            Console.WriteLine(person);
        }
    }
    private static void SplitPersonArgsAndAddtoCollection(List<Person> persons)
    {
        string[] personArgs = Console.ReadLine().Split();
        string firstName = personArgs[0];
        string lastName = personArgs[1];
        int age = int.Parse(personArgs[2]);
        decimal salary = decimal.Parse(personArgs[3]);

        Person currentPerson = new Person(firstName, lastName, age,salary);
        persons.Add(currentPerson);
    }
}

