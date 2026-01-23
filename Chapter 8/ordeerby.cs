
/* Create Array: string[] names = { "Zara", "Alex", "Ben", "Charlie" };

Query:

Filter names that are longer than 3 letters (n.Length > 3).

Sort them alphabetically.

Print: Output the result (Should be "Alex, Charlie, Zara"). */

using System;

class Program
{
	static void Main()
	{
        string[] names = ["Zara", "Alex", "Ben", "Charlie"];

        var filtered = names.Where(n => n.Length > 3).OrderBy(n => n.Length).ThenBy(n => n); //can chain multiple queries (first one is important fs)

        foreach(string name in filtered)
        {
            Console.WriteLine(name);
        }

	}	
}

