// This is a reference copy of Program.cs for the Dapr service invocation exercise.
// Copy the two new endpoints into your src/WorkshopApp/Program.cs.

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();

var app = builder.Build();

// Your pod's name — injected automatically by the platform via Helm
var appName = Environment.GetEnvironmentVariable("APP_NAME") ?? "unknown";

// ---------------------------------------------------------------
// Workshop participants: add your endpoints below this line!
// ---------------------------------------------------------------

app.MapGet("/", () => "Hello from the workshop! 👋");

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

// --- Exercise: Dapr service invocation ---

// Step 1: expose /hello so other participants can call you via Dapr
app.MapGet("/hello", () => $"Hello from {appName}! 👋");

// Step 2: call another participant's /hello endpoint via Dapr
// Try it: https://<yourname>.kubernetes.soulsseeker.com/call/jurgen
app.MapGet("/call/{name}", async (string name, IHttpClientFactory factory) =>
{
    var client = factory.CreateClient();
    try
    {
        // Dapr service invocation format: <appId>.<namespace>
        var url = $"http://localhost:3500/v1.0/invoke/{name}.workshop-{name}/method/hello";
        var response = await client.GetStringAsync(url);
        return Results.Ok(new { from = appName, to = name, message = response });
    }
    catch (Exception ex)
    {
        return Results.Problem($"Could not reach '{name}': {ex.Message}");
    }
});

// ---------------------------------------------------------------

app.Run();
