using System;

class Program
{
	static void Main()
	{
		Calculator.SafeDivide(10,0);
        Console.WriteLine("Program continues..");
	}
    
}

class Calculator
{
    public static void SafeDivide (int x, int y){
        try
        {
            Console.WriteLine($"Result : {x/y}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error! cannot divide by zero");
        }
    }
}