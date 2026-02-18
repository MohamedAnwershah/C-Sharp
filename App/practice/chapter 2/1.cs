/* 

Concepts: Arrays, foreach loops, if/else if.

The Scenario: You are building an inventory system for a warehouse. You receive a raw array of stock numbers, but some data is corrupted (negative numbers) or empty (zeros).

Your Task:

Create an integer array: int[] stock = { 15, 0, -5, 8, 0, -1, 50 };

Write a foreach loop to check every number.

Apply this logic:

If the number is Negative (< 0): Print "{n} -> Error: Data Corrupt".

If the number is Zero (0): Print "{n} -> Out of Stock".

If the number is Positive (> 0): Print "{n} -> Item Available". */

using System;

class Program
{
    static void Main()
    {
        int[] stock = {15, 0, -5, 8, 0, -1, 50};

        foreach (int i in stock)
        {   
            Console.Write(i);
            if (i < 0)
            {
                Console.WriteLine(": Error : Data Corrupt");
            }
            else if (i == 0)
            {
                Console.WriteLine(": Out of Stock");
            }
            else
            {
                Console.WriteLine(": Item Available");
            }
        }
    }   
}