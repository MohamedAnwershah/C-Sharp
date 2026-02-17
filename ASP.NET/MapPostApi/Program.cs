var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("api/users", (UserProfile newUser) =>
{
    if (newUser.Age < 18)
    {
        return "Sorry, you are not eligible";
    }
    else
    {
        return $"Welcome, {newUser.Name}";
    }
});

app.Run();


class UserProfile
{
    required public string Name {get; set;}
    public int Age {get; set;}
}
