using MiddlewarePipelineSRP;
using MiddlewarePipelineSRP.Middlewares.Implementation;

namespace MiddlewarePipelineDemo
{
    /// <summary>
    /// Main class of the educational project that demonstrates the middleware pipeline concept.
    /// </summary>
    internal class Program
    {
        static MiddlewarePipeline pipeline;

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        static async Task Main(string[] args)
        {
            Setup();
            await RunAsync();
        }

        /// <summary>
        /// Sets up the middleware pipeline with various custom middlewares.
        /// </summary>
        static void Setup()
        {
            pipeline = new MiddlewarePipeline();
            pipeline.AddMiddleware(new LoggingMiddleware());
            pipeline.AddMiddleware(new ExceptionHandlingMiddleware());
            pipeline.AddMiddleware(new Middleware1());
            pipeline.AddMiddleware(new Middleware2());
            pipeline.AddMiddleware(new Middleware3());
        }

        /// <summary>
        /// Runs the middleware pipeline with various context types and displays the results.
        /// </summary>
        /// <returns>A Task representing the async operation.</returns>
        static async Task RunAsync()
        {
            await Console.Out.WriteLineAsync("========DummyType1========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.DummyType1));
            await Console.Out.WriteLineAsync("==========================");
            await Console.Out.WriteLineAsync();
            await Console.Out.WriteLineAsync("========DummyType2========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.DummyType2));
            await Console.Out.WriteLineAsync("==========================");
            await Console.Out.WriteLineAsync();
            await Console.Out.WriteLineAsync("========DummyType3========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.DummyType3));
            await Console.Out.WriteLineAsync("==========================");
            await Console.Out.WriteLineAsync();
            await Console.Out.WriteLineAsync("========FaultyContext1========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.FaultyContext1));
            await Console.Out.WriteLineAsync("==========================");
            await Console.Out.WriteLineAsync();
            await Console.Out.WriteLineAsync("========FaultyContext2========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.FaultyContext2));
            await Console.Out.WriteLineAsync("==========================");
            await Console.Out.WriteLineAsync();
            await Console.Out.WriteLineAsync("========FaultyContext3========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.FaultyContext3));
            await Console.Out.WriteLineAsync("==========================");
            await Console.Out.WriteLineAsync();
            await Console.Out.WriteLineAsync("========Unknown========");
            await pipeline.ExecuteAsync(new Context(ContextHandler.Unknown));
            await Console.Out.WriteLineAsync("==========================");
        }
    }
}