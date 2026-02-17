
/* Create a new class blueprint called RecipeSubmission with two properties: RecipeName (string) and ExpectedCalories (int).

Create a new endpoint using app.MapPost("/api/submit").

The endpoint must accept your RecipeSubmission object.

Inside the endpoint, return a friendly string acknowledging the submission, like: "NutriChef AI has received 'Protein Oats'. We will analyze the 300 calories."

Create a requests.http file in VS Code and write a POST request to send JSON data to your new endpoint.

Click "Send Request" in the .http file. */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/api/recipes", (RecipeSubmission recipe) =>
{
    if(recipe is not null)
    {
        return Results.Ok(new {message = $"Submitted your recipe : {recipe.RecipeName}, Calories : {recipe.ExpectedCalories}"});
    }
    else
    {
        return Results.BadRequest(new {message = "No recipes found!"});
    }
    
});

app.Run();


class RecipeSubmission
{
    required public string RecipeName {get; set;}
    public int ExpectedCalories {get; set;}
}