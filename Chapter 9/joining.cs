using System;

class Program
{
	static void Main()
	{
		var students = new[] { new { Name = "Harry", HouseId = 1 }, new { Name = "Draco", HouseId = 2 } };
        var houses = new[] { new { Id = 1, Name = "Gryffindor" }, new { Id = 2, Name = "Slytherin" } };

        var result = students.Join(houses, s => s.HouseId, h => h.Id, (s, h) => $"{s.Name} belongs to {h.Name}");

        foreach (string res in result){
            Console.WriteLine(res);
        }
	}
}