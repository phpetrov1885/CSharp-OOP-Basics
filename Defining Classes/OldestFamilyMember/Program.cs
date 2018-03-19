using System;


class Program
{
    static void Main(string[] args)
    {
        Family family = new Family();
        int numMembers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numMembers; i++)
        {
            string[] splitInput = Console.ReadLine().Split();
            Person familyPerson = new Person(splitInput[0], int.Parse(splitInput[1]));

            family.AddMember(familyPerson);

        }
        Person oldestFamilyMember = family.GetOdestMember();

        Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
    }
}

