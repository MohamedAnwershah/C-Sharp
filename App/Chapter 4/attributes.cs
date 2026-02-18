using System;
using System.Security.Cryptography;

class Program
{
	static void Main()
	{
		OldMethod();
	}


    [Obsolete("use new method")]
    static void OldMethod()
    
    {
        
        Console.WriteLine("ss");
    }
    static void NewMethod()
    {
        
        Console.WriteLine("nn");
    }
}