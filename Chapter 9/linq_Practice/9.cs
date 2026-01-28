/* Clean: First, remove duplicates from newSignups so "david" only appears once.

Filter: We only want to email people who have not received the code yet.

Logic: (Cleaned New List) EXCEPT (Old List).

Print: You should only see:

david@test.com

eve@test.com */

using System;

class Program
{
	static void Main()
	{
		string[] oldUsers = { "alice@test.com", "bob@test.com", "charlie@test.com" };

        string[] newSignups = { 
            "bob@test.com",      // DUPLICATE (Already in old list)
            "david@test.com",    // NEW
            "alice@test.com",    // DUPLICATE (Already in old list)
            "david@test.com",    // DUPLICATE (He clicked submit twice!)
            "eve@test.com"       // NEW
        };

        var uniqueSignUps = newSignups.Distinct();

        var yetToRecieve = uniqueSignUps.Except(oldUsers);

        foreach( string i in yetToRecieve)
        {
            Console.WriteLine(i);
        }
	}
}