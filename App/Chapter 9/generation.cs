/* Generate: Use Range to create numbers from 1 to 5.

Transform: Use .Select to calculate the square (n * n) of each number.

Print: Loop through and print them. */


using System;

class Program
{
	static void Main()
	{
		var nums = Enumerable.Range(1, 6);

        var square = nums.Select(n => n*n);

        foreach(int num in square)
        {
            Console.WriteLine(num);
        }
	}
}
