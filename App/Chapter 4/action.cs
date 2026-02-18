using System;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

class Program
{
	static void Main()
    {
		Action<int, int> operation = Add;
        operation += Multiply;

        operation(10, 5);
	}	
    static void Add(int x, int y)
    {
        Console.WriteLine($"Sum of {x} & {y} = {x + y}");
    }
    static void Multiply(int x, int y)
    {
        Console.WriteLine($"Product of {x} & {y} = {x * y}");
    }
}



