using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();
app.UseCors();

var questions = new[]
{
    new { Id = 1, Category = "Behavioral", Text = "Tell me about a time you faced a challenge." },
    new { Id = 2, Category = "Technical", Text = "Explain a technical concept simply." },
    new { Id = 3, Category = "System Design", Text = "How would you design a URL shortener?" }
};

app.MapGet("/api/questions", () => questions);
app.MapGet("/api/questions/{id}", (int id) => questions.FirstOrDefault(q => q.Id == id));

app.MapPost("/api/sessions", () => Results.Ok(new { SessionId = Guid.NewGuid(), Status = "Started" }));

app.Run();
