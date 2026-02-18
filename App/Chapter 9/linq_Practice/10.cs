/* Zip: Merge names and scores.

Format: The result selector (n, s) should return a string: "{n} scored {s} points".

Print:

Anwer scored 500 points

Bot scored 100 points */

using System;

class Program
{
	static void Main()
	{
		string[] names = [ "Anwer", "Bot", "Pro" ];
        int[] scores   = [ 500,     100,   9000 ];

        var result = names.Zip(scores, (x, y) => $"{x} scored : {y}");

        foreach (string i in result)
        {
            Console.WriteLine(i);
        }

	}
}