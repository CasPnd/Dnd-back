using Dnd.BLL.Mapping;
using Dnd.DAL.Factories;
using Dnd.DAL.Factories.Interfaces;
using Dnd.DAL.Repositories.Implementation;
using Dnd.DAL.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace Dnd.API;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        #region DataBase

        services.AddSingleton<IDbConnectionFactory<SqlConnection>, MsConnectionFactory>();
        services.AddScoped<IPageRepository, PageRepository>();
        
        #endregion

        services.AddAntiforgery();

        //services.AddSignalR();
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddMediatR(cpf=>cpf.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
    {
        if (env.IsDevelopment())
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
        });
    }
}