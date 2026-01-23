/* Create: int[] results = { 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 };

Clean: Remove duplicates using .Distinct().

Paginate:

You want Page 2.

Assume 3 items per page.

(Logic: You need to Skip 3 items (Page 1), then Take the next 3).

Print: Output the numbers. (Expected: 4, 5, 6). */

using System;

class Program 
{
	static void Main()
	{
		int[] results = [1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 ];

        var pages = results.Distinct().Skip(3).Take(3);

        string result = String.Join(", ", pages);
        Console.WriteLine( result);
	}	
}