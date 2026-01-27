/* The Scenario: You have a list of Players and a list of Scores.

Some players played multiple times.

Some players are in the "Scores" list but don't exist in the "Players" list (Cheaters/Glitches). We must ignore them.

The Data:

C#
// The Database of Players
var players = new[] { 
    new { Id = 1, Name = "Anwer" }, 
    new { Id = 2, Name = "Bot" },
    new { Id = 3, Name = "Pro" }
};

// The Raw Score Logs (Notice: Player #99 exists here but not above!)
var scores = new[] {
    new { PlayerId = 1, Score = 100 },
    new { PlayerId = 2, Score = 50 },
    new { PlayerId = 1, Score = 200 }, // Anwer played twice
    new { PlayerId = 3, Score = 10 },
    new { PlayerId = 99, Score = 5000 } // Unknown player
};
The Requirements:

Join: Connect the scores to the players using the ID. (This will automatically remove Player #99 because he has no match).

Calculate: We don't just want the list—we want the Total Score for each player.

Hint: You might need to Join first, and then GroupBy the Name, and finally Sum the scores.

Print: "Anwer: 300", "Bot: 50", "Pro: 10".

(This requires chaining Join -> GroupBy -> Select).

Can you defeat the boss? Write the code below! */

using System;

class Program
{
	static void Main()
	{
		// The Database of Players
var players = new[] { 
    new { Id = 1, Name = "Anwer" }, 
    new { Id = 2, Name = "Bot" },
    new { Id = 3, Name = "Pro" }
};

// The Raw Score Logs (Notice: Player #99 exists here but not above!)
var scores = new[] {
    new { PlayerId = 1, Score = 100 },
    new { PlayerId = 2, Score = 50 },
    new { PlayerId = 1, Score = 200 }, // Anwer played twice
    new { PlayerId = 3, Score = 10 },
    new { PlayerId = 99, Score = 5000 } // Unknown player
};

    var combined = players.Join(scores, p => p.Id, s => s.PlayerId, (p, s) => new {Name = p.Name, Score = s.Score});
    
    var result = combined.GroupBy(n => n.Name);
    foreach (var i in result)
        {
            Console.WriteLine($"{i.Key} : {i.Sum(x => x.Score)}");
        }

	}
}