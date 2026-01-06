namespace WebAPI.Extensions
{
    public static class AppExtensions
    {
       public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<Middlewares.ErrorHandlerMiddleare>();
        }
    }
}
