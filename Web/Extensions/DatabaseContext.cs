namespace Web.Extensions
{
    public class DatabaseContext
    {
        public static void AddDbContexts(ref IServiceCollection services)
        {
            // add your db contexts here
            // services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
