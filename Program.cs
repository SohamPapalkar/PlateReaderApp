using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: app <Wavelength> <WaitTime> <Output>");
            return;
        }

        int wavelength = int.Parse(args[0]);
        int waitTime = int.Parse(args[1]);
        int outputMode = int.Parse(args[2]);

        var wlHandler = new WavelengthHandler();
        if (!wlHandler.SelectWavelength(wavelength))
        {
            Console.WriteLine("Wavelength not found. Exiting.");
            return;
        }

        var waitHandler = new WaitHandler(waitTime);
        var outputHandler = new OutputHandler(outputMode);
        var plateReader = new PlateReaderController();

        plateReader.Connect();
        waitHandler.Wait("Check if plate is inserted and remove it.");

        plateReader.Calibrate(wlHandler.SelectedWavelength);
        waitHandler.Wait("Please insert the plate.");

        double[,] readings = plateReader.ReadPlate();
        outputHandler.DisplayData(readings);

        plateReader.Exit();
    }
}
