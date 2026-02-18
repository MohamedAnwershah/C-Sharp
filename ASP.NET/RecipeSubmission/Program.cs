using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO.Pipelines;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string dbPath = "recipes_db.json";

app.MapGet("/api/recipes", () =>
{
    

    if (File.Exists(dbPath))
    {
        return File.ReadAllText(dbPath);
    }
    else
    {
        return "new List<RecipeSubmission>()";
    }
});

app.MapPost("/api/recipes", (RecipeSubmission newRecipe) =>
{

    List<RecipeSubmission> list = [];
    if (File.Exists(dbPath))
    {   
        string jsonDb = File.ReadAllText(dbPath);
        list = JsonSerializer.Deserialize<List<RecipeSubmission>>(jsonDb);
    
        list.Add(newRecipe);
    }
    else
    {
        list = [newRecipe];

    }
    var json = JsonSerializer.Serialize(list);
    File.WriteAllText(dbPath,json);
    return Results.Ok(new {message = "Success"});

});

app.Run();

class RecipeSubmission
{
    required public string RecipeName { get; set; }
    public int ExpectedCalories { get; set; }
}
