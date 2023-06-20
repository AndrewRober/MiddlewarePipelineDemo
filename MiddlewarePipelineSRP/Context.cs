namespace MiddlewarePipelineSRP
{
    /// <summary>
    /// Context class contains information about the context handler type.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// The context handler type for the current context.
        /// </summary>
        public ContextHandler Handler { get; set; }

        /// <summary>
        /// Initializes a new instance of the Context class with the specified context handler.
        /// </summary>
        /// <param name="handler">The context handler for the current context.</param>
        public Context(ContextHandler handler) => this.Handler = handler;
    }
}