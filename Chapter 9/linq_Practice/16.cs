using System;

class Program
{
	static void Main()
	{
		int[] numbers = { 2, 9, 5, 12, 7, 3, 8, 10 };

        var result = from n in numbers where n > 5 && n % 2 == 0 orderby n select n;

        foreach(int i in result)
        {
            Console.WriteLine(i);
        }
	}
}