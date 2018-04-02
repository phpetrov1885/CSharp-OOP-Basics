using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;


class Program
{
    static void Main()
    {
        List<Person>persons=new List<Person>();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            SplitPersonArgsAndAddtoCollection(persons);
        }

        PrintPersonsByOrder(persons);
    }

    private static void PrintPersonsByOrder(List<Person> persons)
    {
        foreach (var person in persons.OrderBy(p=>p.FirstName).ThenBy(p=>p.Age))
        {
            Console.WriteLine(person);
        }
    }

    private static void SplitPersonArgsAndAddtoCollection(List<Person> persons)
    {
        string[] personArgs = Console.ReadLine().Split();
        string firstName = personArgs[0];
        string lastName = personArgs[1];
        int age = int.Parse(personArgs[2]);
        Person currentPerson = new Person(firstName, lastName, age);
        persons.Add(currentPerson);
    }
}

