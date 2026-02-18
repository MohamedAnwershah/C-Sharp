using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<RecipeService>();
var app = builder.Build();

app.MapGet("/api/recipes", async (RecipeService service) =>
{
    var recipes = await service.GetAllRecipesAsync();

    return Results.Ok(recipes);
});

app.MapGet("/api/recipes/search", async (RecipeService service, [FromQuery] int maxCalorie) =>
{
    var allRecipes = await service.GetAllRecipesAsync();

    var filteredList = allRecipes.Where(r => r.ExpectedCalories <= maxCalorie);

    return Results.Ok(filteredList);
}
);

app.MapPost("/api/recipes", async (RecipeSubmission newRecipe, RecipeService service) =>
{
    await service.AddRecipeAsync(newRecipe);
    return Results.Ok(new {message = "Successfully added!"});
}
);

app.Run();

class RecipeSubmission
{
    required public string RecipeName { get; set; }
    public int ExpectedCalories { get; set; }
}


class RecipeService
{
    private readonly string _dbPath = "recipes_db.json";

    public async Task<List<RecipeSubmission>> GetAllRecipesAsync()
    {

        if (!File.Exists(_dbPath))
        {
            return [];
        }
        string json = await File.ReadAllTextAsync(_dbPath);

        return JsonSerializer.Deserialize<List<RecipeSubmission>>(json) ?? new List<RecipeSubmission>();
    }

    public async Task AddRecipeAsync(RecipeSubmission newRecipe)
    {
        var existingRecipes = await GetAllRecipesAsync();

        existingRecipes.Add(newRecipe);

        await File.WriteAllTextAsync(_dbPath, JsonSerializer.Serialize(existingRecipes));
    }

}
