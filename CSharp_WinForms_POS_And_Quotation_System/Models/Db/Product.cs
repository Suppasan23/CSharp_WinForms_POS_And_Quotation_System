using System;
using System.Collections.Generic;

namespace CSharp_WinForms_POS_And_Quotation_System.Models.Db;

public partial class Product
{
    public int Id { get; set; }

    public string Barcode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal CostPrice { get; set; }

    public decimal SellingPrice { get; set; }

    public int Quantity { get; set; }

    public string? UnitName { get; set; }

    public int CategoryId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;
}
