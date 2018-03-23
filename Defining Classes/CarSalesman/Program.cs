using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();
        int enginesInput = int.Parse(Console.ReadLine());

        for (int i = 0; i < enginesInput; i++)
        {
            ReadEngineAndAddToList(engines);
        }

        int carInput = int.Parse(Console.ReadLine());
        for (int i = 0; i < carInput; i++)
        {
            ReadCarAndAddToList(engines, cars);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static void ReadCarAndAddToList(List<Engine> engines, List<Car> cars)
    {
        string[] currentCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string carModel = currentCar[0];

        Engine carEngine = engines.Where(e => e.Model == currentCar[1]).FirstOrDefault();
        int weightInput;
        string color = "n/a";
        Car car = new Car(carModel,carEngine);

        if (currentCar.Length == 4)
        {
            car.Weight = currentCar[2];
            car.Color = currentCar[3];
        }
        else if (currentCar.Length == 3)
        {
            bool isDigit = int.TryParse(currentCar[2], out weightInput);
            if (!isDigit)
            {
                car.Color = currentCar[2];
            }
            else
            {
                car.Weight = currentCar[2];
            }
        }
         cars.Add(car);
    }

    private static void ReadEngineAndAddToList(List<Engine> engines)
    {
        string[] currentEngine = Console.ReadLine().Split();
        string engineModel = currentEngine[0];
        string enginePower = currentEngine[1];

        Engine engine =new Engine(engineModel,enginePower);
        int engineDisplacementInput = 0;
        string engineEfficiency = "n/a";


        if (currentEngine.Length == 4)
        {
            engine.Displacement = currentEngine[2];
            engine.Efficiency = currentEngine[3];
        }
        else if (currentEngine.Length == 3)
        {
            bool isDigit = int.TryParse(currentEngine[2], out engineDisplacementInput);
            if (!isDigit)
            {
                engine.Efficiency = currentEngine[2];
            }
            else
            {
                engine.Displacement = currentEngine[2];
            }
        }
       
        engines.Add(engine);
    }


}

