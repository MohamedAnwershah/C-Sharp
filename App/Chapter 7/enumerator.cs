/* Create: List<string> months = ["Jan", "Feb", "Mar"];.

Get Enumerator: var enumerator = months.GetEnumerator();.

Manual Loop:

Write a while loop that runs as long as enumerator.MoveNext() is true.

Inside, print enumerator.Current. */

using System;
using System.Runtime.CompilerServices;

class Program
{
	static void Main()
	{
		List<string> months = ["jan", "feb", "mar"];

        var enumerator = months.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }


	}	
}