
/* Create a Date: DateTime y2k = new DateTime(2000, 1, 1);

Get Now: DateTime now = DateTime.Now;

Calculate Duration: TimeSpan diff = now - y2k;

Print: $"Days since Y2K: {diff.TotalDays:N0}" (Use the number format you just learned to add commas!). */

using System;


class Program
{
    static void Main()
    {
        DateTime y2k = new(2000, 1, 1);
        DateTime today = DateTime.Now;
        TimeSpan diff = today - y2k;

        Console.WriteLine($"Total Days from 2000 : {diff.TotalDays:N0}");
    }
}