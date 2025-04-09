using System;
using System.Threading;

public class WaitHandler
{
    private int waitSeconds;

    public WaitHandler(int waitSeconds)
    {
        this.waitSeconds = waitSeconds;
    }

    public void Wait(string message)
    {
        if (waitSeconds == 0)
        {
            Console.WriteLine(message + " Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(message + $" Waiting {waitSeconds} seconds...");
            Thread.Sleep(waitSeconds * 1000);
        }
    }
}
