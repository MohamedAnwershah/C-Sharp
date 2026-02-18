
/* The Scenario: You have a list of numbers. You want only the ones that are greater than 10.

The Syntax: LINQ uses "Lambda Expressions" (n => ...).

Read n => n > 10 as: "Given a number 'n', keep it if 'n' is greater than 10."

Your Task:

Add Namespace: using System.Linq; (Crucial!).

Create List: int[] numbers = { 5, 12, 8, 20, 3, 15 };.

Query:

C#
// "Where" returns an "IEnumerable", so we usually convert it .ToList() or .ToArray() immediately.
var bigNumbers = numbers.Where(n => n > 10).ToArray();
Print: Use string.Join to print them nicely in one line: Console.WriteLine(string.Join(", ", bigNumbers)); */


using System;
using System.Data;

class Program
{
	static void Main()
	{
		int[] nums = [5, 12, 8, 20, 3, 15];

        var largeNums = nums.Where(n => n > 10).ToArray();
        foreach (int num in largeNums)
        {
            Console.WriteLine(num);
        }

        string num_str = String.Join(", ",largeNums);
        Console.WriteLine(num_str);
	}	
}