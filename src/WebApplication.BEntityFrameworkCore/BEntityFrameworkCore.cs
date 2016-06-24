using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebApplication.BEntityFrameworkCore.Models;

namespace WebApplication.BEntityFrameworkCore
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class BEntityFrameworkCore : IExtension
    {
        private IConfigurationRoot configurationRoot;

        public string Name
        {
            get
            {
                return "BEntityFrameworkCore";
            }
        }
        public void SetConfigurationRoot(IConfigurationRoot configurationRoot)
        {
            this.configurationRoot = configurationRoot;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<InMemoryContext>(option =>
                    option.UseInMemoryDatabase()
                );

            services
                .AddEntityFrameworkSqlite()
                .AddDbContext<SqliteContext>(option =>
                    option.UseSqlite(this.configurationRoot["Data:DefaultConnection:ConnectionString"])
                );
        }

        public void Configure(IApplicationBuilder app)
        {
        }

        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute(
                name: "BEntityFrameworkCore",
                template: "{controller=Home}/{action=Index}/{id?}");
                //template: "extension-b", defaults: new { controller = "ExtensionB", action = "Index" });

        }
    }
}
