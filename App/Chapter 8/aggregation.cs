
/* Create: int[] scores = { 45, 92, 78, 60, 88, 30 };

Calculate:

Find the Highest score.

Find the Lowest score.

Count how many scores are Passing (assume >= 50).

Print: Output the stats nicely. */


using System;

class Program
{
	static void Main()
	{
		int[] scores = [ 45, 92, 78, 60, 88, 30 ];

        var max = scores.Max();
        var min = scores.Min();
        int passingCount = scores.Count(n => n > 50);
        Console.WriteLine($"Maximum : {max}, Minimum : {min}, Passed : {passingCount}");
	}	
}