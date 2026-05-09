using CliniDesk.Business;

namespace CliniDesk.API
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (BusinessException ex)
            {
                context.Response.ContentType = "application/json";

                context.Response.StatusCode = ex switch
                {
                    InvalidCredentialsException => 401,
                    UserAlreadyExistsException => 409,
                    ValidationException => 400,
                    _ => 400
                };

                await context.Response.WriteAsJsonAsync(new
                {
                    error = ex.Message,
                });
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";

                context.Response.StatusCode = 500;

                await context.Response.WriteAsJsonAsync(new
                {
                    error = "Internal Server Error"
                });
            }
        }
    }
}
