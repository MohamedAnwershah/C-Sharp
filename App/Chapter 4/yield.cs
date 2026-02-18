using System;
using System.Collections.Generic;
class Program
{
	static void Main()
	{
		foreach (int i in GetNumber())
        {
            Console.WriteLine(i);
        }
	}	
    static IEnumerable<int> GetNumber()
    {
        for (int i = 1; i <= 5; i++)
        {
            yield return i;
        }
    }
}

