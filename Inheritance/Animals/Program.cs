using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string animal = Console.ReadLine();
        List<Animal> animals = new List<Animal>();

        while (animal != "Beast!")
        {
            try
            {
                ReadAndCreateAnimal(animals, animal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            animal = Console.ReadLine();
        }
        
        foreach (var animall in animals)
        {
            Console.WriteLine(animall);
        }
    }

    private static void ReadAndCreateAnimal(List<Animal> animals, string animal)
    {
        string[] animalArgs = Console.ReadLine().Split();
        string animalName = animalArgs[0];
        int animalAge = int.Parse(animalArgs[1]);
        string animalGender = animalArgs[2];

        switch (animal)
        {
            case "Cat":
                Cat cat = new Cat(animalName, animalAge, animalGender);
                animals.Add(cat);
                break;
            case "Frog":
                Frog frog = new Frog(animalName, animalAge, animalGender);
                animals.Add(frog);
                break;
            case "Dog":
                Dog dog = new Dog(animalName, animalAge, animalGender);
                animals.Add(dog);
                break;
            case "Kitten":
                Kitten kitten = new Kitten(animalName, animalAge);
                animals.Add(kitten);
                break;
            case "Tomcat":
                Tomcat tomcat = new Tomcat(animalName, animalAge);
                animals.Add(tomcat);
                break;
            default:
                throw new ArgumentException("Invalid input!");
        }

    }
}

