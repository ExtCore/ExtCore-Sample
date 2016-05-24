// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication
{
  public class Startup : ExtCore.WebApplication.Startup
  {
    public Startup(IHostingEnvironment hostingEnvironment)
      : base(hostingEnvironment)
    {
      IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
        .SetBasePath(hostingEnvironment.ContentRootPath)
        .AddJsonFile("config.json", optional: true, reloadOnChange: true);

      this.configurationRoot = configurationBuilder.Build();
    }

    public override void ConfigureServices(IServiceCollection services)
    {
      base.ConfigureServices(services);
    }

    public override void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
    {
      if (hostingEnvironment.IsDevelopment())
      {
        applicationBuilder.UseDeveloperExceptionPage();
        applicationBuilder.UseDatabaseErrorPage();
        applicationBuilder.UseBrowserLink();
      }

      else
      {

      }

      base.Configure(applicationBuilder, hostingEnvironment);
    }
  }
}