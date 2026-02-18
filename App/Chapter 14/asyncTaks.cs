/* Change Main to async Task Main.

Change Download to async Task Download.

Use await Task.Delay(3000). */

using System;

class Program
{
	static async Task Main()
	{
		await Download();
	}
	static async Task Download()
	{
		Console.WriteLine("Download Started!");
		await Task.Delay(3000);
		Console.WriteLine("Finished!");
	}

}