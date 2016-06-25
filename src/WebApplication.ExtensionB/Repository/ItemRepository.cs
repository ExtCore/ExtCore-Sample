// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication.ExtensionB.Models;

namespace WebApplication.ExtensionB.Repository
{
    public class ItemRepository : IItemRepository
    {
        private ItemContext _context;
        public ItemRepository(ItemContext context)
        {
            _context = context;
        }
        public IEnumerable<Item> All()
        {
            return _context.Items.OrderBy(i => i.Name);
        }
    }
}