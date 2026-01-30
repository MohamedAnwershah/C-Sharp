using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter a Note : ");

        string input = Console.ReadLine();
        File.WriteAllText("notes.txt", input);
        Console.WriteLine("Successfully written to 'notes.txt'");
        Console.WriteLine($"Content inside 'notes.txt' : {File.ReadAllText("notes.txt")}");
	}

}
