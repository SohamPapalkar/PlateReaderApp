using System;
using System.IO;
using System.Text;

public class OutputHandler
{
    private int mode;

    public OutputHandler(int mode)
    {
        this.mode = mode;
    }

    public void DisplayData(double[,] data)
    {
        string formatted = FormatData(data);

        if (mode == 0 || mode == 2)
            Console.WriteLine(formatted);

        if (mode == 1 || mode == 2)
            File.WriteAllText("output.txt", formatted);
    }

    private string FormatData(double[,] data)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                sb.Append(Math.Round(data[i, j], 4).ToString("F4") + "\t");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
