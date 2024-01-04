using DocuPacker.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add DocuPacker Service
var contetRootPath = builder.Environment.ContentRootPath;
var isDevelopment = builder.Environment.IsDevelopment();
builder.Services.AddDocuPacker(options =>
{
    options.InputDir = Path.Combine(contetRootPath, "../Docs/md");
    options.OutputDir = Path.Combine(contetRootPath, "../Docs/json");
    if (isDevelopment)
    {
        options.IndexDir = Path.Combine(contetRootPath, "../docupacker.client/src/assets");
    }
    else
    {
        options.IndexDir = Path.Combine(contetRootPath, "../docupacker.client/dist/assets");
    }
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.MapFallbackToFile("/index.html");

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
