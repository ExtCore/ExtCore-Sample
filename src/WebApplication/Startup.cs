// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

//using System;
using ExtCore.Data.EntityFramework;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http.Headers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Microsoft.Net.Http.Headers;

namespace WebApplication
{
  public class Startup
  {
    private IConfigurationRoot configurationRoot;
    private string extensionsPath;

    public Startup(IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory)
    {
      IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
        .SetBasePath(hostingEnvironment.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

      this.configurationRoot = configurationBuilder.Build();
      this.extensionsPath = hostingEnvironment.ContentRootPath + this.configurationRoot["Extensions:Path"];
      loggerFactory.AddConsole();
      loggerFactory.AddDebug();
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddExtCore(this.extensionsPath, this.configurationRoot["Extensions:IncludingSubpaths"] == true.ToString());

      /*
      services.Configure<StaticFileOptions>(options =>
        {
          options.OnPrepareResponse = (context) =>
          {
            ResponseHeaders headers = context.Context.Response.GetTypedHeaders();

            headers.CacheControl = new CacheControlHeaderValue()
            {
              MaxAge = TimeSpan.FromSeconds(60),
            };
          };
        }
      );
      */

      services.Configure<StorageContextOptions>(options =>
        {
          options.ConnectionString = this.configurationRoot.GetConnectionString("Default");
        }
      );
    }

    public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
    {
      if (hostingEnvironment.IsDevelopment())
      {
        applicationBuilder.UseDeveloperExceptionPage();
        applicationBuilder.UseDatabaseErrorPage();
        applicationBuilder.UseBrowserLink();
      }

      applicationBuilder.UseExtCore();
    }
  }
}