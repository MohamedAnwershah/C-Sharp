/* Your Objectives

You need to construct a single, massive LINQ pipeline (or a series of 2-3 chained queries) that produces the following result:

Filter: Limit to Orders in 2025 that are "Delivered".

Calculate Spend: For each customer, sum the total cost of these valid orders (Quantity * Product.Price).

Count Categories: Find out how many unique categories they bought from in these valid orders.

Final Filter: Keep only customers with:

Total Spend > $1,000.

Unique Categories > 1.

Projection: The final result list should look like this:

Name

TotalSpend

TopCategory (The category they spent the most money on).

Sort: By Total Spend (Highest first).



Expected Output: Based on the data, only Alice should pass.


Bob: Spent $950 (Fails Money Rule).

Charlie: Spent $2400, but only bought "Electronics" (Fails Diversity Rule).

David: Wrong year / Cancelled orders.

Eve: No orders. */

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;

public class Program {
    public static void Main() {
        // 1. PRODUCTS
        var products = new[] {
            new { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200m },
            new { Id = 2, Name = "Mouse", Category = "Electronics", Price = 25m },
            new { Id = 3, Name = "Desk", Category = "Furniture", Price = 350m },
            new { Id = 4, Name = "Chair", Category = "Furniture", Price = 150m },
            new { Id = 5, Name = "Coffee", Category = "Food", Price = 20m },
            new { Id = 6, Name = "Mug", Category = "Kitchen", Price = 15m },
        };

        // 2. CUSTOMERS
        var customers = new[] {
            new { Id = 101, Name = "Alice", City = "NY" },
            new { Id = 102, Name = "Bob", City = "LA" },
            new { Id = 103, Name = "Charlie", City = "Chicago" }, // High spender, but only Electronics
            new { Id = 104, Name = "David", City = "NY" },        // Low spender
            new { Id = 105, Name = "Eve", City = "LA" }           // No orders
        };

        // 3. ORDERS (Link Customer -> Order)
        var orders = new[] {
            new { Id = 501, CustomerId = 101, Status = "Delivered", Date = new DateTime(2025, 1, 15) },
            new { Id = 502, CustomerId = 101, Status = "Pending",   Date = new DateTime(2025, 1, 20) }, // Ignore this!
            new { Id = 503, CustomerId = 102, Status = "Delivered", Date = new DateTime(2025, 2, 10) },
            new { Id = 504, CustomerId = 103, Status = "Delivered", Date = new DateTime(2025, 1, 05) },
            new { Id = 505, CustomerId = 104, Status = "Cancelled", Date = new DateTime(2025, 1, 10) }, // Ignore!
            new { Id = 506, CustomerId = 104, Status = "Delivered", Date = new DateTime(2024, 12, 25) } // Wrong Year!
        };

        // 4. ORDER DETAILS (Link Order -> Product)
        // Note: One order can have multiple items
        var orderDetails = new[] {
            new { OrderId = 501, ProductId = 1, Quantity = 1 },  // Alice: Laptop ($1200)
            new { OrderId = 501, ProductId = 2, Quantity = 2 },  // Alice: Mouse ($50)
            new { OrderId = 501, ProductId = 5, Quantity = 5 },  // Alice: Coffee ($100) -> DIVERSIFIED!
            
            new { OrderId = 503, ProductId = 3, Quantity = 1 },  // Bob: Desk ($350)
            new { OrderId = 503, ProductId = 4, Quantity = 4 },  // Bob: Chairs ($600) -> Total $950 (Fail: < 1000)

            new { OrderId = 504, ProductId = 1, Quantity = 2 },  // Charlie: 2 Laptops ($2400) -> NOT DIVERSIFIED (Only Electronics)
        };

        // ---------------------------------------------------------
        // YOUR CODE STARTS HERE
        // ---------------------------------------------------------
        
        // Goal: Generate a report of VIP Customers.


        var deliveredOrders = from c in customers 
        join o in orders
        on c.Id equals o.CustomerId 
        where o.Status == "Delivered" && o.Date.Year >= 2025 
        select new 
        {
            c.Name, CustomerId = c.Id, OrderId = o.Id
        };
        

        var diversifiedOrders = from d in deliveredOrders 
        join o in orderDetails 
        on d.OrderId equals o.OrderId into Orders 
        where Orders.Count() > 1 select new
        {
            d.Name, d.OrderId
        };
        
        var v1 = from d in diversifiedOrders 
        join o in orderDetails 
        on d.OrderId equals o.OrderId 
        select new 
        {
            d.Name, o.OrderId, o.ProductId, o.Quantity
        };

        var v2 = from v in v1 
        join p in products 
        on v.ProductId equals p.Id 
        select new 
        {
            p.Category,
            v.Name,
            Sum = v.Quantity * p.Price
            
        };

        
        var v3 = v2.GroupBy(x => x.Name);
        using StreamWriter sw = new("vip_report.txt");
        foreach (var i in v3)
        {
            decimal totalSpend = i.Sum(x => x.Sum);
            int uniqueCategory = i.Select(x => x.Category).Distinct().Count();
            var topCategory = i.GroupBy(x => x.Category)
            .Select(g => new
            {
                categoryName = g.Key,
                categoryTotal = g.Sum(x => x.Sum)
            })
            .OrderByDescending(x => x.categoryTotal)
            .First()
            .categoryName;

            if (totalSpend >= 1000)
            {
                sw.WriteLine($"Generated on : {DateTime.Now}");
                sw.WriteLine($"Name : {i.Key}, Top Category : {topCategory}, Amount : {totalSpend}, Unique categories : {uniqueCategory}");
            }
        }


    }
}