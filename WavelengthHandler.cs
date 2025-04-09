public class WavelengthHandler
{
    public int SelectedWavelength { get; private set; }

    public bool SelectWavelength(int input)
    {
        if (input == 0)
        {
            if (DeviceHasWavelength(425)) SelectedWavelength = 425;
            else if (DeviceHasWavelength(450)) SelectedWavelength = 450;
            else return false;
        }
        else
        {
            if (DeviceHasWavelength(input))
                SelectedWavelength = input;
            else return false;
        }
        return true;
    }

    private bool DeviceHasWavelength(int wavelength)
    {
        return (wavelength == 425 || wavelength == 450 || wavelength == 500);
    }
}
