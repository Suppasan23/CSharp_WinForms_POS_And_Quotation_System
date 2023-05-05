﻿using System;
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
            e.Graphics.DrawString("ร้านธีรภัทร์", new Font("tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(110, 5));
            //Space = 23
            e.Graphics.DrawString("20/54, หมู่.2 ถนนกาญจนวนิช", new Font("tahoma", 10), Brushes.Black, new Point(61, 28));//Space = 15
            e.Graphics.DrawString("ตำบลเขารูปช้าง อำเภอเมืองสงขลา ", new Font("tahoma", 10), Brushes.Black, new Point(48, 43));//Space = 15
            e.Graphics.DrawString("จังหวัดสงขลา 90000", new Font("tahoma", 10), Brushes.Black, new Point(88, 58));//Space = 15
            e.Graphics.DrawString("โทรศัพท์ 0-7444-7848", new Font("tahoma", 10), Brushes.Black, new Point(81, 73));//Space = 15
            //Space = 23
            e.Graphics.DrawString("เลขที่ใบเสร็จ", new Font("tahoma", 10), Brushes.Black, new Point(5, 96));
            e.Graphics.DrawString("#04758965305102022000010", new Font("tahoma", 10), Brushes.Black, new Point(90, 96));
            //Space = 23
            e.Graphics.DrawString("วันที่", new Font("tahoma", 10), Brushes.Black, new Point(5, 111));
            e.Graphics.DrawString("5 พฤษภาคม 2566", new Font("tahoma", 10), Brushes.Black, new Point(39, 111));
            e.Graphics.DrawString("เวลา", new Font("tahoma", 10), Brushes.Black, new Point(180, 111));
            e.Graphics.DrawString("10:35 น.", new Font("tahoma", 10), Brushes.Black, new Point(215, 111));
            //Space = 20
            e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 131));//Space = 15
            e.Graphics.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", new Font("tahoma", 10), Brushes.Black, new Point(51, 146));//Space = 15
            e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 161));//Space = 15
            //Space = 15
            e.Graphics.DrawString("สินค้า", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(5, 176));
            e.Graphics.DrawString("ราคา", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(100, 176));
            e.Graphics.DrawString("จำนวน", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(175, 176));
            e.Graphics.DrawString("เงินรวม", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(250, 176));
            //Space = 20
            e.Graphics.DrawString("ไม้ถูพื้น", new Font("tahoma", 9), Brushes.Black, new Point(5, 196));
            e.Graphics.DrawString("150", new Font("tahoma", 9), Brushes.Black, new Point(100, 196));
            e.Graphics.DrawString("2", new Font("tahoma", 9), Brushes.Black, new Point(175, 196));
            e.Graphics.DrawString("300", new Font("tahoma", 9), Brushes.Black, new Point(250, 196));
            //Space = 15
            e.Graphics.DrawString("ยาอม", new Font("tahoma", 9), Brushes.Black, new Point(5, 211));
            e.Graphics.DrawString("10", new Font("tahoma", 9), Brushes.Black, new Point(100, 211));
            e.Graphics.DrawString("1", new Font("tahoma", 9), Brushes.Black, new Point(175, 211));
            e.Graphics.DrawString("10", new Font("tahoma", 9), Brushes.Black, new Point(250, 211));
            //Space = 15
            e.Graphics.DrawString("ลำโพง", new Font("tahoma", 9), Brushes.Black, new Point(5, 226));
            e.Graphics.DrawString("800", new Font("tahoma", 9), Brushes.Black, new Point(100, 226));
            e.Graphics.DrawString("1", new Font("tahoma", 9), Brushes.Black, new Point(175, 226));
            e.Graphics.DrawString("800", new Font("tahoma", 9), Brushes.Black, new Point(250, 226));
            //Space = 15
            e.Graphics.DrawString("น้ำยาทำค", new Font("tahoma", 9), Brushes.Black, new Point(5, 241));
            e.Graphics.DrawString("50", new Font("tahoma", 9), Brushes.Black, new Point(100, 241));
            e.Graphics.DrawString("2", new Font("tahoma", 9), Brushes.Black, new Point(175, 241));
            e.Graphics.DrawString("100", new Font("tahoma", 9), Brushes.Black, new Point(250, 241));
            //Space = 15
            e.Graphics.DrawString("สบู่", new Font("tahoma", 9), Brushes.Black, new Point(5, 256));
            e.Graphics.DrawString("30", new Font("tahoma", 9), Brushes.Black, new Point(100, 256));
            e.Graphics.DrawString("2", new Font("tahoma", 9), Brushes.Black, new Point(175, 256));
            e.Graphics.DrawString("60", new Font("tahoma", 9), Brushes.Black, new Point(250, 256));
            //Space = 15
            e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 271));
            //Space = 15
            e.Graphics.DrawString("ยอดสุทธิ", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(5, 286));
            e.Graphics.DrawString("1,270", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(250, 286));
            //Space = 15
            e.Graphics.DrawString("=============================", new Font("tahoma", 10), Brushes.Black, new Point(2, 301));

        }
    }
}
