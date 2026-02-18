using System;

class Program
{
    static void Main()
    {
        string path = "bigfile.txt";
        
        using StreamWriter sw = new(path);

        for(int i = 1; i<= 1_000_000; i++)
        {
            sw.WriteLine($"Log {i}: System working Fine!\n");
        }
        Console.WriteLine("Done!");

        FileInfo info = new(path);

        Console.WriteLine($"Size : {info.Length / 1024 / 1024}");
        using StreamReader sr = new(path);
        string line;
        while((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}