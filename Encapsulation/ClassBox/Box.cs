using System;
using System.Collections.Generic;
using System.Text;


class Box
{
    private double lenght;
    private double widht;
    private double height;

    public Box()
    {
        
    }
    public Box(double lenght, double widht, double height)
    {
        Lenght = lenght;
        Widht = widht;
        Height = height;
    }
    protected double Lenght
    {
        get { return lenght; }
        set
        {
            ParametersValidation(value,"Length");
            lenght = value;
        }
    }
    protected double Widht
    {
        get { return widht; }
        set
        {
            ParametersValidation(value, "Width");
            widht = value;
        }
    }
    protected double Height
    {
        get { return height; }
        set
        {
            ParametersValidation(value, "Height");
            height = value;
        }
    }

    protected void ParametersValidation(double currentValue, string parameter)
    {
        if (currentValue <= 0)
        {
            throw new ArgumentException($"{parameter} cannot be zero or negative. ");
        }
    }

    public double GetVolume()
    {
        return lenght * widht * height;
    }
    public double GetLateralSurfaceArea()
    {
        return 2 * (lenght * height) + 2 * (widht * height);
    }
    public double GetSurfaceArea()
    {
        return 2 * (lenght * widht) + 2 * (lenght * height) + 2 * (widht * height);
    }
}

