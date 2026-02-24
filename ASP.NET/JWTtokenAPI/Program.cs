using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- Required for Database operations
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;
using System.Security.Permissions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

var jwtKey = "ThisIsMySuperSecretKey123456789012";
var keyBytes = Encoding.UTF8.GetBytes(jwtKey);

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<RecipeService>();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true
    };
});
    
    builder.Services.AddAuthorization();
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/login", (LoginDto request) =>
{
    if(request.Username == "shah" && request.Password == "Pass1234")
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(
            [
                new Claim(ClaimTypes.Name, request.Username),
                new Claim(ClaimTypes.Role, "Admin")
            ]),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(keyBytes),
                SecurityAlgorithms.HmacSha256Signature
            )
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        return Results.Ok(new {Token = tokenString});
    }   

    return Results.Unauthorized();
    
});


app.MapGet("/api/recipes", async (RecipeService service) =>
{
    var recipes = await service.GetAllRecipesAsync();
    return Results.Ok(recipes);
}
);

app.MapGet("/api/recipes/search", async (RecipeService service, [FromQuery] int maxCalorie) =>
{
    var filteredList = await service.SearchRecipesAsync(maxCalorie);
    return Results.Ok(filteredList);
}
);

app.MapPost("/api/recipes", async (CreateRecipeDTO request, RecipeService service) =>
{
    await service.AddRecipeAsync(request);
    return Results.Ok(new {message = "Successfully added!"});
}
).RequireAuthorization();

app.Run();

class RecipeSubmission
{
    public int Id {get; set;}
    required public string RecipeName { get; set; }
    public int ExpectedCalories { get; set; }
}

class CreateRecipeDTO
{
    public required string RecipeName { get; set; }
    public int ExpectedCalories { get; set; }
}

class RecipeService(AppDbContext db)
{
    private readonly AppDbContext _db = db;
    public async Task<List<RecipeSubmission>> GetAllRecipesAsync()
    {
        return await _db.Recipes.ToListAsync();
    }

    public async Task AddRecipeAsync(CreateRecipeDTO request)
    {
        var newRecipe = new RecipeSubmission
        {
            RecipeName = request.RecipeName,
            ExpectedCalories = request.ExpectedCalories
        };
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
class LoginDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
