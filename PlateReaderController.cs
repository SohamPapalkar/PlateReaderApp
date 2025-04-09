using System;

public class PlateReaderController
{
    public void Connect()
    {
        Console.WriteLine("Connecting to first available plate reader...");
    }

    public void Calibrate(int wavelength)
    {
        Console.WriteLine($"Calibrating plate reader to wavelength {wavelength}...");
    }

    public double[,] ReadPlate()
    {
        Console.WriteLine("Reading plate...");
        double[,] data = new double[8, 12];
        var rand = new Random();
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 12; j++)
                data[i, j] = rand.NextDouble() * 10;
        return data;
    }

    public void Exit()
    {
        Console.WriteLine("Shutting down plate reader...");
    }
}
