using FastEndpoints;
using Microsoft.AspNetCore.Rewrite;

namespace Web.Extensions;

public static class WebApplicationExtensions
{
    public static void UseRedirectionOptions(this WebApplication app)
    {
        app.UseHttpsRedirection();
        var option = new RewriteOptions();
        option.AddRedirect("^$", "swagger");
        app.UseRewriter(option);
    }

    public static void UseFastEndpointsAndConfigurations(this WebApplication app)
    {
        if (app.Environment.IsProduction())
        {   
            app.UseDefaultExceptionHandler(); // Sanitize exceptions so we dont leak internal code exceptions to the api.
        }
        
        app.UseFastEndpoints(c =>
        {
            c.ShortEndpointNames = false;
            c.VersioningOptions = o =>
            {
                o.Prefix = "v";
                o.SuffixedVersion = false;
                o.DefaultVersion = 1;
            };
            c.GlobalEndpointOptions = (endpoint, builder) =>
            {
                builder
                    .ProducesValidationProblem()
                    .Produces(StatusCodes.Status500InternalServerError);
            };
        });
    }
}
