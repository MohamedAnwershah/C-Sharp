/* Namespace: using System.Text;

Create: StringBuilder sb = new StringBuilder();

Loop: Create a for loop that runs 5 times.

Append: Inside the loop, append "Loop number: " followed by the index i and a new line.

Print: Print the final result. */

using System;
using System.Text;

class Program
{
	static void Main()
	{
		StringBuilder sb = new();

        for (int i = 1; i < 11; i++)
        {
            sb.AppendLine($"Number : {i}");
        }
        string result = sb.ToString();
        Console.WriteLine(result);
	}
}