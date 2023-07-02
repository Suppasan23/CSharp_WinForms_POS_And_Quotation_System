using System;
using System.Collections.Generic;

namespace CSharp_WinForms_POS_And_Quotation_System.Models.Db;

public partial class ProductCategory
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
