using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> totalPersons = new List<Person>();
        int numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            string[] splitInput = Console.ReadLine().Split();
            Person person = new Person(splitInput[0], int.Parse(splitInput[1]));

            totalPersons.Add(person);
        }
       
        foreach (var person in totalPersons.OrderBy(p=>p.Name))
        {
            if (person.Age>30)
            {
                Console.WriteLine(person);
            }
        }
    }
}

