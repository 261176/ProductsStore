using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public class ProductDataContext : DbContext
    {
        public ProductDataContext() : base("ProductConext")
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<UnitModel> Units { get; set; }
        public DbSet<CurrencyModel> Currency { get; set; }

    }
}
