// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.ExtensionB
{
  public class ExtensionB : IExtension
  {
    private IConfigurationRoot configurationRoot;

    public string Name
    {
      get
      {
        return "Extension B";
      }
    }

    public IDictionary<int, Action<IRouteBuilder>> RouteRegistrarsByPriorities
    {
      get
      {
        Dictionary<int, Action<IRouteBuilder>> routeRegistrarsByPriorities = new Dictionary<int, Action<IRouteBuilder>>();

        routeRegistrarsByPriorities.Add(
          2000,
          routeBuilder =>
          {
            routeBuilder.MapRoute(name: "Extension B", template: "extension-b", defaults: new { controller = "ExtensionB", action = "Index" });
          }
        );

        return routeRegistrarsByPriorities;
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
  }
}