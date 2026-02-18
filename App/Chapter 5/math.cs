/* Constants: Radius = 2.5, Height = 10.0.

Calculate Volume: Formula is π×r 
2
 ×h.

Constraint: You MUST use Math.PI and Math.Pow.

Calculate Cost: The material costs $55.25 per cubic unit.

Calculate Total Cost (Volume * Cost).

Print Report:

Print Volume rounded to 4 decimal places using Math.Round.

Print Total Cost formatted as Currency using the :C format string.

Print the Computer Name running this job using Environment.MachineName. */

using System;

class Program
{
	static void Main()
	{
		double radius = 2.5;
        double height = 10.0;
        double cost = 55.25;

        static double Volume(double x, double y) => Math.PI * Math.Pow(x, 2) * y;

        double volume = Volume(radius, height);

        double total = volume * cost;

        Console.WriteLine($"Volume : {Math.Round(volume, 4)}");

        Console.WriteLine($"Total cost : {total:C}");

        Console.WriteLine($"Computer : {Environment.MachineName}");


    }
    

}
