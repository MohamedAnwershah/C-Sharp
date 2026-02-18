using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static int _pepperoniStock = 100;

    static SemaphoreSlim _gate = new(1,1);

    static async Task Main()
    {
        Console.WriteLine("--- 🍕 PIZZA SHOP TRAINING MODE ---");

        CancellationTokenSource cts = new();
        cts.CancelAfter(5000);
        var token = cts.Token;

        
        var report = new Progress<string>(p => {Console.Clear(); Console.WriteLine(p);});


        try
        {
            Console.WriteLine("Starting Orders...");

            Task t1 = CookPizza("Pepporoni", token, report);
            Task t2 = CookPizza("Pepporoni", token, report);
            Task t3 = CookPizza("Pepporoni", token, report);
            
            await Task.WhenAll(t1, t2, t3);
            
            Console.WriteLine("\n✅ All orders served!");
        }
        catch (OperationCanceledException ex)
        {

            Console.WriteLine(ex.Message);
        }
        finally
        {

            cts.Dispose();
        }
    }

    static async Task CookPizza(string name, CancellationToken token, IProgress<string> reporter)
    {
        await Task.Run(async () => {
            await _gate.WaitAsync();
            
            try
            {
                if (_pepperoniStock >= 10)
                {
                    _pepperoniStock -= 10;
                    Console.WriteLine("Grabbed Pepporoni!");
                }
                else
                {
                    Console.WriteLine("Out of Stock!");
                }
                    
                
               
            }
            finally
            {
                _gate.Release();
            }


            
            for (int i = 0; i <= 100; i += 20)
            {
                token.ThrowIfCancellationRequested();
                await Task.Delay(1);
                
            }

            reporter.Report($"✨ {name} is READY!");
        });
            
            
    }
}