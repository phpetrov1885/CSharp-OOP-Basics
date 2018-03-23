using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            SplitCarSpecsAndAddCar(cars);
        }

        string command = Console.ReadLine();

        var filteredCars = GetProperCars(command, cars);

        foreach (var car in filteredCars)
        {
            Console.WriteLine(car.Model);
        }

    }

    private static List<Car> GetProperCars(string command, List<Car> cars)
    {

        if (command == "fragile")
        {
            cars = cars
                .Where(t => t.Cargo.CargoType == "fragile" && t.Tires.Any(s=>s.Pressure<1))
                 .ToList();
            
        }
        if (command == "flamable")
        {
            cars = cars.Where(t => t.Cargo.CargoType == "flamable"
                                                           && t.Engine.EnginePower > 250)
                 .ToList();
        }

        return cars;
    }

    private static void SplitCarSpecsAndAddCar(List<Car> cars)
    {
        string[] splitInput = Console.ReadLine().Split();

        //model and engine
        string model = splitInput[0];
        int engineSpeed = int.Parse(splitInput[1]);
        int enginePower = int.Parse(splitInput[2]);
        Engine engine = new Engine(model, engineSpeed, enginePower);

        //cargo
        int cargoWeight = int.Parse(splitInput[3]);
        string cargoType = splitInput[4];
        Cargo cargo = new Cargo(cargoWeight, cargoType);

        //creating tire 1
        double tireOnePressure = double.Parse(splitInput[5]);
        int tireOneAge = int.Parse(splitInput[6]);
        Tire firstTire = new Tire(tireOnePressure, tireOneAge);

        //creating tire 2
        double tireTwoPressure = double.Parse(splitInput[7]);
        int tireTwoAge = int.Parse(splitInput[8]);
        Tire secondTire = new Tire(tireTwoPressure, tireTwoAge);

        //creating tire 3
        double tireThreePressure = double.Parse(splitInput[9]);
        int tireThreeAge = int.Parse(splitInput[10]);
        Tire thirdTire = new Tire(tireThreePressure, tireThreeAge);

        //creating tire 4
        double tireFourPressure = double.Parse(splitInput[11]);
        int tirefourAge = int.Parse(splitInput[12]);
        Tire fouthTire = new Tire(tireFourPressure, tirefourAge);
        
        List<Tire> tires = new List<Tire>(4) { firstTire, secondTire, thirdTire, fouthTire };
        Car car = new Car(model, engine, cargo, tires);
        cars.Add(car);
    }
}

