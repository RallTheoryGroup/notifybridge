var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => "healthy");
app.MapPost("/notify", (bool fail = false) =>
    fail ? Results.StatusCode(500) : Results.Accepted());
app.Run();
