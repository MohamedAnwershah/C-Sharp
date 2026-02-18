using System;

class Program
{
	static void Main()
	{
		Console.WriteLine(Multiply(10, 20));
	}	

/// <summary>
/// Multiply two numbers
/// </summary>
/// <param name="x">The first number</param>
/// <param name="y">The second number</param>
/// <returns>The product of x and y</returns>
    static int Multiply(int x, int y)
    {
        return x * y;
    }
}