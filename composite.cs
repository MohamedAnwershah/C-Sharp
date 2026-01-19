using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using static System.IO.File;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        var hashDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

        string raw_versions = GetFiles("/Users/mohamedanwershah/Downloads/.zenbridge/std/X12"); 
        List<string> versions = raw_versions.Split(["\n"], StringSplitOptions.RemoveEmptyEntries).ToList();
       
        foreach (string curr_ver in versions)
        {
            string raw_segments = GetFiles($"/Users/mohamedanwershah/Downloads/.zenbridge/std/X12/{curr_ver}/CompositeElements");
            List<string> segments = raw_segments.Split(["\n"], StringSplitOptions.RemoveEmptyEntries).ToList(); 

            foreach (string s in segments) 
            {
                Console.WriteLine(s);
                string rawHash = GetSha(s, curr_ver); 
                

                string cleanHash = rawHash.Replace("sha256:", "").Trim();

                Console.WriteLine($"Version: {curr_ver} | Segment: {s} | Hash: {cleanHash}");
                if (!hashDictionary.ContainsKey(s))
                {
                    hashDictionary[s] = new Dictionary<string, List<string>>();
                }

                if (!hashDictionary[s].ContainsKey(cleanHash))
                {
                    hashDictionary[s][cleanHash] = new List<string>();
                }

                hashDictionary[s][cleanHash].Add(curr_ver);
                
            }
        }
        

        Console.WriteLine($"\nTotal unique segment definitions found: {hashDictionary.Count}");
        Console.WriteLine(hashDictionary);
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = AppJsonContext.Default

        };
        string json = JsonSerializer.Serialize(hashDictionary, options);

        Console.WriteLine(json);
        WriteAllText("output_comp_elem.json", json);
    }

    static string GetFiles(string n)
    {
        var psi = new ProcessStartInfo
        {
            FileName = "/bin/zsh",
            Arguments = "-c \"ls -1\"",
            UseShellExecute = false,
            CreateNoWindow = false,
            RedirectStandardOutput = true,
            WorkingDirectory = n
        };

        using var listing = Process.Start(psi);
        string raw_output = listing.StandardOutput.ReadToEnd();
        listing.WaitForExit();
        return raw_output;
    }


    static string GetSha(string filename, string version)
    {
        var psi = new ProcessStartInfo
        {
            FileName = "/bin/zsh",

            Arguments = $"-c \"dhall hash --file /Users/mohamedanwershah/Downloads/.zenbridge/std/X12/{version}/CompositeElements/{filename}\"",
            UseShellExecute = false,
            CreateNoWindow = false,
            RedirectStandardOutput = true,

            WorkingDirectory = $"/Users/mohamedanwershah/Downloads/.zenbridge/std/X12/{version}/CompositeElements"
        };

        using var p = Process.Start(psi);
        string sha = p.StandardOutput.ReadToEnd();
        p.WaitForExit();

        return sha;
    }
}
[JsonSerializable(typeof(Dictionary<string, Dictionary<string, List<string>>>))]
internal partial class AppJsonContext : JsonSerializerContext
{
}