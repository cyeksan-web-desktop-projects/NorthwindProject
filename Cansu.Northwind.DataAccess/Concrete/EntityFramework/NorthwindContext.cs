using Cansu.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Cansu.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BF6C0LE\SQLEXPRESS; Database=NORTHWND; Trusted_Connection=true");
        }
    }
}