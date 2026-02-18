/* Data: string[] names = { "Alice", "Bob", "Charlie" };

Logic: Use .Aggregate(...) to combine them.

Hint: (current, next) => current + ", " + next

Print: The final string. */

using System;

class Program
{
	static void Main()
	{
		string[] names = ["Alice", "Bob", "Charlie"];
        var result = names.Aggregate((x, y) => $"{x} , {y}");
        Console.WriteLine(result);
	}
}