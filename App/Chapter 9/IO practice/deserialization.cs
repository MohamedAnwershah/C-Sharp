/* Read the content of settings.json into a string variable.

Convert that string back into a Config object using Deserialize.

Print the volume from the object (e.g., loadedConfig.Volume). */


using System;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
	static void Main()
	{
		string content = File.ReadAllText("settings.json");
        Config loadedData = JsonSerializer.Deserialize<Config>(content);

        Console.WriteLine($"Volume : {loadedData.Volume}");
	}
}
class Config(string theme, int volume)
{
    public string Theme {get; set;} = theme;
    public int Volume {get; set;} = volume;


    
}