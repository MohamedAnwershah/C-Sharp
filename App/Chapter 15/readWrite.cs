/* Run this code.

Look in your project folder (bin/Debug/net8.0/). You will see a real file named diary.txt.

Open it with Notepad to prove it worked. */

using System;

class Program
{
    static void Main()
    {
        string path = "diary.txt";
        string content = "Hey, Today I learnt I/O in C#\n";
        File.WriteAllText(path, content);

        Console.WriteLine("Successfully written part 1");

        content = "It was easy Surprisingly!";
        File.AppendAllText(path, content);
        Console.WriteLine("Successfully written part 2");

        if (File.Exists(path))
        {
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}