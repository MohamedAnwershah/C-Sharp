/* Create a simple class Config with properties: public string Theme { get; set; } and public int Volume { get; set; }.

In Main, create an instance: var settings = new Config { Theme = "Dark", Volume = 80 };

Serialize it: Convert it to a JSON string.

Save it: Write that string to a file named settings.json in your Downloads folder. */

using System.Text.Json;

class Program
{
    static void Main()
	{
		var settings = new Config("Dark", 80);

        string json = JsonSerializer.Serialize(settings);
        Console.WriteLine(json);
	}
}

class Config(string theme, int volume)
{
    public string Theme {get; set;} = theme;
    public int Volume {get; set;} = volume;


    
}