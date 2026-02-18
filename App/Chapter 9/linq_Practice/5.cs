
/* The Scenario: Marketing wants to send a coupon to our "High Value" customers. A "High Value" customer is defined as anyone who has placed a single order worth more than $600.

Your Goal:

Join: Connect customers and orders.

Filter: Find orders where Amount > 600.

Select: Get the Customer Name and the Order Amount.

Print: "Alice bought something for $1000". */

using System;

class Program
{
	static void Main()
	{
		// ==================== THE DATABASE ====================
        var customers = new[] {
            new { Id = 1, Name = "Alice", Region = "USA" },
            new { Id = 2, Name = "Bob",   Region = "USA" },
            new { Id = 3, Name = "Charlie", Region = "UK" },
            new { Id = 4, Name = "David", Region = "UK" },
            new { Id = 5, Name = "Eve",   Region = "USA" } // Eve has NO orders
        };

        var orders = new[] {
            new { Id = 101, CustomerId = 1, Amount = 500 }, // Alice
            new { Id = 102, CustomerId = 1, Amount = 200 }, // Alice
            new { Id = 103, CustomerId = 2, Amount = 800 }, // Bob
            new { Id = 104, CustomerId = 3, Amount = 150 }, // Charlie
            new { Id = 105, CustomerId = 3, Amount = 50  }, // Charlie
            new { Id = 106, CustomerId = 1, Amount = 1000}  // Alice
        };
        // ======================================================

        var combined = customers.Join(orders, c => c.Id, o => o.CustomerId, (x, y) => new {Id = x.Id, Name = x.Name, Region = x.Region, Amount = y.Amount, OrderId = y.Id});
      
        
        var result = combined.Where(n => n.Amount > 600).Select(n => $"{n.Name} bought something for {n.Amount}");
        foreach ( var i in result)
        {
            Console.WriteLine(i);
        }
        /* Join Customers and Orders (using the fix above).

        Group By the Region (USA vs UK).

        Sum the total order amount for each region.

        Print:

        USA: $2500 (Alice + Bob)

        UK: $200 (Charlie) */

        var grouped = combined.GroupBy(n => n.Region);
        foreach ( var grp in grouped)
        {
            Console.WriteLine($"{grp.Key} : {grp.Sum(n => n.Amount)}");
        }

        /* Join: Connect customers and orders (same as before).

        Group: Group by Customer Name.

        Process: Inside your loop, for each customer (group), print a string that looks like this:

        Alice: Orders [101, 102, 106] - Total: $1700

        Bob: Orders [103] - Total: $800 */

        foreach (var grp in grouped)
        {
            var idList = grp.Select(x => x.OrderId);
            string ids = String.Join(", ", idList);

            Console.WriteLine($"{grp.Key} : [{ids}] - Total: {grp.Sum(n => n.Amount):C}");
        }

        /*  Use GroupJoin: We still want to see every customer (including Eve).

        Filter Inside: Inside the result selector (cust, orderList) => ..., you need to count only the orders where Amount > 400.

        Hint: You can pass a condition to Count: .Count(x => x.Amount > 400).

        Print:

        Alice: 2 (She has 500 and 1000. The 200 is ignored).

        Bob: 1 (His 800).

        Charlie: 0 (He has orders, but none over 400).

        Eve: 0 (She has no orders at all).*/

        var groupJoin = customers.GroupJoin(
            orders,
            c => c.Id,
            o => o.CustomerId,
            (x, orderList) => new
            {
                Name = x.Name,
                IsListEmpty = !orderList.Any(),
                Count = orderList.Count(n => n.Amount > 400)
            }
        );
        foreach (var i in groupJoin)
        {
            Console.WriteLine($"{i.Name} : {i.Count}");
        }

        /* Use GroupJoin to get the customers and their order lists.

        Filter (Where) the final result to keep only the "Gold" customers.

        Hint: inside the Where, you need logical AND &&.

        list.Any() (Checks if not empty)

        list.All(x => ...) (Checks if all match condition)

        Print: "Gold Customer: Alice", "Gold Customer: Bob". */

        var allJoined = customers.GroupJoin(orders, c => c.Id, o => o.CustomerId,
            (x, y) => new
            {
                Name = x.Name,
                IsGold = y.Any() && y.All(n => n.Amount > 100)
            }
        );
        foreach (var i in allJoined)
        {
            if (i.IsGold)
            {
                Console.WriteLine($"{i.Name} : Gold");
            }
            else
            {
                Console.WriteLine($"{i.Name} : Not Gold");
            }
        }

	}
}