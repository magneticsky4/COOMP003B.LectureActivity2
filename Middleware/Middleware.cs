namespace COMP003B.LectureActivity2.Middleware
{
    public class RequestloggingMiddleware
    {
        private readonly requestloggingMiddleware _next;

        public RequestloggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async task Invoke(HttpContext context)
        {
            Console.WritLine($"[Request] {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WritLine($"[Response] {context.Response.StatusCode}");
        }
    }
}