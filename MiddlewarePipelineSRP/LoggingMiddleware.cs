namespace MiddlewarePipelineSRP
{
    /// <summary>
    /// LoggingMiddleware class implements the IMiddleware interface and logs the start and end of a request.
    /// </summary>
    public class LoggingMiddleware : IMiddleware
    {
        /// <summary>
        /// Invokes the logging middleware and logs the start and end of a request.
        /// </summary>
        /// <param name="context">The context containing information to be processed by the middleware.</param>
        /// <param name="next">The next middleware in the chain.</param>
        /// <returns>A Task representing the async operation.</returns>
        public async Task InvokeAsync(Context context, Func<Task> next)
        {
            // Perform logging functionality here
            Console.WriteLine("[LoggingMiddleware] Request started");

            // Call the next middleware in the pipeline
            await next();

            Console.WriteLine("[LoggingMiddleware] Request ended");
        }
    }
}