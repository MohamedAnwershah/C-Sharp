using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        string saveFile = "save_game.json";

        Player p1 = new()
        {
            Name = "Shah",
            Level = 21,
            Score = 312  
        };

        JsonSerializerOptions options = new() { WriteIndented = true };

        string jsonToSave = JsonSerializer.Serialize(p1, options);

        File.WriteAllText(saveFile, jsonToSave);

        if (File.Exists(saveFile))
        {
            string jsonLoaded = File.ReadAllText(saveFile);

            Player playerLoaded = JsonSerializer.Deserialize<Player>(jsonLoaded);

            Console.WriteLine(playerLoaded.Name);
        }

    }
}
class Player()
{
    public string Name {get; set;}
    public int Level {get; set;}
    public int Score {get; set;}
}