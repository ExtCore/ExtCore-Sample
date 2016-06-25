// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc;
using WebApplication.ExtensionB.Repository;
using WebApplication.ExtensionB.ViewModels.ExtenstionB;

namespace WebApplication.ExtensionB.Controllers
{
  public class ExtensionBController : Controller
  {
    private IItemRepository _repository;

    public ExtensionBController(IItemRepository repository)
    {
      this._repository = repository;
    }

    public ActionResult Index()
    {
      return this.View(new IndexViewModelBuilder().Build(this._repository.All()));
    }
  }
}