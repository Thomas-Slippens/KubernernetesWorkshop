var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var appName = Environment.GetEnvironmentVariable("APP_NAME") ?? "unknown";

// ---------------------------------------------------------------
// Workshop participants: add your endpoints below this line!
// ---------------------------------------------------------------

app.MapGet("/hello", () => $"Hello from {appName}!");

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

// Example: add your own endpoint
// app.MapGet("/hello", () => "My custom endpoint!");

// ---------------------------------------------------------------

app.Run();
