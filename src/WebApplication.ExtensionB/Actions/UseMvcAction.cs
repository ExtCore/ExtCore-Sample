// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace ExtensionB.Actions
{
  public class UseMvcAction : IUseMvcAction
  {
    public int Priority => 2000;

    public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
    {
      routeBuilder.MapRoute(name: "Extension B", template: "extension-b", defaults: new { controller = "ExtensionB", action = "Index" });
    }
  }
}