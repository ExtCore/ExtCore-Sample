// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.EntityFramework.Sqlite;
using Microsoft.EntityFrameworkCore;
using WebApplication.ExtensionB.Data.Models;

namespace WebApplication.ExtensionB.Data.EntityFramework.Sqlite
{
  public class ModelRegistrar : IModelRegistrar
  {
    public void RegisterModels(ModelBuilder modelbuilder)
    {
      modelbuilder.Entity<Item>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);
          etb.ForSqliteToTable("Items");
        }
      );
    }
  }
}