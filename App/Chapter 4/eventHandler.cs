using System;

class Program
{
	static void Main()
	{
		VideoUploader u1 = new();

        u1.VideoEncoded += (sender, title) => Console.WriteLine($"{sender} have uploaded : {title}");
        u1.Encode("How to get good at C#");
	}	
}

class VideoUploader
{
    public event EventHandler<string> VideoEncoded;

    public void Encode(string title)
    {
        Console.WriteLine("Encoding...");
        VideoEncoded?.Invoke(this, title);
    }
}