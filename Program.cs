```csharp id="9n4p2x"
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware for logging
app.Use(async (context, next) =>
{
    Console.WriteLine($"{context.Request.Method} {context.Request.Path}");
    await next();
});

// User Model
List<User> users = new List<User>()
{
    new User { Id = 1, Name = "John", Email = "john@example.com" }
};

// GET all users
app.MapGet("/users", () =>
{
    return Results.Ok(users);
});

// GET user by id
app.MapGet("/users/{id}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);

    if (user == null)
        return Results.NotFound("User not found");

    return Results.Ok(user);
});

// POST add user
app.MapPost("/users", (User user) =>
{
    if (string.IsNullOrWhiteSpace(user.Name))
        return Results.BadRequest("Name is required");

    if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
        return Results.BadRequest("Valid email is required");

    user.Id = users.Count + 1;
    users.Add(user);

    return Results.Created($"/users/{user.Id}", user);
});

// PUT update user
app.MapPut("/users/{id}", (int id, User updatedUser) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);

    if (user == null)
        return Results.NotFound("User not found");

    user.Name = updatedUser.Name;
    user.Email = updatedUser.Email;

    return Results.Ok(user);
});

// DELETE user
app.MapDelete("/users/{id}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);

    if (user == null)
        return Results.NotFound("User not found");

    users.Remove(user);

    return Results.Ok("User deleted successfully");
});

app.Run();

// User Class
class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
}
```
