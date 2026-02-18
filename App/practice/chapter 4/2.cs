/* Concepts: try, catch, throw.

The Scenario: You are writing a function that connects to a database. Sometimes it fails. You need to manually "Throw" an error when things go wrong, and "Catch" it in the main program so the app doesn't crash.

Your Task:

Create Method: static void ConnectToDatabase(string serverName).

Check: If serverName is "null", throw an exception: throw new Exception("Server not found!");.

Else: Print "Connected to {serverName}".

Main Program:

Write a try block.

Inside, call ConnectToDatabase("null");.

Write a catch block (Exception ex).

Inside catch, print: "ERROR HANDLED: " + ex.Message.

Goal: The program should print the error message nicely, instead of crashing with a "Unhandled Exception" screen. */


using System;
using System.Diagnostics;

class Program
{
	static void Main()
	{
        try
        {
            ConnectToDatabase(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finished!");
        }
	}	

    static void ConnectToDatabase(string serverName)
    {
        
        if (serverName is null)
        {
            throw new Exception("Server Not Found!");
        }
        else
        {
            Console.WriteLine($"Connected to {serverName}");
        }
    }
}