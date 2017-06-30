// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.ExtensionA.Controllers
{
  public class ExtensionAController : Controller
  {
    public ActionResult Index()
    {
      return this.View(ExtensionManager.GetInstances<IExtension>().Select(e => e.Name));
    }
  }
}