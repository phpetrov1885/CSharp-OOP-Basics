using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string carModel;
    private decimal fuelAmount;
    private decimal fuelConsumptionPerKM;
    private decimal distanceTraveled;

    public Car(string carModel, decimal fuelAmount, decimal fuelConsumptionPerKM)
    {
        CarModel = carModel;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKM = fuelConsumptionPerKM;
    }

    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }
    public decimal FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }
    public decimal FuelConsumptionPerKM
    {
        get { return fuelConsumptionPerKM; }
        set { fuelConsumptionPerKM = value; }
    }
    public decimal DistanceTraveled
    {
        get { return distanceTraveled; }
        set { distanceTraveled = value; }
    }

    public void GetDistanceTravelled(decimal amountOfKm)
    {
        if (amountOfKm * fuelConsumptionPerKM > fuelAmount)
        {
            Console.WriteLine($"Insufficient fuel for the drive");
        }
        else
        {
            fuelAmount -= amountOfKm * fuelConsumptionPerKM;
            distanceTraveled += amountOfKm;
        }
    }
}

