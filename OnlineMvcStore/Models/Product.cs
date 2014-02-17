using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMvcStore.Models
{
  public class Product
  {
    public long Id { get; set; }
    [Display(Name = "Product Name")]
    [Required]
    public string Name { get; set; }
    [Display(Name="Quantity On Hand")]
    public int QtyOnHand { get; set; }
    [Display(Name = "Unit Price")]
    public decimal? Price { get; set; }
    public virtual Category Category { get; set; }
    [Required]
    public virtual long CategoryId { get; set; }
    
    
  }
}