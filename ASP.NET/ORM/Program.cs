using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- Required for Database operations
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<RecipeService>();
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

app.MapGet("/api/recipes", async (RecipeService service) =>
{
    var recipes = await service.GetAllRecipesAsync();

    return Results.Ok(recipes);
});

app.MapGet("/api/recipes/search", async (RecipeService service, [FromQuery] int maxCalorie) =>
{
    var filteredList = await service.SearchRecipesAsync(maxCalorie);

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
    required public int Id {get; set;}
    required public string RecipeName { get; set; }
    public int ExpectedCalories { get; set; }
}


class RecipeService(AppDbContext db)
{
    private readonly AppDbContext _db = db;

    public async Task<List<RecipeSubmission>> GetAllRecipesAsync()
    {
        return await _db.Recipes.ToListAsync();
    }

    public async Task AddRecipeAsync(RecipeSubmission newRecipe)
    {
        _db.Recipes.Add(newRecipe);
        await _db.SaveChangesAsync();
    }
    public async Task<List<RecipeSubmission>> SearchRecipesAsync(int maxCalorie)
    { 
        return await _db.Recipes.Where(r => r.ExpectedCalories <= maxCalorie).ToListAsync();
    }


}
class AppDbContext : DbContext
{
    public DbSet<RecipeSubmission> Recipes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=recipes.db");
    }
}
