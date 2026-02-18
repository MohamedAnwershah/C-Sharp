using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using static System.IO.File;
using System.Text.Json.Serialization;

class program
{
    static void Main()
    {
        var hashDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

        string raw_versions = GetFiles("/Users/mohamedanwershah/Downloads/.zenbridge/std/X12");
        List<string> versions = raw_versions.Split(["\n"], StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (string ver in versions)
        {	
			string curr_loc = $"/Users/mohamedanwershah/Downloads/.zenbridge/std/X12/{ver}/CompositeElements";
            string raw_comps = GetFiles(curr_loc);
            List<string> comps = raw_comps.Split(["\n"], StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string comp in comps)
            {
                string rawhash = GetSha(comp, curr_loc);

                string cleanhash = rawhash.Replace("sha256:", "").Trim();

                Console.WriteLine($"Version: {ver} | Segment: {comp} | Hash: {cleanhash}");
                if (!hashDictionary.ContainsKey(comp)){
					hashDictionary[comp] = new Dictionary<string, List<string>>();
					}
				if (!hashDictionary[comp].ContainsKey(cleanhash)){
					hashDictionary[comp][cleanhash] = new List<string>();
				}
				
				hashDictionary[comp][cleanhash].Add(ver);
				
            }
			var options = new JsonSerializerOptions
        	{
            	WriteIndented = true,
            	TypeInfoResolver = AppJsonContext.Default

        	};
        	string json = JsonSerializer.Serialize(hashDictionary, options);

        	Console.WriteLine(json);
        	WriteAllText("output_comp_elem.json", json);
			

        }
    }
	static string GetFiles(string location){
		var psi = new ProcessStartInfo{
			FileName = "/bin/zsh",
			Arguments = "-c \"ls -1\"",
			RedirectStandardOutput = true,
			CreateNoWindow = true,
			UseShellExecute = false,
			WorkingDirectory =  location
		};
		
		using var get_files = Process.Start(psi);
		
		string files = get_files.StandardOutput.ReadToEnd();
		
		get_files.WaitForExit();
		
		return files;
	}
	static string GetSha(string comp, string location){
		var psi = new ProcessStartInfo{
			FileName = "/bin/zsh",
			Arguments = $"-c \"dhall hash --file {comp}",
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			WorkingDirectory = location
		};
		
		using var get_sha = Process.Start(psi);
		
		string sha = get_sha.StandardOutput.ReadToEnd();
		
		get_sha.WaitForExit();
		
		return sha;
	}
}
[JsonSerializable(typeof(Dictionary<string, Dictionary<string, List<string>>>))]
internal partial class AppJsonContext : JsonSerializerContext
{
}