using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ARPA20250326.AppWebMVC.Models;

public partial class Brand
{
    [Display(Name = "Id")]
    public int Id { get; set; }
    [Display(Name = "Nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string BrandName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
