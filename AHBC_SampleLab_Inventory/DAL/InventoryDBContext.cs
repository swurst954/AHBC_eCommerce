using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AHBC_SampleLab_Inventory.DAL
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext() : base("InventoryContext")
        {

            Database.SetInitializer(new InventoryDBInitalizer());

        }

        public DbSet<Models.Inventory> Inventories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}