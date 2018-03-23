using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int numberCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberCars; i++)
        {
            ReadCarSpecsAndAddCar(cars);
        }

        string driveInput = Console.ReadLine();
        while (driveInput != "End")
        {
            SplitCommandAndTakeCar(driveInput, cars);

            driveInput = Console.ReadLine();
        }
        PrintFuelAmountAndDistance(cars);
    }

    private static void SplitCommandAndTakeCar(string driveInput, List<Car> cars)
    {
        string[] splitInput = driveInput.Split();
        string carModel = splitInput[1];
        decimal amountOfKm = decimal.Parse(splitInput[2]);

        if (splitInput[0] == "Drive")
        {
            cars.Where(c => c.CarModel == carModel).First().GetDistanceTravelled(amountOfKm);
        }
    }

    private static void ReadCarSpecsAndAddCar(List<Car> cars)
    {
        string[] splitInput = Console.ReadLine().Split();
        string carModel = splitInput[0];
        decimal amountOfFuel = decimal.Parse(splitInput[1]);
        decimal fuelConsumption = decimal.Parse(splitInput[2]);

        var car = new Car(carModel, amountOfFuel, fuelConsumption);
        cars.Add(car);
    }


    private static void PrintFuelAmountAndDistance(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.CarModel} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }
    }
}

