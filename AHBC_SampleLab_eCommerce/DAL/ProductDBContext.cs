using AHBC_SampleLab_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AHBC_SampleLab_eCommerce.DAL
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("ProductContext") 
        {

            Database.SetInitializer(new ProductDBInitalizer());
        }

        public DbSet<Product> Products { get; set; }

    }
}