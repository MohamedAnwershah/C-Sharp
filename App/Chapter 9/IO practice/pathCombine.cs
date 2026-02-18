using System;
using System.IO;

class Program
{
    static void Main()
    {
        string home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string downloads = Path.Combine(home, "Downloads");
        
        string filePath = Path.Combine(downloads, "test_file.txt");

        Console.WriteLine("Writing to: " + filePath);
        
        try 
        {
            File.WriteAllText(filePath, "If you see this, C# works!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
    }
}