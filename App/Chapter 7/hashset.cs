
/* Create: HashSet<string> coupons = new();

Add: Add "SAVE10", "FREESHIP", and "SAVE10" (again).

Count: Print $"Coupons count: {coupons.Count}". (Expect: 2).

Loop: Print the coupons to prove "SAVE10" only appears once. */

using System;

class Program
{
	static void Main()
	{
		HashSet<string> setNames = ["Shah", "Nawf", "Shah"];

        Console.WriteLine(setNames.Count);
        foreach(string name in setNames)
        {
            Console.WriteLine(name);
        }
	}	
}