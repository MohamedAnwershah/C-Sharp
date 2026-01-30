using System;

class Program
{
	static void Main()
	{
		List<string> list = ["Google", "Safari", "Code"];

        Stack<string> printer = new(list);
        while (printer.Count > 0)
        {
            string curr = printer.Pop();
            Console.WriteLine($"Printing : {curr}...");
            Thread.Sleep(2000);
            Console.WriteLine("Done printing.");
            Thread.Sleep(1000);
        }
        if(printer.Count == 0)
        {
            Console.WriteLine("Printing Completed, empty now!");
        }
	}

}
