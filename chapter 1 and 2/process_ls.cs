using System;
using System.Diagnostics;  

//using ls command to get the items in a list and printing them out in the console

class process_ls
{
    static void Main()
    {
        
        var psi = new ProcessStartInfo
        {
            FileName = "/bin/zsh", //opens z shell
            Arguments = "-c \"ls -1\"", //ls -1, ls -la, ls -l - different operations
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = "/Users/mohamedanwershah/Desktop" // Set your folder here
        };

        using var process = new Process { StartInfo = psi };
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

    
        List<string> files = output.Split(['\n'], StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (var file in files)
        {
            Console.WriteLine($"Found: {file}");
        }
    }
}