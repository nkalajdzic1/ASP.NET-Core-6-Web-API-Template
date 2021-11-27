namespace Web.Extensions
{
    public class Cors
    {
        public static void AddCors(IApplicationBuilder app)
        {
            app.UseCors(
                 options => options.WithOrigins(
                     "https://localhost:3000", // default localhost for React.js
                     "http://localhost:3000"
                     ).AllowAnyMethod().AllowAnyHeader()
            );
        }
    }
}
