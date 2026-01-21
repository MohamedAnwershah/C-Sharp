using System;

class Program
{
	static void Main()
	{
		(string s, int n) = GetValues();
        Console.WriteLine($"Name : {s}, Age : {n}");
	}	
    static (string, int) GetValues()
    {
        return ("Anwershah", 21);
    }
}