using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Person> persons = new Dictionary<string, Person>();
        string[] input = Console.ReadLine().Split();

        while (input[0] != "End")
        {
            string name = input[0];
            string subject = input[1];

            if (!persons.ContainsKey(name))
            {
                Person person = new Person();
                person.Name = name;

                persons.Add(name, person);
            }

            switch (subject)
            {
                case "company":
                    AddCompanyArgs(input, persons[name]);
                    break;
                case "pokemon":
                    AddPokemonargs(input, persons[name]);
                    break;
                case "parents":
                    AddParentsArgs(input, persons[name]);
                    break;
                case "children":
                    AddChildsArgs(input, persons[name]);
                    break;
                case "car":
                    AddCarArgs(input, persons[name]);
                    break;
            }

            input = Console.ReadLine().Split();
        }

        string personToPrint = Console.ReadLine();
        Console.WriteLine(persons[personToPrint]);
    }

    private static void AddCarArgs(string[] input, Person person)
    {
        string model = input[2];
        string carSpeed = input[3];
        Car car = new Car(model, carSpeed);
        person.Car = car;
    }

    private static void AddChildsArgs(string[] input, Person person)
    {
        string childName = input[2];
        string childBirthDate = input[3];
        Child child = new Child(childName, childBirthDate);
        person.Childs.Add(child);
    }

    private static void AddParentsArgs(string[] input, Person person)
    {
        string parentName = input[2];
        string parentBirthDate = input[3];
        Parent parent = new Parent(parentName, parentBirthDate);
        person.Parents.Add(parent);
    }

    private static void AddPokemonargs(string[] input, Person person)
    {
        string pokemonName = input[2];
        string pokemonType = input[3];
        Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
        person.Pokemons.Add(pokemon);
    }

    private static void AddCompanyArgs(string[] input, Person person)
    {
        string companyName = input[2];
        string companyDepartment = input[3];
        decimal salary = decimal.Parse(input[4]);
        Company company = new Company(companyName, companyDepartment, salary);
        person.Company = company;
    }
}

