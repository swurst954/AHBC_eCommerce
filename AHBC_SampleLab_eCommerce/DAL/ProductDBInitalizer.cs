using AHBC_SampleLab_eCommerce.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace AHBC_SampleLab_eCommerce.DAL
{
    internal class ProductDBInitalizer : CreateDatabaseIfNotExists<ProductDBContext>
    {
        protected override void Seed(ProductDBContext context)
        {
            var products = new List<Product>
            {
                new Product{ ItemId = 1, Name = "White T-Shirt", Descirption ="A cozy shirt without tags", Price = 5.00 },
                new Product{ ItemId = 2, Name = "Socks", Descirption ="Ankle Socks", Price = 5.00 },
                new Product{ ItemId = 3, Name = "Blue Hat", Descirption ="The coolest blue hat ever", Price = 15.00 },
                new Product{ ItemId = 4, Name = "Skateboard", Descirption ="Doing kickflips yo", Price = 50.00 },
                new Product{ ItemId = 5, Name = "Biker Helmet", Descirption ="It's got flames", Price = 25.00 },
                new Product{ ItemId = 6, Name = "Khaki Dockers", Descirption ="The pants not the containers", Price = 45.00 },

            };

            context.Products.AddRange(products);
            context.SaveChanges();

        }
    }
}