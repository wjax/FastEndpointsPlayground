namespace Web.Extensions;

public static class LoggingExtensions
{
    public static void EndpointLogging(this ILogger logger, HttpContext context)
    {
        if (logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug(context.Request.Method + context.Request.Path.ToString() + context.Request.QueryString);
        }
    }
}