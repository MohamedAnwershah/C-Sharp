/* Modify GetStockPrice to accept a string name (e.g., "Apple") so you can print which one is running.

In Main, start both tasks, but DO NOT AWAIT THEM YET.

Task<int> appleTask = GetStockPrice("Apple");

Task<int> googleTask = GetStockPrice("Google");

Now await them together:

int[] results = await Task.WhenAll(appleTask, googleTask);

Print the results. */

using System;
using System.Diagnostics;
using System.Threading;

class Program
{
	static async Task Main()
	{
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
		Task<int> apple = GetStockPrice("Apple");
        Task<int> google = GetStockPrice("Google");
        
        var result = await Task.WhenAll(apple, google);

        stopwatch.Stop();

        TimeSpan ts = stopwatch.Elapsed;

        Console.WriteLine($"Seconds : {ts.Seconds}:{ts.Milliseconds}");
        foreach(int i in result)
        {
            Console.WriteLine(i);
        }
	}
    static async Task<int> GetStockPrice(string name)
    {
        Console.WriteLine($"Stock : {name}");
        await Task.Delay(2000);
        return 100;
    }
}