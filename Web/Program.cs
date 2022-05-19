using FastEndpoints.Swagger;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDocWithVersions();

// Service Dependency Injection

// App Configuration
var app = builder.Build();
app.UseAuthorization();
app.UseFastEndpointsAndConfigurations();
app.UseOpenApi();
app.UseSwaggerUi3(s => s.ConfigureDefaults());
app.UseRedirectionOptions();

app.Run();