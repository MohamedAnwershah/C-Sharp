using System;
using System.Diagnostics;



//method 1
var psi = new ProcessStartInfo();
psi.FileName = "/bin/zsh";
psi.Arguments = "-c \"ls -1\"";


//method 2
var psi2 = new ProcessStartInfo
{
    FileName = "/bin/zsh",
    Arguments = "-c \"ls -1\"",
    RedirectStandardOutput = true,
    
};

//method 3
ProcessStartInfo psi3 = new()
{
  FileName = "/bin/zsh",
  Arguments = "-c \"ls -1\"",
  RedirectStandardOutput = true,  
};