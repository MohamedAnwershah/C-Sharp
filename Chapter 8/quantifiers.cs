
/* Create: string[] passwords = { "12345", "password", "admin", "securePass!" };

Check 1 (Any): Check if any password is "12345". Print: "Warning: Insecure password found!" if true.

Check 2 (All): Check if all passwords have a length > 6.

If true, print: "All passwords are strong."

If false, print: "Some passwords are too short." */

using System;

class Program
{
	static void Main()
	{
		string[] passwords = ["12345", "password", "admin", "securePass!" ];

        if (passwords.Any(n => n == "12345"))
        {
            Console.WriteLine("Found!");
        }
        else
        {
            Console.WriteLine("Not found!");
        }

        if (passwords.All(n => n.Length > 5))
        {
            Console.WriteLine("All passwords are strong!");
        }
        else
        {
            Console.WriteLine("Some passwords are weak!");
        }
	}	
}