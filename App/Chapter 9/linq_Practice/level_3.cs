/* The Scenario: You are analyzing raw order data from a store. The data is messy—it comes in as strings of comma-separated items (CSV format). You need to find out which specific item sold the most units.

The Data:

C#
string[] orders = {
    "iphone,macbook,airpods",
    "samsung,pixel",
    "iphone,pixel",
    "macbook,iphone,airpods",
    "airpods,pixel"
};
The Requirements:

Parse & Flatten: First, you need to split the strings by comma ',' and flatten them so you have a huge list of individual items (e.g., "iphone", "macbook", "samsung"...).

Count: Group them to count how many times each item appears.

Sort: Order the groups so the most popular item is at the top.

Print: Print the result (e.g., iphone: 3 sold, pixel: 3 sold, etc.).

Hint: You will need to chain: .SelectMany(...).GroupBy(...).OrderByDescending(...). */

using System;

class Program
{
	static void Main()
	{
		string[] orders = [
            "iphone,macbook,airpods",
            "samsung,pixel",
            "iphone,pixel",
            "macbook,iphone,airpods",
            "airpods,pixel"
            ];

        var result = orders.SelectMany(n => n.Split(',')).GroupBy(n => n).OrderByDescending(n => n.Count());

        foreach ( var i in result)
        {
            Console.WriteLine($"{i.Key} sold : {i.Count()}");
        }
	}
}