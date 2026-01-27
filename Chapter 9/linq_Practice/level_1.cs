/* The Scenario: You are building the checkout page for a store. You need to display the final price for "Budget Items" only.

The Data:

C#
double[] prices = { 15.0, 40.0, 60.0, 10.0, 100.0, 200.0, 35.0 };
The Requirements:

We only care about items that are under $50.00.

For those items, apply a 10% Tax (multiply by 1.1).

Sort them from Lowest to Highest price.

Print the final taxed prices to the console. */

using System;

class Program
{
	static void Main()
	{
		
        double[] prices =  [15.0, 40.0, 60.0, 10.0, 100.0, 200.0, 35.0] ;

        var result = prices.Where(n => n < 50).Select(n => n * 1.1).OrderBy(n => n);

        foreach (double i in result)
        {
            Console.WriteLine(i);
        }
	}
}