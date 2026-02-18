/* On Startup: Check if savegame.json exists.

Yes? Load the player and say "Welcome back, [Name]!"

No? Create a new player (Level 1) and say "New Game Started."

The Action: We will "Level Up" the player (Add +1 to Level).

On Exit: Save the new data back to the file. */

using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string filePath = "savegame.json";
        Player currentPlayer;

        try
    {
        string jsonText = File.ReadAllText(filePath);
        currentPlayer = JsonSerializer.Deserialize<Player>(jsonText);
        Console.WriteLine($"Welcome back, {currentPlayer.Name}!");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("NEW GAME STARTED");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        currentPlayer = new Player { Name = name, Level = 1 };
    }
    catch (JsonException)
    {
        Console.WriteLine("ALERT: Save file is corrupted!");
        currentPlayer = new Player { Name = "Survivor", Level = 1 };
    }
    catch (Exception ex)
    {
        Console.WriteLine("CRITICAL ERROR: " + ex.Message);
        return;
    }
           
       
            
        
        Console.WriteLine("\nYou fought a monster and won!");
        currentPlayer.Level++;
        Console.WriteLine($"New Level: {currentPlayer.Level}");

        string dataToSave = JsonSerializer.Serialize(currentPlayer);
        
        File.WriteAllText("savegame.json", dataToSave);
        
        Console.WriteLine("Game Saved. See you next time!");
    }
}

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
}