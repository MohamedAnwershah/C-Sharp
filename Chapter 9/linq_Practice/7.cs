using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
		var students = new[] {
        new { Id = 1, Name = "John" },
        new { Id = 2, Name = "Jane" },
        new { Id = 3, Name = "Mark" } // Mark has NO grades
    };

    var results = new[] {
        new { StudentId = 1, Subject = "Math", Score = 85 },
        new { StudentId = 1, Subject = "Science", Score = 95 },
        new { StudentId = 2, Subject = "Math", Score = 40 },
        new { StudentId = 2, Subject = "Science", Score = 50 }
    };  
    /* GroupJoin: Connect Students to Results so we keep Mark.

        Calculate: inside the loop (or result selector), calculate the Average Score.

        Constraint: You must check if the list has grades first! If Any() is false, the average is 0.

        Print:

        John: 90

        Jane: 45

        Mark: No Data (or 0) */

        var combined = students.GroupJoin(results, s => s.Id, r => r.StudentId, (x, y) => new
        {
            Id = x.Id,
            Name = x.Name,
            HasGrade = y.Any(),
            Average = y.Any() ? y.Average(x => x.Score) : 0
        });

        foreach (var i in combined)
        {
            
            if (i.HasGrade)

            {
                Console.WriteLine($"{i.Id}.{i.Name} : {i.Average}");
            }
            else 
            {
                Console.WriteLine($"{i.Name} : No data!");
            }

        }
	}
}