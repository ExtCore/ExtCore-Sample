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
            services.AddEntityFrameworkInMemoryDatabase();
            services.AddDbContext<InMemoryContext>(option =>
                option.UseInMemoryDatabase()
            );
            
            /*using (var context = new InMemoryContext())
            {
                context.InMemorys.AddRange(new InMemory { Id = 1, Name = "Gobo" }, new InMemory { Id = 2, Name = "Monkey" }, new InMemory { Id = 3, Name = "Red" }, new InMemory { Id = 4, Name = "Wembley" }, new InMemory { Id = 5, Name = "Boober" }, new InMemory { Id = 6, Name = "Uncle Traveling Matt" });

                context.SaveChangesAsync();
            }*/
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
