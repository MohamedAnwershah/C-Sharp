/* Add Namespace: using System.Text;

Create Builder: StringBuilder sb = new StringBuilder();.

Loop: for (int i = 0; i < 10; i++).

Inside, append a word: sb.Append("Loop "); (Use .Append, not +).

Append the number: sb.Append(i);.

Append a comma: sb.Append(", ");.

Print: Convert it back to a normal string to print: Console.WriteLine(sb.ToString());. */


using System.Text;
using System;
using System.IO.Compression;

class Program
{
	static void Main()
	{
		StringBuilder sb = new();

        for (int i = 1; i < 100; i++)
        {
            if(i < 10)
            {
                sb.Append('0');
            }
            sb.Append(i);
            sb.Append(", ");
            sb.Append("Hello \n");

        }
        Console.WriteLine(sb.ToString());
	}	
}