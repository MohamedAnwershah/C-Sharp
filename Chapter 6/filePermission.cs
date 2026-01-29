using System;

class Program
{
	static void Main()
	{
		var myAccess = Permission.Read | Permission.Write;

        Console.WriteLine(myAccess);
	}

}
[Flags] enum Permission
{
    Read=1, 
    Write=2, 
    Execute=4, 
    Delete=8
}
