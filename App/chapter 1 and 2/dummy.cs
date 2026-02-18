using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Define your root path
        string rootPath = "/Users/mohamedanwershah/Downloads/.zenbridge/std/X12";

        // Check if directory exists to avoid crashes
        if (!Directory.Exists(rootPath))
        {
            Console.WriteLine($"Directory not found: {rootPath}");
            return;
        }

        // 1. Get all Version directories (4010, 5010, etc.)
        // System.IO handles the paths for you
        string[] versionDirectories = Directory.GetDirectories(rootPath);

        foreach (string versionDir in versionDirectories)
        {
            string setsDir = Path.Combine(versionDir, "Sets");

            // Skip if the "Sets" folder doesn't exist in that version
            if (!Directory.Exists(setsDir)) continue;

            // 2. Get all files in the Sets directory
            string[] files = Directory.GetFiles(setsDir);

            foreach (string filePath in files)
            {
                ChangeVersionInFile(filePath);
            }
        }
        
        Console.WriteLine("Update complete.");
    }

    static void ChangeVersionInFile(string filePath)
    {
        try 
        {
            // Read the file content
            string content = File.ReadAllText(filePath);

            // Use Regex to replace "Version=..." with "Version= 1234"
            // This is the C# equivalent of your sed command: s/Version=.*/Version= 1234/g
            string newContent = Regex.Replace(content, @"[Vv]ersion\s*=\s*""\d+""", "version = \"1234\"");

            // Only write back to disk if a change actually happened
            if (content != newContent)
            {
                File.WriteAllText(filePath, newContent);
                Console.WriteLine($"Updated: {filePath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing {filePath}: {ex.Message}");
        }
    }
}