
/* Write: A Query Syntax block.

Start: from c in customers

Join: join o in orders on c.Id equals o.CustomerId

Select: select new { c.Name, o.Amount }

Print: "Alice bought item for 500", "Bob bought item for 800". */
using System;

class Program
{
	static void Main()
	{
		var customers = new[] {
            new { Id = 1, Name = "Alice" },
            new { Id = 2, Name = "Bob" }
        };

        var orders = new[] {
            new { Id = 101, CustomerId = 1, Amount = 500 },
            new { Id = 102, CustomerId = 2, Amount = 800 }
        };

        var result = from c in customers join o in orders on c.Id equals o.CustomerId select new { c.Name, o.Amount};
        foreach (var i in result)
        {
            Console.WriteLine($"{i.Name} bought the item for {i.Amount}");
        }

        /* Start: from c in customers

        Group Join: join o in orders on c.Id equals o.CustomerId into customerOrders

        Note: The into keyword is what saves Eve! It creates the empty list for her instead of deleting her.

        Select: select new { c.Name, Count = customerOrders.Count() }

        Print:

        Alice: 2

        Eve: 0 */

        var groupJoin = from c in customers join o in orders on c.Id equals o.CustomerId into customerOrders select new {c.Name, Count = customerOrders.Count()};
        foreach (var i in groupJoin)
        {
            Console.WriteLine($"{i.Name} : {i.Count}");
        }
    }

}
