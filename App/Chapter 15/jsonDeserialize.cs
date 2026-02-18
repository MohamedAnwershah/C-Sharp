using System;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    class Player
    {
        public string Name;
        public int Level;
        public int Health;
    }

    static void Main()
    {
        string loadedData = @"{
          ""Name"": ""DragonSlayer"",
          ""Level"": 43,
          ""Health"": 85
        }";

        Player p1 = JsonSerializer.Deserialize<Player>(loadedData);

        Console.WriteLine($"Welcome back, {p1.Name}\nCurrent level : {p1.Level}");
        p1.Health += 15;
        Console.WriteLine($"Health : {p1.Health}");
        
    }

}