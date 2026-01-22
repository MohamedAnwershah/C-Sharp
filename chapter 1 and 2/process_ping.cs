using System;
using System.Diagnostics;
class process
{
	
	public static void Main()
	{
	var psi = new ProcessStartInfo {
	FileName = "/bin/zsh",
	Arguments = "-c \"ping -c 3 google.com\"",
	RedirectStandardOutput = true,
	UseShellExecute = false,
	CreateNoWindow = true
};

using var p1 = Process.Start(psi);

string output = p1.StandardOutput.ReadToEnd();

Console.WriteLine(output);

if (output.Contains("0% packet loss")){
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("Internet is good!");
}
else{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Internet is bad!");
}
	}
}
//ping and condition checking
