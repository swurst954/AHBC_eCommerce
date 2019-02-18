using System.Collections.Generic;
using System.Data.Entity;

namespace AHBC_SampleLab_Inventory.DAL
{
    internal class InventoryDBInitalizer : CreateDatabaseIfNotExists<InventoryDBContext>
    {
        protected override void Seed(InventoryDBContext context)
        {
            var inventories = new List<Models.Inventory>
            {

                new Models.Inventory{Id = 1, Quantity = 12},
                new Models.Inventory{Id = 2, Quantity = 14},
                new Models.Inventory{Id = 3, Quantity = 33},
                new Models.Inventory{Id = 4, Quantity = 65},
                new Models.Inventory{Id = 5, Quantity = 29},
                new Models.Inventory{Id = 6, Quantity = 13}

            };

            context.Inventories.AddRange(inventories);
            context.SaveChanges();

        }
    }
}