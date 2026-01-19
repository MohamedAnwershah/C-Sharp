using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization; 

public class Program
{
    public static void Main()
    {
        int uniqueCount = 0;
        int totalCount = 0;
        string filePath = "output1.json";
        
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string jsonString = File.ReadAllText(filePath);

        var typeInfo = AppJsonContext.Default.DictionaryStringDictionaryStringListString;
        var data = JsonSerializer.Deserialize(jsonString, typeInfo);

        foreach (var fileName in new List<string>(data.Keys))
        {
            
            var oldInnerDict = data[fileName];
            var newInnerDict = new Dictionary<string, List<string>>();
            int counter = 1;

            foreach (var entry in oldInnerDict)
            {
                newInnerDict.Add($"variant {counter}", entry.Value);
                counter++;
            }
            data[fileName] = newInnerDict;
        }
        var writeOptions = new JsonSerializerOptions { WriteIndented = true };
        foreach (var key in data.Keys)
        {
            uniqueCount += data[key].Count;
            foreach (var innerKey in data[key].Keys)
            {
                totalCount += data[key][innerKey].Count;
            }
        }

        Console.WriteLine($"\nTotal segment definitions across all versions: {totalCount}");
        Console.WriteLine($"\nTotal unique segment definitions across all versions: {uniqueCount}");
        var context = new AppJsonContext(writeOptions);
        
        string outputString = JsonSerializer.Serialize(data, context.DictionaryStringDictionaryStringListString);
        

        File.WriteAllText("data_renamed.json", outputString);
    }
}

[JsonSerializable(typeof(Dictionary<string, Dictionary<string, List<string>>>))]
internal partial class AppJsonContext : JsonSerializerContext
{
}