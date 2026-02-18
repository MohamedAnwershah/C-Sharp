
/* Create: Dictionary<string, long> phonebook = new(); (String for name, Long for phone number).

Add:

Add "Shah" -> 9876543210

Add "Police" -> 100

Lookup: Print $"Shah's number is: {phonebook["Shah"]}".

Check: Use if (phonebook.ContainsKey("Police")) to check if the police are listed. */


using System;

class Program
{
	static void Main()
	{
		Dictionary<string, string> phonebook = new()
        {
            {"shah" , "7904868704"},
            {"Nawf" , "0987654321"}
        };

        Console.WriteLine($"Shah's number : {phonebook["shah"]}");
        if (phonebook.ContainsKey("Nawf"))
        {
            Console.WriteLine("Found!");
        }
        else
        {
            Console.WriteLine("Not found!");
        }
	}	
}
