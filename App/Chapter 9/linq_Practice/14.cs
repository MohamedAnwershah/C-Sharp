/* Group: Group the ages by n / 10.

Print: Loop through the groups.

Print the Key (e.g., "2" for the 20s).

Print the count of people in that decade.

Bonus: Can you print the key as a range? (e.g., if Key is 2, print "20s"). */

using System;

class Program
{
	static void Main()
	{
		int[] ages = { 22, 45, 29, 31, 25, 48, 52, 20 };
        var result = ages.GroupBy(x => x / 10);

        foreach(var i in result)
        {   
            Console.WriteLine($"{i.Key}0s : {i.Count()} People");
        }

	}
}