namespace OnlineMvcStore.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;
  using OnlineMvcStore.Models;

  internal sealed class Configuration : DbMigrationsConfiguration<OnlineMvcStore.Models.OnlineMvcStoreDb>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(OnlineMvcStore.Models.OnlineMvcStoreDb context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data. E.g.
      //
      context.Categories.AddOrUpdate(
          new Category { Name = "Electronics" },
          new Category { Name = "Furnitures" },
          new Category { Name = "Clothing" },
          new Category { Name = "Cars" }
      );


      context.Manufacturers.AddOrUpdate(
        new Manufacturer { Name = "Apple" },
        new Manufacturer { Name = "Samsung" },
        new Manufacturer { Name = "Toyota" },
        new Manufacturer { Name = "Calvin Klein" },
        new Manufacturer { Name = "IKEA"}
      );
        
    }
  }
}
