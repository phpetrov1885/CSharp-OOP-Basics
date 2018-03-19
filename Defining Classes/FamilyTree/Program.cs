using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var familyTree = new List<Person>();
        string inputName = Console.ReadLine();
        Person mainPerson = new Person();

        //cheking and adding the main person
        if (IsBirthday(inputName))
        {
            mainPerson.BirthDay = inputName;
        }
        else
        {
            mainPerson.Name = inputName;
        }
        familyTree.Add(mainPerson);

        string command = Console.ReadLine();
        while (command != "End")
        {
            string[] tokens = command.Split(" - ");

            if (tokens.Length > 1)
            {
                string firstPerson = tokens[0];
                string secondPerson = tokens[1];

                Person currentPerson;

                if (IsBirthday(firstPerson))
                {
                    currentPerson = familyTree.FirstOrDefault(p => p.BirthDay == firstPerson);

                    if (currentPerson == null)
                    {
                        currentPerson = new Person();
                        currentPerson.BirthDay = firstPerson;
                        familyTree.Add(currentPerson);
                    }
                    SetChild(familyTree, currentPerson, secondPerson);
                }
                else
                {
                    currentPerson = familyTree.FirstOrDefault(p => p.Name == firstPerson);

                    if (currentPerson == null)
                    {
                        currentPerson = new Person();
                        currentPerson.Name = firstPerson;
                        familyTree.Add(currentPerson);
                    }
                    SetChild(familyTree, currentPerson, secondPerson);
                }
            }
            else
            {
                tokens = tokens[0].Split();
                string name = tokens[0] + " " + tokens[1];
                string birthDay = tokens[2];

                var person = familyTree.FirstOrDefault(p => p.Name == name || p.BirthDay == birthDay);

                if (person == null)
                {
                    person = new Person();
                    familyTree.Add(person);
                }

                person.Name = name;
                person.BirthDay = birthDay;

                int index = familyTree.IndexOf(person) + 1;
                int count = familyTree.Count - index;

                Person[] arrCopy = new Person[count];
                familyTree.CopyTo(index, arrCopy, 0, count);

                Person copyPerson = arrCopy.FirstOrDefault(p => p.Name == name || p.BirthDay == birthDay);

                if (copyPerson != null)
                {
                    familyTree.Remove(copyPerson);
                    person.Parents.AddRange(copyPerson.Parents);
                    person.Parents = person.Parents.Distinct().ToList();

                    person.Children.AddRange(copyPerson.Children);
                    person.Children = person.Children.Distinct().ToList();
                }
            }
            command = Console.ReadLine();
        }

        Console.WriteLine(mainPerson);
        Console.WriteLine("Parents:");
        foreach (var parent in mainPerson.Parents)
        {
            Console.WriteLine(parent);
        }

        Console.WriteLine("Children:");
        foreach (var children in mainPerson.Children)
        {
            Console.WriteLine(children);
        }
    }

    private static void SetChild(List<Person> familyTree, Person parent, string child)
    {
        var childPerson = new Person();
        if (IsBirthday(child))
        {
            if (!familyTree.Any(p => p.BirthDay == child))
            {
                childPerson.BirthDay = child;
            }
            else
            {
                childPerson = familyTree.First(p => p.BirthDay == child);
            }
        }
        else
        {
            if (!familyTree.Any(p => p.Name == child))
            {
                childPerson.Name = child;
            }
            else
            {
                childPerson = familyTree.First(p => p.Name == child);
            }
        }
        parent.Children.Add(childPerson);
        childPerson.Parents.Add(parent);
        familyTree.Add(childPerson);
    }

    static bool IsBirthday(string name)
    {
        return char.IsDigit(name[0]);
    }
}

