
/* Filter: Use .OfType<string>() to get only the names.

Sort: Order the names alphabetically (optional, but good habit).

Print: "Alice", "Bob", "Charlie". */

using System;

class Program
{
	static void Main()
	{
		object[] mixedData = { 
            "Alice", 
            42, 
            "Bob", 
            true, 
            "Charlie", 
            100 
        };
        var names = mixedData.OfType<string>();
        foreach(string i in names)
        {
            Console.WriteLine(i);
        }
	}
}