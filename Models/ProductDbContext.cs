using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProductCategoryCRUDApplication.Models
{
    public partial class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("name=ProductDbContexts")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
