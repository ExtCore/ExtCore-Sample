// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using ExtCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WebApplication.ExtensionA
{
  public class ExtensionA : ExtensionBase
  {
    public override IEnumerable<KeyValuePair<int, Action<IRouteBuilder>>> UseMvcActionsByPriorities
    {
      get
      {
        return new Dictionary<int, Action<IRouteBuilder>>()
        {
          [1000] = routeBuilder =>
          {
            routeBuilder.MapRoute(name: "Extension A", template: "", defaults: new { controller = "ExtensionA", action = "Index" });
          }
        };
      }
    }
  }
}