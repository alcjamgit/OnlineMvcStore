using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineMvcStore.Models
{
  public class OnlineMvcStoreDb: DbContext
  {
    public OnlineMvcStoreDb()
      : base("OnlineMvcStoreDb")
    {
       
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

  }
  
}