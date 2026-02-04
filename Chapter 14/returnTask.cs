/* Create a method async Task<int> GetStockPrice().

Inside, wait for 2 seconds (Task.Delay).

Then return 500; (just a raw number).

In Main, call it: int price = await GetStockPrice();. */

using System;

class Program
{
	static async Task Main()
	{
		Console.WriteLine($"Price : {await GetStockPrice()}");
	}

    static async Task<int> GetStockPrice()
    {
        await Task.Delay(2000);
        return 500;
    }
}