using System;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

class Program
{
	static void Main()
    {
		MathOp add = Add;
        add(10, 5);

        MathOp multiply = Multiply;
        multiply(10, 5);
	}	
    public delegate void MathOp(int x, int y);

    static void Add(int x, int y)
    {
        Console.WriteLine($"Sum of {x} & {y} = {x + y}");
    }
    static void Multiply(int x, int y)
    {
        Console.WriteLine($"Product of {x} & {y} = {x * y}");
    }
}



