
/* Create: Queue<string> printer = new();

Add Jobs: Enqueue "Resume.pdf", then "Photo.jpg", then "Ticket.pdf".

Peek: Print $"Next up: {printer.Peek()}". (Should be Resume).

Process:

Create a while loop that runs as long as printer.Count > 0.

Inside, print $"Printing: {printer.Dequeue()}".

Observation: Watch the order they come out. */
using System;

class Program
{
	static void Main()
	{
		Queue<string> printer = new();

        printer.Enqueue("resume.pdf");
        printer.Enqueue("Photo.jpg");
        printer.Enqueue("Program.cs");
        



        Console.WriteLine($"Next up : {printer.Peek()}");
        while (printer.Count > 0)
        {
            Console.WriteLine($"Printing : {printer.Dequeue()}");
        }
        

	}	
}