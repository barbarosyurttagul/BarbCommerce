using System;
using Barb.Core.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Barb.Data.Concrete.EntityFramework
{
	public class BarbCommerceContext : DbContext
	{
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public BarbCommerceContext(DbContextOptions<BarbCommerceContext> options) : base(options)
        {

        }
    }
}

