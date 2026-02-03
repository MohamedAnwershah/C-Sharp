
/* Change the URL to fetch all todos (.../todos).

Deserialize the response into a List<ToDoList>.

The Logic Test: Write a loop (or use LINQ) to count and print how many tasks are marked "Completed". */


using System.Text.Json.Serialization;
using System;
using System.Text.Json;

class Program
{
	static async Task Main()
	{
        HttpClient client = new();
        string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
        List<ToDoList> toDoList = [.. JsonSerializer.Deserialize<List<ToDoList>>(response).Where(x => x.IsCompleted == true)]; //directly creates a new list
        foreach (var toDo in toDoList)
        {
            
            Console.WriteLine($"User : {toDo.UserId}, Task : {toDo.Id}");
            
        }
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