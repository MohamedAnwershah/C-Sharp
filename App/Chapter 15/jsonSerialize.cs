using System;
using System.Text.Json;

class Program
{
    class Player(string name, int level, int score)
    {
        public string Name = name;
        public int Level = level;
        public int Score = score; 
    }

    static void Main()
    {
        Player p1 = new("Shah", 21, 2026);

        JsonSerializerOptions options = new(){WriteIndented = true};

        string jsonText = JsonSerializer.Serialize(p1, options);

        Console.WriteLine(jsonText);
    }

}