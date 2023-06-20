namespace MiddlewarePipelineSRP
{
    /// <summary>
    /// Middleware1 class implements the IMiddleware interface and performs specific actions based on the context handler.
    /// </summary>
    public class Middleware1 : IMiddleware
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
            Console.WriteLine("[Middleware1] Request started");

            if(context.Handler == ContextHandler.FaultyContext1)
            {
                throw new Exception("Faulty context");
            }

            if(context.Handler == ContextHandler.DummyType1)
            {
                Console.WriteLine("[Middleware1] terminated the request from the pipeline");
                return;
            }    

            // Call the next middleware in the pipeline
            await next();

            Console.WriteLine("[Middleware1] Request ended");
        }
    }
}