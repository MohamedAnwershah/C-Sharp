using System;

class Program
{
    static int _counter = 0;
    static SemaphoreSlim _gate = new(1, 1);
    static async Task Main()
    {
        Task task1 = Count();
        Task task2 = Count();

        await Task.WhenAll(task1, task2);
        Console.WriteLine($"Result : {_counter}");
    }
    static async Task Count()
    {

        for (int i = 0; i < 1000; i++)
        {
            await _gate.WaitAsync();

            try
            {   
                int temp = _counter;
                await Task.Delay(1);
                _counter = temp + 1;
            }
            finally
            {
                _gate.Release();
            }
            
        }
        
    }
}