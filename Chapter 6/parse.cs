
/* Variables: Create string[] inputs = { "50", "hello", "100" };.

Loop: Iterate through the array.

Logic:

Try to parse the string into an integer variable named number.

If Success: Print "Valid: {number}".

If Fail: Print "Invalid input". */


using System;

class Program
{
	static void Main()
	{
		string[] inputs = { "50", "hello", "100" };

        foreach (string i in inputs)
        {
            if(int.TryParse(i, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
	}	
}