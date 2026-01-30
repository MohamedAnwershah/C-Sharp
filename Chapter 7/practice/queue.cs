using System;

class Program
{
	static void Main()
	{
		List<string> list = ["Alice", "Bob", "Charlie"];
        Queue<string> names = new(list);
        while (names.Count > 0)
        {
            string curr = names.Dequeue();
            Console.WriteLine($"Helping : {curr}");
            Thread.Sleep(2000);
            Console.WriteLine("Moving to next customer!");
        }
        if (names.Count == 0)
        {
            Console.WriteLine($"Queue is empty!");
        }
	}

}
