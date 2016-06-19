using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.ALogger
{
    /// <summary>
    /// read seaquence
    /// CommonModuler[Logging] -> MainModuer[MVC,WEB API,DB,Swagger]
    /// 
    /// May be not using to ExtCore.Data Moduers, because ConfigureService Method on
    /// Call service.AddEntityFramework or service.AddDBContext<IDBContext>()
    /// 
    /// Issue Autofac, LightInject, Catleproject.Core Can't Use IExtention
    /// Do Not Make 'Ruby on Rails' CoC like rule.
    /// </summary>
    public class ALogger : IExtension
    {
        private IConfigurationRoot configurationRoot;

        public string Name
        {
            get
            {
                return "ALogger";
            }
        }
        public void SetConfigurationRoot(IConfigurationRoot configurationRoot)
        {
            this.configurationRoot = configurationRoot;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalization();
        }

        public void Configure(IApplicationBuilder applicationBuilder)
        {
            //loggerFactory.AddConsole();
            //loggerFactory.AddDebug();
        }

        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
        }
    }
}
