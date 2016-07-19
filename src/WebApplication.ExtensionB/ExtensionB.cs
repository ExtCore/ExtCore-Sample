// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WebApplication.ExtensionB
{
  public class ExtensionB : ExtensionBase
  {
    public override IEnumerable<KeyValuePair<int, Action<IRouteBuilder>>> UseMvcActionsByPriorities
    {
      get
      {
        return new Dictionary<int, Action<IRouteBuilder>>()
        {
          [2000] = routeBuilder =>
          {
            routeBuilder.MapRoute(name: "Extension B", template: "extension-b", defaults: new { controller = "ExtensionB", action = "Index" });
          }
        };
      }
    }
  }
}