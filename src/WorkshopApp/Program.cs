var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ---------------------------------------------------------------
// Workshop participants: add your endpoints below this line!
// ---------------------------------------------------------------

app.MapGet("/", () => "Hello from the workshop! 👋");

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

// Example: add your own endpoint
// app.MapGet("/hello", () => "My custom endpoint!");

// ---------------------------------------------------------------

app.Run();
