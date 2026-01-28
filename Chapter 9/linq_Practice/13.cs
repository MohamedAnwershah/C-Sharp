/* Data: Create a list of 35 numbers: Enumerable.Range(1, 35).

Process: Split them into chunks of 10.

Loop: You will need a loop to go through the batches.

Print: Inside the loop, print the count and the contents.

"Processing batch of 10 items: 1, 2, 3..."

"Processing batch of 10 items: 11, 12..."

...

"Processing batch of 5 items: 31, 32..." */

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
		var nums = Enumerable.Range(1, 35);

        var result = nums.Chunk(10);

        foreach(var i in result)
        {
            
            
            string str = String.Join(", ", i);
            Console.WriteLine($"Batch of {i.Length} items: {str}.");
            
            
        }
	}
}