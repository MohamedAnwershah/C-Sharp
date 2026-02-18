using System;

class Program
{
	static void Main()
	{
		string[] books =  ["Harry Potter", "Hunger Games", "Lord of the Rings", "The Hobbit" ];
        
        var library = books.ToLookup(b => b[0]);
        foreach(string book in library['H'])
        {
            Console.WriteLine(book);
        }
        
	}
}