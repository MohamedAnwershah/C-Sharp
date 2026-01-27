/* The Scenario: You are looking at a messy server log. You need to summarize what users are doing on the site.

The Data:

C#
string[] logs = { 
    "Login", 
    "ViewProduct", 
    "ViewProduct", 
    "Login", 
    "Logout", 
    "ViewProduct", 
    "Login", 
    "AddToCart" 
};
The Requirements:

I need a summary report that lists Unique Actions and How many times each occurred.

The output should look something like:

Login: 3

ViewProduct: 3

Logout: 1 ...etc.

(Optional bonus: Order the list so the most frequent actions appear at the top). */


using System;

class Program
{
	static void Main()
	{
		string[] logs = [
            "Login", 
            "ViewProduct", 
            "ViewProduct", 
            "Login", 
            "Logout", 
            "ViewProduct", 
            "Login", 
            "AddToCart" 
        ];

        var result = logs.GroupBy(n => n).OrderByDescending(n => n.Count());


        foreach(var i in result)
        {
            Console.WriteLine($"{i.Key} : {i.Count()}");
        }
	}
}