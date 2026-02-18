
/* Current: Get the current time: DateTime now = DateTime.Now;

Future: Calculate a deadline that is 3 days from now: DateTime deadline = now.AddDays(3);

Duration: Create a timespan of 2 hours: TimeSpan extraTime = TimeSpan.FromHours(2);

Math: Add the extra time to the deadline.

Print: Output the final deadline. */

using System;

class Program
{
	static void Main()
	{
		DateTime now = DateTime.Now;

        DateTime deadLine = now.AddDays(3);

        TimeSpan extraTime = TimeSpan.FromHours(3);

        deadLine = deadLine.Add(extraTime);

        Console.WriteLine(deadLine);
	}
}