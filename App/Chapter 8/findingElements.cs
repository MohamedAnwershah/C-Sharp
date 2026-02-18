/* Create: string[] users = { "Guest", "Admin", "User1" };

Unsafe Search:

Try to find "SuperUser" using .First(u => u == "SuperUser").

Wrap this in a try-catch block to catch the crash. Print "Crashed!".

Safe Search:

Try to find "SuperUser" using .FirstOrDefault(...).

Check if the result is null. Print "Not Found (Safe)". */

using System;
using System.Diagnostics;

class Program
{
	static void Main()
	{
		string[] users = ["Guest", "Admin", "User1"];

        try
        {
            string user = users.First(n => n == "SuperUser");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        string user1 = users.FirstOrDefault(n => n == "SuperUser");
        if (user1 == null)
        {
            Console.WriteLine("Not found!");
        }
        else
        {
            Console.WriteLine("Found!");
        }
	}	
}