/* Print "Starting calculation...".

Use Task.Run to run that method in the background: Task<long> heavyTask = Task.Run(() => CalculateSum());

While the task is running, print a dot . every 200ms. (This proves the Main thread is free to update the UI!).

Await the result and print the sum. */

using System;

class Program
{
    static bool isRunning = true;
	static async Task Main()
	{
		Console.WriteLine("Starting Calculation!");

        Task.Run(() => CalculateSum());

        while (isRunning)
        {
            Thread.Sleep(200);
            Console.Write(". ");
        }
	}
    static async Task CalculateSum()
    {
        await Task.Delay(3000);
        Console.WriteLine("200");
        isRunning = false;
    }

}