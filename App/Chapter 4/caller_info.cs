using System;
using System.Runtime.CompilerServices;

class Program
{
	static void Main()
	{
		Log("Hello");
	}	
    static void Log(string message, [CallerMemberName] string origin = "", [CallerLineNumber] int line = 0)
    {
        Console.WriteLine($"LOG: {message} (Source: {origin} at Line {line})");
    }
}