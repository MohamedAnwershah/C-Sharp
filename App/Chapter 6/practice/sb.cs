using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; // You will need this for finding the Max length!

class Program
{
    static void Main()
    {
        // THE DATA
        var menuItems = new[] {
            new { Name = "Espresso", Price = 2.50m },
            new { Name = "Blueberry Muffin", Price = 4.50m },
            new { Name = "Tea", Price = 1.75m },
            new { Name = "Super Duper Long Sandwich", Price = 8.99m } 
        };

        // --- YOUR CODE STARTS HERE ---
        List<string> list = [];
        int longestName = 0;
        foreach (var i in menuItems)
        {
            if (i.Name.Length > longestName)
            {
                longestName = i.Name.Length;
            }
        }
        Console.WriteLine(longestName);

        foreach (var item in menuItems)
        {
            StringBuilder sb = new();
            int n = longestName - item.Name.Length;
            sb.Append(item.Name);
            for (int i = 1; i < n + 5; i++)
            {
                sb.Append('.');
            }
            sb.Append($" {item.Price:C}");
            list.Add(sb.ToString());
        }
        Console.WriteLine(String.Join('\n',list));
        

    }
}