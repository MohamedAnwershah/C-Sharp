
/* The Worker: A method that counts to 2 Billion. (This is hard work!).

The UI: The Main method will print a dot . every 200ms to prove it is still alive. */

using System;

class program
{
    static async Task Main()
    {
        Random random = new();
        Console.WriteLine("Starting Calculation");

        Task<long> heavyTask = Task.Run(() => CalculateSum());
        while (!heavyTask.IsCompleted)
        {
            Console.Write(". ");
            var val = random.Next(50, 500);
            await Task.Delay(val);
        }
        long result = await heavyTask;
        Console.WriteLine($"\nResult: {result}");     
    }
    static long CalculateSum()
    {
        long total = 0;
        for (long i = 0; i <= 2_000_000_000_000_000_000; i++)
        {
            total += i;
        }
        return total;
    }
}