using SalesStore.Entities;

namespace SalesStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesStore.Entities.SalesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SalesStore.Entities.SalesDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.ItemBrands.AddOrUpdate(d => d.itemBrandCode,
                                          new ItemBrand() { itemBrandCode = 101, brandName = "Nike", isActive = true },
                                           new ItemBrand() { itemBrandCode = 102, brandName = "Adidas", isActive = true },
                                            new ItemBrand() { itemBrandCode = 103, brandName = "RedTape", isActive = true }
                                            );
        }
    }
}
