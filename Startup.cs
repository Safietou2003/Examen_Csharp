using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CSHARP.Db;
using CSHARP.Models;
using CSHARP.Repository;
using CSHARP.Repository.Impl;
using CSHARP.Services;
using CSHARP.Services.Impl;

namespace CSHARP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Ajout des services sans Entity Framework pour Identity
            services.AddScoped<IClientRepository, ClientRepositoryListImpl>();
            services.AddScoped<IClientService, ClientServiceImpl>();
            services.AddScoped<ICommandeRepository, CommandeRepositoryImpl>();
            services.AddScoped<ICommandeService, CommandeServiceImpl>();
            services.AddScoped<IFactureRepository, FactureRepositoryImpl>();
            services.AddScoped<IFactureService, FactureServiceImpl>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
