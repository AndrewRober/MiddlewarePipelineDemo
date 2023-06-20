using MiddlewarePipelineSRP.Middlewares.Interface;

namespace MiddlewarePipelineSRP.Middlewares.Implementation
{
    /// <summary>
    /// Middleware that handles exceptions thrown by the subsequent middlewares in the pipeline.
    /// </summary>
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        /// <summary>
        /// Invokes the middleware, catches any exceptions thrown by the next middleware, and logs the exception message.
        /// </summary>
        /// <param name="context">The context containing information to be processed by the middleware.</param>
        /// <param name="next">The next middleware in the chain.</param>
        /// <returns>A Task representing the async operation.</returns>
        public async Task InvokeAsync(Context context, Func<Task> next)
        {
            try
            {
                Console.WriteLine("[ExceptionHandlingMiddleware] Request started");
                // Call the next middleware in the pipeline
                await next();

                Console.WriteLine("[ExceptionHandlingMiddleware] Request ended");
            }
            catch (Exception ex)
            {
                // Handle the exception and modify the response
                Console.WriteLine($"[ExceptionHandlingMiddleware] An exception occurred: {ex.Message}");
            }
        }
    }
}