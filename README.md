# Chain of Responsibility Design Pattern Demo in C#

This project demonstrates the Chain of Responsibility design pattern using a middleware pipeline in C#. We have implemented several middlewares and a pipeline to manage their execution order.

## Chain of Responsibility Design Pattern

The Chain of Responsibility pattern is a behavioral design pattern that allows an object to pass a request along a chain of potential handlers until one of them handles the request. The pattern allows multiple objects to handle the request without coupling the sender to the receiver.

In this demo, we use the middleware pipeline concept to implement the Chain of Responsibility pattern. Each middleware in the pipeline represents a handler, and the pipeline manages the order of execution.

## Project Structure

The project contains the following classes:

- `Program`: The main class of the project that sets up and runs the middleware pipeline.
- `IMiddleware`: An interface that defines a common contract for middlewares in the pipeline.
- `LoggingMiddleware`: A middleware that logs the start and end of a request.
- `Middleware1`, `Middleware2`, and `Middleware3`: Middlewares that perform specific actions based on the context handler.
- `ExceptionHandlingMiddleware`: A middleware that handles exceptions thrown by the subsequent middlewares in the pipeline.
- `ContextHandler`: An enumeration of different context handler types.
- `Context`: Class containing information about the context handler type.
- `MiddlewarePipeline`: Class that manages a collection of middlewares and executes them in a defined order.

## Demo

The main program sets up the middleware pipeline by adding various middleware instances. Then, it runs the pipeline with different context types, demonstrating how the middlewares behave based on the context handler.

## Usage

To run the demo, simply build and run the project using a C# compiler or an IDE like Visual Studio.

## Conclusion

This demo showcases the Chain of Responsibility design pattern using a middleware pipeline in C#. The pattern helps decouple the sender from the receiver, allowing multiple objects to handle the request without knowing the specifics of each handler. The middleware pipeline implementation provides a clean and efficient way to manage the order of execution for different middlewares, while also demonstrating how to handle exceptions and terminate the request in the pipeline.
