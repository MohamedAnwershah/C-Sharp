/* Concepts: Func<> delegate, Lambda Expressions (=>).

The Scenario: You are building a calculator, but you don't want to write a separate method for every single math operation (Add, Subtract, Multiply, Modulo, etc.). Instead, you want to write one function that can accept any math logic you throw at it.

Your Task:

Create Method: static void RunMath(int a, int b, Func<int, int, int> operation).

This method takes two numbers and a "logic packet" (Func).

Inside, execute the logic: int result = operation(a, b);.

Print the result.

Main Program:

Call RunMath(10, 5, ...) using a Lambda Expression to add them: (x, y) => x + y.

Call RunMath(10, 5, ...) again using a Lambda to multiply them.

Goal: See how you can change the behavior of RunMath without changing its code! */

using System;

class Program
{
	static void Main()
	{
		static int operation(int x, int y) => x + y;
        RunMath(10,2,operation);
	}	

    static void RunMath(int x, int y, Func<int, int, int> operation)
    {
        int result = operation(x, y);
        Console.WriteLine(result);
    }
}