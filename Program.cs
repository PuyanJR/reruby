using System;
using System.Diagnostics;
using System.Threading;


partial class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Universal Currency Generator! (UCG) by MirkoKING https://youtube.com/c/MirkoKING");
        Thread.Sleep(1000);
        Console.WriteLine("Searching for updates...");
        Thread.Sleep(5000);
        Console.WriteLine("Running latest version! 4.8.5");
        Console.WriteLine("Waiting for RobloxPlayerBeta.exe...");

        while (true)
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            // Some systems use "RobloxPlayerBeta" instead of "roblox"

            if (processes.Length > 0)
            {
                Console.WriteLine("Roblox started!");
                // Continue your program here
                break;
            }

            Thread.Sleep(500); // reduce CPU usage
        }

        // Continue your program logic here...
        Console.WriteLine("Program is continuing...");
    }
}

