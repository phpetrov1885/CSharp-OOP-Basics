using System;
using System.Collections.Generic;
using System.Text;


class Car
{
    private string carModel;
    private string carSpeed;

    public Car(string carModel, string carSpeed)
    {
        CarModel = carModel;
        CarSpeed = carSpeed;
    }
    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }
    public string CarSpeed
    {
        get { return carSpeed; }
        set { carSpeed = value; }
    }

    public override string ToString()
    {
        return $"{this.carModel} {this.carSpeed}";
    }
}

