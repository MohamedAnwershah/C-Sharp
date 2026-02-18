using System.Text.Json.Serialization;
using System;
using System.Text.Json;

class Program
{
	static async Task Main()
	{
        HttpClient client = new();
        string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/2");
        ToDoList toDoList = JsonSerializer.Deserialize<ToDoList>(response);
        Console.WriteLine(toDoList.Title);
	}
}
public class ToDoList
{
    [JsonPropertyName("userId")] 
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("completed")]
    public bool IsCompleted { get; set; }
}