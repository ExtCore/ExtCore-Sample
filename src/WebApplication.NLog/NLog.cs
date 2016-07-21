using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Web;
using NLog.Extensions.Logging;

namespace WebApplication.NLog
{
    public class NLog : IExtension
    {
        private IConfigurationRoot configurationRoot;

        public string Name
        {
            get
            {
                return "Extension NLog";
            }
        }

        public IDictionary<int, Action<IRouteBuilder>> RouteRegistrarsByPriorities
        {
            get
            {
                return null;
            }
        }

        public void SetConfigurationRoot(IConfigurationRoot configurationRoot)
        {
            this.configurationRoot = configurationRoot;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
        }

        public void Configure(IApplicationBuilder app)
        {
            var loggerFactory = app.ApplicationServices.GetService<ILoggerFactory>();
            var env = app.ApplicationServices.GetService<IHostingEnvironment>();

            //add NLog to ASP.NET Core
            loggerFactory.AddNLog();

            //add NLog.Web
            app.AddNLogWeb();
            //needed for non-NETSTANDARD platforms: configure nlog.config in your project root
            //env.ConfigureNLog("nlog.config");
            loggerFactory.AddConsole();
        }
    }
}