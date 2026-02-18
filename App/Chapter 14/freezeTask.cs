
/* Create a method DownloadFile() that prints "Downloading..."

Use Thread.Sleep(5000); to simulate a slow download.

Print "Finished!".

Call this in Main. */

using System;

class Program
{
	static void Main()
	{
		Download();
	}
    static void Download()
    {
        Console.WriteLine("Download Started!");
        Thread.Sleep(3000); //freezes the cpu
        Console.WriteLine("Finished!");
    }

}