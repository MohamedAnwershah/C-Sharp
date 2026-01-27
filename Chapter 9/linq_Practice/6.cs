using System;

class Program
{
	static void Main()
	{
		var departments = new[] {
        new { 
            Name = "Development", 
            Teams = new[] { 
                new { TeamName = "Backend", Employees = new[] { "Alice", "Bob" } },
                new { TeamName = "Frontend", Employees = new[] { "Charlie" } }
            }
        },
        new { 
            Name = "Sales", 
            Teams = new[] { 
                new { TeamName = "USA", Employees = new[] { "David" } }
            }
        }
    };

    var result = departments.Where(x => x.Name == "Development").SelectMany(y => y.Teams).SelectMany(z => z.Employees);
    foreach(var i in result)
        {
            Console.WriteLine(i);
        }
	}
}