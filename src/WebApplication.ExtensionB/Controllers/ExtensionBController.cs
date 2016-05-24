// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using WebApplication.ExtensionB.Data.Abstractions;
using WebApplication.ExtensionB.ViewModels.ExtenstionB;

namespace WebApplication.ExtensionB.Controllers
{
  public class ExtensionBController : Controller
  {
    private IStorage storage;

    public ExtensionBController(IStorage storage)
    {
      this.storage = storage;
    }

    public ActionResult Index()
    {
      return this.View(new IndexViewModelBuilder().Build(this.storage.GetRepository<IItemRepository>().All()));
    }
  }
}