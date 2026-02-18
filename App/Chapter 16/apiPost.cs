/* Pack: Create a C# Object (TodoItem).

Translate: Serialize it to a JSON String.

Stamp: Wrap it in StringContent (telling the server "This is JSON text").

Send: Use client.PostAsync. */


using System;
using System.Net.Http;
using System.Text; // For Encoding
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new();
        string url = "https://jsonplaceholder.typicode.com/todos";

        var myNewTask = new ToDoItem
        {
            UserId = 101,
            Title = "Mastering HTTP POST in C#",
            IsCompleted = false
        };
        string json = JsonSerializer.Serialize(myNewTask);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response =  await client.PostAsync(url, content);
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("success!");

            string reply = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Server's Reply : {reply}");


        }
        else
        {
            Console.WriteLine("Error!");
        }
        
    }
}

public class ToDoItem
{
    [JsonPropertyName("userId")] public int UserId { get; set; }
    [JsonPropertyName("title")] public string? Title { get; set; }
    [JsonPropertyName("completed")] public bool IsCompleted { get; set; }
}