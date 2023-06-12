using System;
using System.Collections.Generic;

namespace CSharp_WinForms_POS_And_Quotation_System.Models.Db;

public partial class SaleDetail
{
    public string ReceiptId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public int ProductQuantity { get; set; }

    public decimal SubTotal { get; set; }

    public virtual Sale Receipt { get; set; } = null!;
}
