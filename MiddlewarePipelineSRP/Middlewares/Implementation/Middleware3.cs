using MiddlewarePipelineSRP.Middlewares.Interface;

namespace MiddlewarePipelineSRP.Middlewares.Implementation
{
    /// <summary>
    /// Middleware3 class implements the IMiddleware interface and performs specific actions based on the context handler.
    /// </summary>
    public class Middleware3 : IMiddleware
    {
        /// <summary>
        /// Invokes the middleware and performs specific actions based on the context handler.
        /// </summary>
        /// <param name="context">The context containing information to be processed by the middleware.</param>
        /// <param name="next">The next middleware in the chain.</param>
        /// <returns>A Task representing the async operation.</returns>
        public async Task InvokeAsync(Context context, Func<Task> next)
        {
            // Perform logging functionality here
            Console.WriteLine("[Middleware3] Request started");

            if (context.Handler == ContextHandler.FaultyContext3)
            {
                throw new Exception("Faulty context");
            }

            if (context.Handler == ContextHandler.DummyType3)
            {
                Console.WriteLine("[Middleware3] terminated the request from the pipeline");
                return;
            }

            // Call the next middleware in the pipeline
            await next();

            Console.WriteLine("[Middleware3] Request ended");
        }
    }
}