using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CarSalesman
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();
        int engineCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < engineCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            AddEngineToColelection(parameters, engines);        }
        int carCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            AddCarToCollection(parameters,cars,engines); 
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static void AddEngineToColelection(string[] specs, List<Engine> engines)
    {
        Engine engine = new Engine(specs[0],int.Parse(specs[1]));
        engine.efficiency = "n/a";
        
        if (specs.Length == 4)
        {
            engine.Displacement =int.Parse(specs[2]);
            engine.Efficiency = specs[3];
        }
        else if (specs.Length == 3)
        {
            int engineDisplacement = 0;
            if (!IsDigit(specs[2] ,engineDisplacement))
            {
                engine.Efficiency = specs[2];
            }
            else
            {
                engine.Displacement =int.Parse(specs[2]);
            }
        }
        engines.Add(engine);
    }

    private static void AddCarToCollection(string[] parameters, List<Car> cars, List<Engine> engines)
    {
        Engine carEngine = engines.Where(e => e.Model == parameters[1]).FirstOrDefault();
        Car car = new Car(parameters[0],carEngine);
        car.color = "n/a";
       
        if (parameters.Length == 4)
        {
            car.Weight =int.Parse(parameters[2]);
            car.Color = parameters[3];
        }
        else if (parameters.Length == 3)
        {
            int weight = 0;
            if (!IsDigit(parameters[2], weight))
            {
                car.Color = parameters[2];
            }
            else
            {
                car.Weight =int.Parse(parameters[2]);
            }
        }
        cars.Add(car);
    }

    private static bool IsDigit(string givenSpecs, int returnSpecs)
    {
        return int.TryParse(givenSpecs, out returnSpecs);
    }
}


