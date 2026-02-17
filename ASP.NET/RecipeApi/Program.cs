var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();




app.MapGet("/", () => "Hello World!");
app.MapGet("/api/recipe", () => {Recipe oatmeal = new()
{
    Title = "Oatmeal",
    Ingredients = ["Oats", "Milk", "Fruits"],
    PrepTime = 5
};
return oatmeal;
});

app.Run();

class Recipe
{
    required public string Title {get; set;}
    required public string[] Ingredients {get; set;}
    required public int PrepTime {get; set;}
}
