
/* Create: CancellationTokenSource cts = new();

Pass: Send cts.Token into your heavy method.

Check: Inside the loop, run token.ThrowIfCancellationRequested();. */

using System;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource cts = new();
        Task<long> heavyTask = Task.Run(() => CalculateSum(cts.Token));
        cts.CancelAfter(2000);
        try
        {

            long result = await heavyTask;
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static long CalculateSum(CancellationToken token)
    {
        long total = 0;
        
        for (long i = 0; i <= 2_000_000_000_000_000; i++)
        {
            if(i % 1000 == 0)
            {
                token.ThrowIfCancellationRequested();
            }
            total += i;
        }
        return total;
    }
}