/* The Scenario: You have a dataset of numbers 1 to 100. You want to display Page 3, assuming 10 items per page.

The Math:

Page 1: Items 1-10

Page 2: Items 11-20 (We need to skip these)

Page 3: Items 21-30 (This is our target)

Your Goal:

Generate: Use var numbers = Enumerable.Range(1, 100); to create the data instantly.

Query: Chain .Skip(...) and .Take(...) to get only numbers 21 through 30.

Print: Output the result. */

using System;

class Program
{
	static void Main()
	{
		var numbers = Enumerable.Range(1, 100);

        var page3 = numbers.Skip(20).Take(10);

        foreach( int i in page3)
        {
            Console.Write($"{i} ");
        } 
	}
}