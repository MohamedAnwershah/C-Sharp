using System;
using System.Diagnostics;

string targetName = "TextEdit";

Process[] programs = Process.GetProcessesByName(targetName);

if (programs.Length == 0){
	Console.WriteLine($"Process - {targetName}, Not Found!"); //prints if not found
    return;
}

Process target = programs[0];

try {

	Console.WriteLine($"Terminating - ID : {target.Id}, {targetName}");
	target.Kill(); //kills the process (target)
	Console.WriteLine("Done!");
}
catch (Exception ex){
	Console.WriteLine($"Error : {ex.Message}"); //prints the error message given by catching any exception
}