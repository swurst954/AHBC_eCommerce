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
                new Product{ ItemId = 1, Name = "Water Bottle", Descirption ="Stores liquid", Price = 5.00 },
                new Product{ ItemId = 2, Name = "Fast Shoes", Descirption ="Shoes that make you faster", Price = 500.00 },
                new Product{ ItemId = 3, Name = "Slow Shoes", Descirption ="Shoes that make you slower", Price = 15.00 },
                new Product{ ItemId = 4, Name = "Metal Jacket", Descirption ="Jacket made out of metal material", Price = 50.00 },
                new Product{ ItemId = 5, Name = "Sunglasses", Descirption ="Blocks the sun from your eyes", Price = 25.00 },
                new Product{ ItemId = 6, Name = "Smart Phone", Descirption ="Can literally do almost evetything", Price = 450.00 },

            };

            context.Products.AddRange(products);
            context.SaveChanges();

        }
    }
}