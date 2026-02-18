// using System;

// class Program
// {
//     static int _counter = 0;
//     static async Task Main()
//     {
//         Task task1 = Task.Run(() => Count());
//         Task task2 = Task.Run(() => Count());

//         Task.WhenAll(task1, task2);
//         Console.WriteLine($"Result : {_counter}");
//     }
//     static void Count()
//     {
//         for (int i = 1; i < 10000; i++)
//         {
//             _counter++;
//         }
        
//     }
// }

using System;

class Program
{
    static int _counter = 0;
    readonly static object _key = new();
    static async Task Main()
    {
        Task task1 = Task.Run(() => Count());
        Task task2 = Task.Run(() => Count());

        await Task.WhenAll(task1, task2);
        Console.WriteLine($"Result : {_counter}");
    }
    static void Count()
    {
        for (int i = 1; i < 10000; i++)
        {
            lock (_key)
            {
                _counter++;
            }
            
        }
        
    }
}