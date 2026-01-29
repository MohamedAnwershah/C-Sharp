
/* Import: Add using System.Globalization; at the top.

Variable: decimal amount = 12345.67m;

Print 1 (USA): Create a culture new CultureInfo("en-US") and print the amount formatted as Currency C.

Expected: $12,345.67

Print 2 (Germany): Create a culture new CultureInfo("de-DE") and print as C.

Expected: 12.345,67 € (Notice the swapped dot and comma).

Print 3 (Japan): Create a culture new CultureInfo("ja-JP") and print as C.

Expected: ￥12,346 (Yen usually doesn't use decimals). */

using System;
using System.Globalization;
class Program
{
	static void Main()
	{   
        CultureInfo c = new("en-DE"); //change en-US, ja-JP, etc...
        int amount = 100;
        Console.WriteLine(amount.ToString("C", c));
        CultureInfo j = new("ja-JP");
        Console.WriteLine(amount.ToString("C", j));
	}

}