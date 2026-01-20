using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new()
        {
        {"shah", "1234-5678"},
        {"nawf", "8765-4321"}  
        };
        Console.WriteLine(phoneBook["shah"]);
        if (phoneBook.ContainsKey("irfan"))
        {
            Console.WriteLine(phoneBook["irfan"]);
        }
        else{Console.WriteLine("Not found");}
    }
}