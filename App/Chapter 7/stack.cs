/* Create: Stack<string> history = new();

Visit Sites: Push "google.com", then "github.com", then "stackoverflow.com".

Current Site: Print $"Current Page: {history.Peek()}". (Should be StackOverflow).

Go Back:

Call history.Pop(); (User clicked Back).

Print $"Went back. Now at: {history.Peek()}". (Should be GitHub). */

using System;

class Program
{
	static void Main()
	{
		Stack<string> history = new();

        history.Push("google.com");
        history.Push("github.com");
        history.Push("stackoverflow.com");

        Console.WriteLine($"Current : {history.Peek()}");
        Console.WriteLine($"Removed : {history.Pop()}");
        Console.WriteLine($"Current : {history.Peek()}");
	}	
}