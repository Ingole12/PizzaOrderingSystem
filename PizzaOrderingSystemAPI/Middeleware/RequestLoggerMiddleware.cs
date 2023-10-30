namespace PizzaOrderingSystemAPI.Middeleware
{
    public class RequestLoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Request: {context.Request.Path} at {DateTime.Now}");

            // Call the next middleware in the pipeline
            await _next(context);
        }
    }
}
