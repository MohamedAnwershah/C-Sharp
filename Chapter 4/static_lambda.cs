using System;

class Program
{
	static void Main()
	{
        string prefix = "Mr.";
        Func<string, string> formatter1 = name => prefix + name; //can use other variables
		Func<string, string> formatter2 = static name => "User : " + name; //static lambdas are pure - no extra memory
        string formattedName1 = formatter1("Anwershah");
        string formattedName2 = formatter2("Anwershah");
        Console.WriteLine(formattedName1);
        Console.WriteLine(formattedName2);
	}	
}

