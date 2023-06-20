namespace MiddlewarePipelineSRP.Middlewares.Interface
{
    /// <summary>
    /// IMiddleware interface defines a common contract for middlewares in the pipeline.
    /// </summary>
    public interface IMiddleware
    {
        /// <summary>
        /// Invokes the middleware and processes the context.
        /// </summary>
        /// <param name="context">The context containing information to be processed by the middleware.</param>
        /// <param name="next">The next middleware in the chain.</param>
        /// <returns>A Task representing the async operation.</returns>
        Task InvokeAsync(Context context, Func<Task> next);
    }
}