
/* Create: int[] numbers = { 2, 4, 6, 8 };

Transform: Use .Select() to convert these numbers into strings following this format: "Number: 2", "Number: 4", etc.

Print: Loop through the new list of strings and print them. */

using System;

class Program
{
	static void Main()
	{
		int[] nums = [1, 2, 3, 4, 5];

        var squared_nums = nums.Select(n => n * n).ToList();

        Console.WriteLine(squared_nums.GetType());
        foreach(int num in squared_nums)
        {
            Console.WriteLine(num);
        }

        int[] numbers = [2, 4, 6, 8];

        var numbers_strings = numbers.Select(n => $"Number : {n}").ToList();

        foreach(string snum in numbers_strings)
        {
            Console.WriteLine(snum);
        }
	}	
}