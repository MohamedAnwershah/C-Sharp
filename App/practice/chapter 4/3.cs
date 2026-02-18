/* The Scenario: You are building a logging utility for a large application. You need a simple way to print messages that visually distinguish between "Just Info" and "Critical Errors".

Your Task:

Create an Enum: enum LogLevel { Info, Error }.

(Place this outside or inside the class, your choice).

Create a Static Class: static class Logger.

Method: public static void Log(string message, LogLevel level).

The Logic (Inside Log):

If level is Info: Set Console.ForegroundColor = ConsoleColor.White;.

If level is Error: Set Console.ForegroundColor = ConsoleColor.Red;.

Print: [{level}] {message} (e.g., "[Error] Database Failed").

Cleanup: Call Console.ResetColor(); immediately after printing (so you don't mess up the terminal for the rest of the app).

Main Program:

Call Logger.Log("System booting...", LogLevel.Info);

Call Logger.Log("Critical Failure!", LogLevel.Error); */

using System;
using System.Diagnostics;

class Program
{
	static void Main()
	{
		Logger.Log("Cannot load!", LogLevel.Error);
        Logger.Log("Successfully loaded", LogLevel.Info);
    }
}
enum LogLevel
    {
        Error,
        Info
    }

static class Logger
{
    public static void Log(string msg, LogLevel log)
    {
        switch (log)
        {
            case (LogLevel.Error):
            
                Console.ForegroundColor = ConsoleColor.Red;
                break;

            case (LogLevel.Info):
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            
        }
        Console.WriteLine($"[{log}] {msg}");
        Console.ResetColor();
    }
}
