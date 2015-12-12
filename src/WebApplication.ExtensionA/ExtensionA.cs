// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Infrastructure;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.ExtensionA
{
  public class ExtensionA : IExtension
  {
    private IConfigurationRoot configurationRoot;

    public string Name
    {
      get
      {
        return "Extension A";
      }
    }

    public void SetConfigurationRoot(IConfigurationRoot configurationRoot)
    {
      this.configurationRoot = configurationRoot;
    }

    public void ConfigureServices(IServiceCollection services)
    {
    }

    public void Configure(IApplicationBuilder applicationBuilder)
    {
    }

    public void RegisterRoutes(IRouteBuilder routeBuilder)
    {
      routeBuilder.MapRoute(name: "Extension A", template: "", defaults: new { controller = "ExtensionA", action = "Index" });
    }
  }
}