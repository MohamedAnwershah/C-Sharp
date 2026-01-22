/* Concepts: switch statements, case, default.

The Scenario: You are writing the firmware for a robot. It receives text commands. Using a giant chain of if/else checks is messy, so you need to use a switch statement.

Your Task:

Create a variable: string command = "ATTACK"; (You can change this to test different cases).

Write a switch statement that checks command:

Case "START": Print "System powering up...".

Case "STOP": Print "Halting all motors.".

Case "ATTACK": Print "Target acquired. Engaging.".

Default: Print "Unknown command. Idling.". */

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string command = "ATTACK";

        switch (command)
        {
            case "ATTACK":
            
                Console.WriteLine("Target acquired. Engaging.");
                break;
            
            case "START":

                Console.WriteLine("System powering up...");
                break;
            
            case "STOP":
                Console.WriteLine("Halting all motors.");
                break;

            default:
                Console.WriteLine("Unknown command. Idling.");
                break;
        }
    }   
}