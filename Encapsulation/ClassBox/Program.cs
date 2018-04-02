using System;


class Program
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double widht = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Box box;

        try
        {
            box = new Box(lenght, widht, height);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
        Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():f2}");
        Console.WriteLine($"Volume - {box.GetVolume():f2}");
    }
}

