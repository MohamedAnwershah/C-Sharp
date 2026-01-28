/* Convert: Turn the list into a Dictionary.

Key: The Id (101, 102...).

Value: The Name string ("Laptop"...).

Syntax: products.ToDictionary(p => p.Id, p => p.Name)

Lookup: Use the dictionary indexer [ ] to find the name of product 102.

Print: "Product 102 is: Mouse". */

using System;

class Program
{
	static void Main()
	{
		var products = new[] {
        new { Id = 101, Name = "Laptop", Price = 999 },
        new { Id = 102, Name = "Mouse",  Price = 25 },
        new { Id = 103, Name = "Keyboard", Price = 75 }
    };

    var result = products.ToDictionary(p => p.Id, p => p.Name);

    foreach (var i in result)
        {
            Console.WriteLine($"Product {i.Key} is : {i.Value}");
        }
	}
}