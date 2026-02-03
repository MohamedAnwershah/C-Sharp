using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;

class Program
{
    static string saveFile = "dungeon_save.json";
    static GameState state;
    static Random rng = new();

    static void Main()
    {
        LoadGame();
        
        while (state.IsAlive)
        {
            Console.Clear();
            Console.WriteLine($"=== {state.Name} (Lvl {state.Level}) ===");
            Console.WriteLine($"HP: {state.Health}/{state.MaxHealth} | Gold: {state.Gold}");
            Console.WriteLine($"Inventory: {string.Join(", ", state.Inventory)}");
            Console.WriteLine("1. Explore Dungeon");
            Console.WriteLine("2. Visit Shop");
            Console.WriteLine("3. Rest (Heal 50 HP - Cost 10 Gold)");
            Console.WriteLine("4. Save & Quit");
            Console.Write("\nChoose action: ");

            var input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.D1) Explore();
            else if (input == ConsoleKey.D2) Shop();
            else if (input == ConsoleKey.D3) Rest();
            else if (input == ConsoleKey.D4) { SaveGame(); return; }
        }

        Console.Clear();
        Console.WriteLine("GAME OVER");
        Console.WriteLine($"You died at Level {state.Level}.");
        File.Delete(saveFile); 
    }

    static void LoadGame()
    {
        try
        {
            if (File.Exists(saveFile))
            {
                string json = File.ReadAllText(saveFile);
                state = JsonSerializer.Deserialize<GameState>(json);
                Console.WriteLine($"Welcome back, {state.Name}!");
                Thread.Sleep(1000);
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        catch
        {
            Console.Write("Enter Hero Name: ");
            string name = Console.ReadLine();
            state = new GameState 
            { 
                Name = name, 
                Level = 1, 
                Health = 100, 
                MaxHealth = 100, 
                Gold = 0, 
                Inventory = ["Rusty Sword"],
                IsAlive = true 
            };
        }
    }

    static void SaveGame()
    {
        string json = JsonSerializer.Serialize(state);
        File.WriteAllText(saveFile, json);
        Console.WriteLine("\nGame Saved.");
        Thread.Sleep(500);
    }

    static void Explore()
    {
        Console.Clear();
        Console.WriteLine("Exploring...");
        Thread.Sleep(1000);

        int roll = rng.Next(1, 101);

        if (roll < 30)
        {
            Console.WriteLine("You found a treasure chest!");
            int goldFound = rng.Next(10, 50);
            state.Gold += goldFound;
            Console.WriteLine($"You gained {goldFound} Gold!");
            
            if (rng.Next(0, 2) == 1)
            {
                state.Inventory.Add("Gemstone");
                Console.WriteLine("You found a Gemstone!");
            }
        }
        else
        {
            Combat();
        }

        Console.WriteLine("\nPress any key...");
        Console.ReadKey();
    }

    static void Combat()
    {
        int enemyHp = 20 * state.Level;
        int enemyDmg = 5 * state.Level;
        string enemyName = "Skeleton";

        Console.WriteLine($"A {enemyName} appears!");

        while (enemyHp > 0 && state.Health > 0)
        {
            Console.WriteLine($"\nEnemy HP: {enemyHp} | Your HP: {state.Health}");
            Console.WriteLine("(A)ttack  (H)eal (Potion)");
            var move = Console.ReadKey(true).Key;

            if (move == ConsoleKey.A)
            {
                int dmg = rng.Next(10, 20) + (state.Level * 2);
                enemyHp -= dmg;
                Console.WriteLine($"You hit for {dmg} damage!");
            }
            else if (move == ConsoleKey.H)
            {
                if (state.Inventory.Contains("Potion"))
                {
                    state.Health = Math.Min(state.Health + 50, state.MaxHealth);
                    state.Inventory.Remove("Potion");
                    Console.WriteLine("Used Potion! +50 HP.");
                }
                else
                {
                    Console.WriteLine("No Potions left!");
                    continue; 
                }
            }

            if (enemyHp > 0)
            {
                int hit = rng.Next(enemyDmg - 2, enemyDmg + 3);
                state.Health -= hit;
                Console.WriteLine($"Enemy hits you for {hit} damage!");
            }
        }

        if (state.Health <= 0)
        {
            state.IsAlive = false;
        }
        else
        {
            Console.WriteLine("Victory!");
            state.Gold += 20;
            state.Level++;
            state.MaxHealth += 10;
            state.Health = state.MaxHealth; 
        }
    }

    static void Shop()
    {
        Console.Clear();
        Console.WriteLine($"SHOP | Gold: {state.Gold}");
        Console.WriteLine("1. Buy Potion (50 Gold)");
        Console.WriteLine("2. Leave");

        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.D1)
        {
            if (state.Gold >= 50)
            {
                state.Gold -= 50;
                state.Inventory.Add("Potion");
                Console.WriteLine("Bought Potion.");
            }
            else
            {
                Console.WriteLine("Not enough gold.");
            }
        }
        Thread.Sleep(500);
    }

    static void Rest()
    {
        if (state.Gold >= 10)
        {
            state.Gold -= 10;
            state.Health = Math.Min(state.Health + 50, state.MaxHealth);
            Console.WriteLine("\nYou rested at the inn. HP Restored.");
        }
        else
        {
            Console.WriteLine("\nNot enough gold to rest.");
        }
        Thread.Sleep(1000);
    }
}

public class GameState
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public List<string> Inventory { get; set; }
    public bool IsAlive { get; set; }
}