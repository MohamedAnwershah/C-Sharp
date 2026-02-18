
/* Loop: Run a loop 3 times.

Generate: Inside the loop, create Guid id = Guid.NewGuid();.

Print: $"User Session: {id}".

Observe: Notice that every time you run it, the strings are completely different. */


using System;

class Program
{
	static void Main()
	{   
        for (int i = 1; i <= 10; i++)
        {
            Guid id = Guid.NewGuid();
            Console.WriteLine($"User {i} : {id}");
        }
	}	
}