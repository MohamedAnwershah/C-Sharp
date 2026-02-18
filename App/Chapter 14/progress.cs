
/* In Main: Create a var progress = new Progress<int>(p => ...) handler. inside the =>, print the percentage.

The Worker: Add a parameter IProgress<int> progress.

Inside Loop: Calculate the percentage. call progress.Report(percent). */

using System;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting calculation!");

        var waiter = new Progress<int>(p => {
            Console.Clear();
            Console.WriteLine($"Progress : {p}%");
        } );

        await Task.Run(() => Chopping(waiter));
        Console.Clear();
        // Thread.Sleep(100);
        Console.WriteLine("Dinner is Served!");
    }

    static void Chopping(IProgress<int> waiter)
    {
        for ( int i = 0; i <= 100; i++)
        {
            Thread.Sleep(50);
            waiter.Report(i);
        }
        
    }
}