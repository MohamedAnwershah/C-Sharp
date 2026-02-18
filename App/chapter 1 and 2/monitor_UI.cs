using System;
using System.Diagnostics;
using System.Threading;

class program{
	static void Main(){
		while(true){
		string date = RunCommand("date");
		string time = RunCommand("uptime");
	
		Console.Clear();
	
		Console.WriteLine($"Current date : {date}");
		Console.WriteLine($"Current time : {time}");
	
		Thread.Sleep(1000);
		}
	}
	static string RunCommand(string cmd){
	
	var psi = new ProcessStartInfo {
		FileName = "/bin/zsh",
		Arguments = $"-c \"{cmd}\"",
		RedirectStandardOutput = true,
		UseShellExecute = false,
		CreateNoWindow = false
	};
	
	using var p = Process.Start(psi);
	string output = p.StandardOutput.ReadToEnd();
	p.WaitForExit();
	return output;
}
}


