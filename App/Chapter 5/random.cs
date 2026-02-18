/* Create: Random rand = new Random();

Loop: Run a loop 5 times.

Generate: Inside the loop, generate a random number between 10 and 20.

Print: Output the number. */

using System;

class Program
{
	static void Main()
	{
		Random rand = new();

        for ( int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(10, 20));
        }
	}
}
