using System;

class Program
{
	static void Main()
	{
		List<string> names = ["shah", "nawf", "irfan"];

        var e = names.GetEnumerator();

        while (e.MoveNext())
        {
            string name = e.Current;
            Console.WriteLine(name);
        }
	}	
}