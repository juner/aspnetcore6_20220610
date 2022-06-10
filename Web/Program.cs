var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var Logger = app.Logger;
var Configuration = app.Configuration;
Logger.LogInformation("configure ASPNETCORE_URLS:{urls}", Configuration.GetValue<string>("ASPNETCORE_URLS"));
Logger.LogInformation("environment ASPNETCORE_URLS:{urls}", Environment.GetEnvironmentVariable("ASPNETCORE_URLS"));
app.MapGet("/", () => "Hello World!");

app.Run();
