using System;

class Program
{
	static void Main()
	{
		var gadget = new {Name = "Iphone", Price = 1299};
        Console.WriteLine($"Item: {gadget.Name}, Cost: {gadget.Price}");

        Console.WriteLine(gadget.GetType().Name);
	}	
}