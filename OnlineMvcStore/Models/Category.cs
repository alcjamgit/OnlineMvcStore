using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineMvcStore.Models
{
  public class Category
  {
    public long Id { get; set; }
    [Required]
    [Display(Name ="Category Name")]
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public ICollection<Product> Products { get; set; }
  }
}