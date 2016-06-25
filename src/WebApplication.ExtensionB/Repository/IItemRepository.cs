﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.ExtensionB.Models;

namespace WebApplication.ExtensionB.Repository
{
    public interface IItemRepository
    {
        IEnumerable<Item> All();
    }
}