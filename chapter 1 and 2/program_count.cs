using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

var psi = new ProcessStartInfo {
	FileName = "/bin/zsh",
	Arguments = "-c \"ls -1\"",
	RedirectStandardOutput = true,
	UseShellExecute = false,
	CreateNoWindow = false,
	WorkingDirectory = "/Users/mohamedanwershah/Desktop/C#/App"
	
};

using var p1 = Process.Start(psi);
string rawOutput = p1.StandardOutput.ReadToEnd();

p1.WaitForExit();
int i = 1;
List<string> AllFiles = rawOutput.Split(["\n"], StringSplitOptions.RemoveEmptyEntries).ToList();
Console.WriteLine("All Files :");
foreach (string c in AllFiles){
	Console.WriteLine($"{i} - {c}");
	i++;
}
 

int no_of_programs = 0;
i = 1;
Console.WriteLine("\nProgram Files :");
foreach (string c in AllFiles){
	if (c.Contains(".cs") && !c.Contains(".csproj")){ //.EndsWith can also be use here
		Console.WriteLine($"{i} - {c}");
		i++;
		no_of_programs++;
	}
}

Console.WriteLine($"\n\nTotal Number of Programs : {no_of_programs}");
 