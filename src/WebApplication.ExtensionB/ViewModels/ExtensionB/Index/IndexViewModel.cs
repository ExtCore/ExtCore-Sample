// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using WebApplication.ExtensionB.ViewModels.Shared;

namespace WebApplication.ExtensionB.ViewModels.ExtenstionB
{
  public class IndexViewModel
  {
    public IEnumerable<ItemViewModel> Items { get; set; }
  }
}