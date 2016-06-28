using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.BEntityFrameworkCore.Models
{
    public class InMemoryContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
	    public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<InMemory> InMemorys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<InMemory>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
