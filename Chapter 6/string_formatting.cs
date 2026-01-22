
/* Your Task:

Variables:

string item = "Widget";

double price = 12.50;

double tax = 0.08; (8%)

Print:

Line 1: Item name, right-aligned in a 10-character field. $"Item: {item, 10}"

Line 2: Price formatted as Currency. $"Price: {price:C}"

Line 3: Tax formatted as a Percentage. $"Tax: {tax:P0}" (P0 means percentage with 0 decimal places). */

using System;

class Program
{
	static void Main()
	{
		string item = "Widget";
        double price = 12.50;
        double tax = 0.08;
        int population = 123456;
        Console.WriteLine($"Item : {item, 10}, Price : {price:C}, Tax : {tax:P0}, Population : {population:N0}");
	}	
}