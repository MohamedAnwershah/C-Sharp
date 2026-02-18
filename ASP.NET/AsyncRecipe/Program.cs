using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string dbPath = "recipes_db.json";
app.MapGet("/api/recipes", async () =>
{
    
    if (File.Exists(dbPath))
    {
        string json = await File.ReadAllTextAsync(dbPath);
        List<RecipeSubmission> result = JsonSerializer.Deserialize<List<RecipeSubmission>>(json) ?? new List<RecipeSubmission>();
        return Results.Ok(result);
    }
    else
    {
        return Results.Ok(new List<RecipeSubmission>());
    }
});

app.MapGet("/api/recipes/search", async ([FromQuery] int maxCalorie) =>
{
    

    if (!File.Exists(dbPath)) return Results.Ok(new List<RecipeSubmission>());

    string json = await File.ReadAllTextAsync(dbPath);
    List<RecipeSubmission> allRecipes = JsonSerializer.Deserialize<List<RecipeSubmission>>(json) ?? new List<RecipeSubmission>();

    var filteredList = allRecipes.Where(r => r.ExpectedCalories <= maxCalorie).ToList();
    return Results.Ok(filteredList);
    
});

app.MapPost("/api/recipes", async (RecipeSubmission newRecipe) =>
{

    List<RecipeSubmission> list = [];
    if (File.Exists(dbPath)) 
    {   
        string jsonDb = await File.ReadAllTextAsync(dbPath);
        list = JsonSerializer.Deserialize<List<RecipeSubmission>>(jsonDb) ?? new List<RecipeSubmission>();
    
        list.Add(newRecipe);
    }
    else
    {
        list = [newRecipe];

    }
    var json = JsonSerializer.Serialize(list);
    await File.WriteAllTextAsync(dbPath,json);
    return Results.Ok(new {message = "Success"});

});

app.Run();

class RecipeSubmission
{
    required public string RecipeName { get; set; }
    public int ExpectedCalories { get; set; }
}
