using System;
using System.Collections.Generic;

namespace CSharp_WinForms_POS_And_Quotation_System.Models.Db;

public partial class Sale
{
    public string ReceiptId { get; set; } = null!;

    public DateTime Date { get; set; }

    public decimal Total { get; set; }

    public decimal ReceiveMoney { get; set; }

    public decimal ChangeMoney { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
