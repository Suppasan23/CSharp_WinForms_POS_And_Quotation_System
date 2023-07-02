using System;
using System.Collections.Generic;

namespace CSharp_WinForms_POS_And_Quotation_System.Models.Db;

public partial class SaleDetail
{
    public int Id { get; set; }

    public string ReceiptId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal ProductSellingPrice { get; set; }

    public int PickQuantity { get; set; }

    public decimal SubTotal { get; set; }

    public virtual Sale Receipt { get; set; } = null!;
}
