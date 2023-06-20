using System.Net.Http;

namespace MiddlewarePipelineSRP
{
    /// <summary>
    /// MiddlewarePipeline class manages a collection of middlewares and executes them in a defined order.
    /// </summary>
    public class MiddlewarePipeline
    {
        private readonly List<IMiddleware> _middlewares = new();

        /// <summary>
        /// Adds a middleware to the pipeline.
        /// </summary>
        /// <param name="middleware">The middleware to be added.</param>
        public void AddMiddleware(IMiddleware middleware) => _middlewares.Add(middleware);

        /// <summary>
        /// Executes the middleware pipeline with the given context.
        /// </summary>
        /// <param name="context">The context to be processed by the middlewares.</param>
        /// <returns>A Task representing the async operation.</returns>
        public async Task ExecuteAsync(Context context)
        {
            int currentIndex = -1;

            async Task NextMiddleware()
            {
                currentIndex++;
                if (currentIndex < _middlewares.Count)
                    await _middlewares[currentIndex].InvokeAsync(context, NextMiddleware);
            }

            await NextMiddleware();
        }
    }
}