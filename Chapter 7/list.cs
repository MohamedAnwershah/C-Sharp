/* Create: List<string> tasks = new();

Add: Add "Code", "Sleep", and "Repeat".

Remove: Remove "Sleep".

Count: Print the number of items left.

Loop: Print the remaining items using foreach. */

using System;

class Program
{
	static void Main()
	{
		List<string> tasks = ["Code", "Sleep", "Repeat"];


        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
	}	
}