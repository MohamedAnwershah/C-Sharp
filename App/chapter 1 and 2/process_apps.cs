//opening apps and files
using System;
using System.Diagnostics;
class process_apps

{
    public static void Main()
    {
        Console.WriteLine("Opening Calculator...");
        Process.Start("open", "-a Calculator");
        Process.Start("open", "-t /Users/mohamedanwershah/Desktop/todolist.txt");
    }
}