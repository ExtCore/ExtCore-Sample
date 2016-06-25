using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.ExtensionB.Models
{
    public class ItemContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Item> Items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Item>().HasKey(m => m.Id);
            //base.OnModelCreating(builder);

            builder.Entity<Item>(etb =>
            {
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id);
                etb.ForSqliteToTable("Items");
            }
            );
        }
    }
}
