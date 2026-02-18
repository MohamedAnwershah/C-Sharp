
/* Create:

string[] invited = { "A", "B", "C", "D" };

string[] arrived = { "C", "D", "E", "F" };

Find Crashers: Use arrived.Except(invited) (In Arrived, NOT in Invited).

Find Ghosters: Use invited.Except(arrived) (In Invited, NOT in Arrived).

Find Valid Guests: Use invited.Intersect(arrived) (In BOTH).

Print: Print the results of all three queries. */

using System;

class Program
{
	static void Main()
	{
		string[] invited =  ["A", "B", "C", "D"];

        string[] arrived = ["C", "D", "E", "F"];

        var crashers = arrived.Except(invited);
        foreach(string crasher in crashers)
        {
            Console.WriteLine($"Crashers : {crasher}");
        }
        

        var ghosters = invited.Except(arrived);
        foreach(string ghoster in ghosters)
        {
            Console.WriteLine($"Ghosters : {ghoster}");
        }

        var validGuests = arrived.Intersect(invited);
        foreach(string guest in validGuests)
        {
            Console.WriteLine($"Valid : {guest}");
        }
	}
}