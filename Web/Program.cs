using Web.Extensions;
using Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.
services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();

// add http context accesor
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

#region Custom Configuration for services - this must be before the application build

DatabaseContext.AddDbContexts(ref services);
Swagger.AddSwaggerConfig(ref services);
Auth.AddAuthConfig(ref services, builder.Configuration);
Scoped.AddScopedConfig(ref services);
services.AddAutoMapper(typeof(AutoMapperProfile));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", ".NET Core Custom Template"));
}

app.UseHttpsRedirection();

#region Custom Configuration for app middlewares, cors and etc.

app.UseMiddleware<ExceptionMiddleware>();
Cors.AddCors(app);

#endregion

// auth configuration. UseAuthentication must come before UseAuthorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
