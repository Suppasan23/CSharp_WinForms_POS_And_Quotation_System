using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WinForms_POS_And_Quotation_System
{
    public partial class PointOfSaleForm : Form
    {
        public PointOfSaleForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1180, 1250);
        }

        private void PointOfSaleForm_Load(object sender, EventArgs e)
        {

        }

        private void POS_SaveButton_Click(object sender, EventArgs e)
        {
            POS_PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 300, 700); //set paper size to Receipt
            if (POS_PrintPreviewDialog.ShowDialog() == DialogResult.OK) { POS_PrintPreviewDialog.Close(); }
        }

        
        private void POS_PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ร้านธีรภัทร", new Font("tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(110, 5));

            e.Graphics.DrawString("20/54 หมู่ 2 ถนนกาญจนวนิช", new Font("tahoma", 11), Brushes.Black, new Point(53, 25));
            e.Graphics.DrawString("ตำบลเขารูปช้าง อำเภอเมืองสงขลา ", new Font("tahoma", 11), Brushes.Black, new Point(40, 40));
            e.Graphics.DrawString("จังหวัดสงขลา 90000", new Font("tahoma", 11), Brushes.Black, new Point(83, 55));
            e.Graphics.DrawString("โทรศัพท์ 0-7444-7848", new Font("tahoma", 11), Brushes.Black, new Point(76, 70));

            e.Graphics.DrawString("เลขที่ใบเสร็จ #Sale05102022000010", new Font("tahoma", 11), Brushes.Black, new Point(5, 90));
            e.Graphics.DrawString("วันที่ 5 พฤษภาคม 2566 เวลา 10:35 น.", new Font("tahoma", 11), Brushes.Black, new Point(5, 105));

            e.Graphics.DrawString("===============================", new Font("tahoma", 11), Brushes.Black, new Point(5, 125));
            e.Graphics.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", new Font("tahoma", 11), Brushes.Black, new Point(51, 140));
            e.Graphics.DrawString("===============================", new Font("tahoma", 11), Brushes.Black, new Point(5, 155));

            e.Graphics.DrawString("สินค้า        ราคา        จำนวน        เงินรวม", new Font("tahoma", 11, FontStyle.Bold), Brushes.Black, new Point(5, 175));
            e.Graphics.DrawString("ลูกบอล       200          2           400", new Font("tahoma", 11), Brushes.Black, new Point(5, 190));
            e.Graphics.DrawString("ยาอม         10          1            10", new Font("tahoma", 11), Brushes.Black, new Point(5, 205));
            e.Graphics.DrawString("ลำโพง        800          1           800", new Font("tahoma", 11), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("น้ำยาทำค       50          2           100", new Font("tahoma", 11), Brushes.Black, new Point(5, 235));
            e.Graphics.DrawString("สบู่           30          2            60", new Font("tahoma", 11), Brushes.Black, new Point(5, 250));

        }
    }
}
