using FastEndpoints;
using FastEndpoints.Swagger;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.AddClosureSwaggerDoc();

// Service Dependency Injection

// App Configuration
var app = builder.Build();
app.UseFastEndpointsAndConfigurations();
app.UseOpenApi();
app.UseSwaggerUi3(s => s.ConfigureDefaults());
app.UseRedirectionOptions();

app.Run();