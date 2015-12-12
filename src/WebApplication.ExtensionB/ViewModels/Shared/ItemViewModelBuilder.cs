// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using WebApplication.ExtensionB.Data.Models;

namespace WebApplication.ExtensionB.ViewModels.Shared
{
  public class ItemViewModelBuilder
  {
    public ItemViewModel Build(Item item)
    {
      return new ItemViewModel()
      {
        Name = item.Name
      };
    }
  }
}