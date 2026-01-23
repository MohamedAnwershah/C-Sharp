/* Create: SortedDictionary<string, int> scores = new();

Add (Mixed Order):

Add "Zara", score 50.

Add "Alex", score 90.

Add "Ben", score 70.

Loop: Use foreach to print the names and scores.

Observation: Notice that even though you added "Zara" first, "Alex" will print first. */

using System;

class Program
{
	static void Main()
	{
		SortedDictionary<string, int> scores = new()
        {
            {"shah", 90},
            {"nawf", 90},
            {"irfan", 90}
        };

        foreach (string name in scores.Keys)
        {
            Console.WriteLine($"{name} : {scores[name]}");
        }
        
	}	
}