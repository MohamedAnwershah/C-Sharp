
/* Modify GetStockPrice to accept a delay integer so we can rig the race.

async Task<string> GetData(string serverName, int delay) (Return string this time, e.g., "Data from US").

In Main, start two tasks:

Task<string> fast = GetData("Fast Server", 1000);

Task<string> slow = GetData("Slow Server", 5000);

Use Task<string> winner = await Task.WhenAny(fast, slow);

Print the result of the winner (await winner). */

using System;

class Program
{
	static async Task Main()
	{
		Task<int> serverA = DonwloadA();
        Task<int> serverB = DonwloadB();

        var result = await Task.WhenAny(serverA, serverB);
        Console.WriteLine($"Result {await result}");
	}
    static async Task<int> DonwloadA()
    {
        Console.WriteLine("server 1 started");
        await Task.Delay(1000);
        Console.WriteLine("Server 1 Completed!");
        return 100;
    }
    static async Task<int> DonwloadB()
    {
        Console.WriteLine("server 2 started");
        await Task.Delay(2000);
        Console.WriteLine("Server 2 Completed!");
        return 100;
    }
}