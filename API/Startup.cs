using Microsoft.OpenApi.Models;
using Module.Catalog;
using Shared.Infrastructure.Extensions;
using System.Configuration;

namespace API
{
    public class Startup
    {
       
            public IConfiguration configRoot { get; }
            public Startup(IConfiguration configuration)
            {
                configRoot = configuration;
            }
            public void ConfigureServices(IServiceCollection services)
            {
                 services.AddSharedInfrastructure(configRoot);
                 services.AddCatalogModule(configRoot);
                 services.AddSwaggerGen(c =>
                 { 
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "POSAPI", Version = "v1" });
                 });
            }
            public void Configure(WebApplication app, IWebHostEnvironment env)
            {
               // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                  app.UseSwagger();
                  app.UseSwaggerUI();
                }
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseRouting();
                app.UseAuthorization();
                app.MapControllers();
                app.Run();
            }
        }
    
}
