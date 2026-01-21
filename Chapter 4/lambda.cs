using System;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

class Program
{
	static void Main()
    {
		Action<int, int> operation = (x, y) => Console.WriteLine($"Sum of {x} & {y} = {x + y}");

        operation += (x, y) => Console.WriteLine($"Product of {x} & {y} = {x * y}");

        operation(10, 5);
	}	
    
}



