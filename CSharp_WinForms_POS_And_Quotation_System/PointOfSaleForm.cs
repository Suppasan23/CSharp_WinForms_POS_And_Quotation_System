using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
using Microsoft.EntityFrameworkCore;
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

        CsharpWinFormsPosAndQuotationSystemDbContext db = new CsharpWinFormsPosAndQuotationSystemDbContext();
        private bool toggleStage;

        public PointOfSaleForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1180, 1250);

            POS_DataGridView.ReadOnly = true;
            POS_DataGridView.MultiSelect = false;
            POS_DataGridView.AllowUserToAddRows = false;
            POS_DataGridView.AllowUserToDeleteRows = false;
            POS_DataGridView.AllowUserToResizeRows = false;
            POS_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            POS_DataGridView.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
            POS_DataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            POS_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //this.POS_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            POS_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            POS_DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);
            POS_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            POS_DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            POS_DataGridView.EnableHeadersVisualStyles = false;

            POS_DataGridView.DefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Regular);
            POS_DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            POS_DataGridView.ClearSelection();

            POS_BarcodeTextBox.MaxLength = 13;
            timer1.Start();
        }

        ////////////////////////////////////////// LOAD /////////////////////////////////////////////////
        private void PointOfSaleForm_Load(object sender, EventArgs e)
        {
            toggleStage = false;
            POS_AddNewSubjectButton.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            POS_DateTimeTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        /////////////////////////////////// ADD BUTTON CLICK /////////////////////////////////////////////
        private void POS_AddNewSubjectButton_Click(object sender, EventArgs e)
        {
            if (toggleStage)
            {
                enableState();
                toggleStage = false;
            }
            else
            {
                disableState();
                toggleStage = true;
            }
        }

        private void enableState()
        {
            POS_AddNewSubjectButton.Text = "ยกเลิก";
            POS_AddNewSubjectButton.BackColor = Color.Tomato;

            POS_BarcodeTextBox.Clear();
            POS_BarcodeTextBox.ReadOnly = false;
            POS_BarcodeTextBox.BackColor = Color.White;

            POS_DateTimeTextBox.ReadOnly = true;

            POS_SaleIDTextBox.Clear();
            POS_SaleIDTextBox.Text = generateTransactionID();
            POS_SaleIDTextBox.ReadOnly = true;

            POS_TransactionHistoryComboBox.Enabled = false;
            POS_TransactionHistoryComboBox.BackColor = SystemColors.Control;

            POS_ProductIDTextBox.Clear();
            POS_ProductIDTextBox.ReadOnly = true;

            POS_ProductNameTextBox.Clear();
            POS_ProductNameTextBox.ReadOnly = true;

            POS_CostPriceTextBox.Clear();
            POS_CostPriceTextBox.ReadOnly = true;

            POS_SellingPriceTextBox.Clear();
            POS_SellingPriceTextBox.ReadOnly = true;

            POS_UnitInStockTextBox.Clear();
            POS_UnitInStockTextBox.ReadOnly = true;

            POS_SellingUnitNumericUpDown.Enabled = false;
            POS_SellingUnitNumericUpDown.Minimum = 0;
            POS_SellingUnitNumericUpDown.Maximum = 0;
            POS_SellingUnitNumericUpDown.BackColor = Color.White;

            POS_DeleteButton.Enabled = false;

            POS_TotalAmountTextBox.Clear();
            POS_TotalAmountTextBox.ReadOnly = true;
            POS_TotalAmountTextBox.BackColor = Color.LightCyan;

            POS_ReceiveMoneyTextBox.Clear();
            POS_ReceiveMoneyTextBox.ReadOnly = true;
            POS_ReceiveMoneyTextBox.BackColor = Color.White;

            POS_ChangeMoneyTextBox.Clear();
            POS_ChangeMoneyTextBox.ReadOnly = true;
            POS_ChangeMoneyTextBox.BackColor = Color.MistyRose;

            POS_TransactionHistoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            POS_SaveButton.Enabled = false;
            POS_SaveButton.BackColor = SystemColors.ControlDark;
        }

        private void disableState()
        {
            POS_AddNewSubjectButton.Text = "รายการใหม่...";
            POS_AddNewSubjectButton.BackColor = Color.LightGreen;

            POS_BarcodeTextBox.Clear();
            POS_BarcodeTextBox.ReadOnly = true;
            POS_BarcodeTextBox.BackColor = SystemColors.Control;

            POS_DateTimeTextBox.ReadOnly = true;

            POS_SaleIDTextBox.Clear();
            POS_SaleIDTextBox.ReadOnly = true;

            POS_TransactionHistoryComboBox.Enabled = true;
            POS_TransactionHistoryComboBox.BackColor = Color.White;

            POS_ProductIDTextBox.Clear();
            POS_ProductIDTextBox.ReadOnly = true;

            POS_ProductNameTextBox.Clear();
            POS_ProductNameTextBox.ReadOnly = true;

            POS_CostPriceTextBox.Clear();
            POS_CostPriceTextBox.ReadOnly = true;

            POS_SellingPriceTextBox.Clear();
            POS_SellingPriceTextBox.ReadOnly = true;

            POS_UnitInStockTextBox.Clear();
            POS_UnitInStockTextBox.ReadOnly = true;

            POS_SellingUnitNumericUpDown.Enabled = false;
            POS_SellingUnitNumericUpDown.Minimum = 0;
            POS_SellingUnitNumericUpDown.Maximum = 0;
            POS_SellingUnitNumericUpDown.BackColor = SystemColors.Control;

            POS_DeleteButton.Enabled = false;

            POS_TotalAmountTextBox.Clear();
            POS_TotalAmountTextBox.ReadOnly = true;
            POS_TotalAmountTextBox.BackColor = SystemColors.Control;

            POS_ReceiveMoneyTextBox.Clear();
            POS_ReceiveMoneyTextBox.ReadOnly = true;
            POS_ReceiveMoneyTextBox.BackColor = SystemColors.Control;

            POS_ChangeMoneyTextBox.Clear();
            POS_ChangeMoneyTextBox.ReadOnly = true;
            POS_ChangeMoneyTextBox.BackColor = SystemColors.Control;

            POS_TransactionHistoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            POS_SaveButton.Enabled = false;
            POS_SaveButton.BackColor = SystemColors.ControlDark;
        }

        private string generateTransactionID()
        {
            var today = DateTime.Today;
            string currentDate = today.ToString("ddMMyy");

            var data = from s in db.Sales
                       where s.Date.Date.Equals(today)
                       select s;

            if (data.Any())
            {
                int ordinalNumber = data.Count() + 1;
                return Convert.ToString(currentDate + ordinalNumber.ToString("0000"));
            }
            else
            {
                int ordinalNumber = 1;
                return Convert.ToString(currentDate + ordinalNumber.ToString("0000"));
            }
        }

        //////////////////////////////////////////// BARCODE SEARCH 13 DIGIT GOTED//////////////////////////////////////
        private void POS_BarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (POS_BarcodeTextBox.Text.Trim().Length == 13)
            {
                try
                {
                    string getBarcode = POS_BarcodeTextBox.Text.Trim();
                    bool exists = db.Products.Any(i => i.Barcode == getBarcode); // Quick check if barcode exist in database or not

                    if (exists)
                    {
                        addProduct(getBarcode);
                        POS_BarcodeTextBox.Clear(); // Clear the textbox for the next input
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบสินค้า", "ขายสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ขายสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void POS_BarcodeTextBox_DoubleClick(object sender, EventArgs e)
        {
            POS_BarcodeTextBox.Clear();
        }

        private void addProduct(string receiveBarcode)
        {
            var data = (from i in db.Products
                        where i.Barcode.Trim() == receiveBarcode
                        select new
                        {
                            i.Id,
                            i.Barcode,
                            i.Name,
                            i.SellingPrice,
                            i.Quantity
                        }).FirstOrDefault();

            if (data != null)//Found
            {
                int barcodeExist = -1;

                for (int i = 0; i < POS_DataGridView.Rows.Count; i++) // Loop to find exist barcode
                {
                    if (POS_DataGridView.Rows[i].Cells[1].Value != null && POS_DataGridView.Rows[i].Cells[1].Value.ToString() == receiveBarcode.Trim())
                    {
                        barcodeExist = i;
                        break;
                    }
                }
            }
            else
            {

            }
        }

        ////////////////////////////////////////SAVE BUTTON CLICK///////////////////////////////////
        private void POS_SaveButton_Click(object sender, EventArgs e)
        {

        }


    }
}


//private void POS_SaveButton_Click(object sender, EventArgs e)
//{
//    POS_PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 300, 700); //set paper size to Receipt
//    if (POS_PrintPreviewDialog.ShowDialog() == DialogResult.OK) { POS_PrintPreviewDialog.Close(); }
//}



//private void POS_PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
//{
//    e.Graphics.DrawString("ร้านธีรภัทร์", new Font("tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(110, 5));
//    //Space = 23
//    e.Graphics.DrawString("20/54, หมู่.2 ถนนกาญจนวนิช", new Font("tahoma", 10), Brushes.Black, new Point(61, 28));//Space = 15
//    e.Graphics.DrawString("ตำบลเขารูปช้าง อำเภอเมืองสงขลา ", new Font("tahoma", 10), Brushes.Black, new Point(48, 43));//Space = 15
//    e.Graphics.DrawString("จังหวัดสงขลา 90000", new Font("tahoma", 10), Brushes.Black, new Point(88, 58));//Space = 15
//    e.Graphics.DrawString("โทรศัพท์ 0-7444-7848", new Font("tahoma", 10), Brushes.Black, new Point(81, 73));//Space = 15
//    //Space = 23
//    e.Graphics.DrawString("เลขที่ใบเสร็จ", new Font("tahoma", 10), Brushes.Black, new Point(5, 96));
//    e.Graphics.DrawString("#04758965305102022000010", new Font("tahoma", 10), Brushes.Black, new Point(90, 96));
//    //Space = 23
//    e.Graphics.DrawString("วันที่", new Font("tahoma", 10), Brushes.Black, new Point(5, 111));
//    e.Graphics.DrawString("5 พฤษภาคม 2566", new Font("tahoma", 10), Brushes.Black, new Point(39, 111));
//    e.Graphics.DrawString("เวลา", new Font("tahoma", 10), Brushes.Black, new Point(180, 111));
//    e.Graphics.DrawString("10:35 น.", new Font("tahoma", 10), Brushes.Black, new Point(215, 111));
//    //Space = 20
//    e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 131));//Space = 15
//    e.Graphics.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", new Font("tahoma", 10), Brushes.Black, new Point(51, 146));//Space = 15
//    e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 161));//Space = 15
//    //Space = 15
//    e.Graphics.DrawString("สินค้า", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(5, 176));
//    e.Graphics.DrawString("ราคา", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(100, 176));
//    e.Graphics.DrawString("จำนวน", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(175, 176));
//    e.Graphics.DrawString("เงินรวม", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(250, 176));
//    //Space = 20
//    e.Graphics.DrawString("ไม้ถูพื้น", new Font("tahoma", 9), Brushes.Black, new Point(5, 196));
//    e.Graphics.DrawString("150", new Font("tahoma", 9), Brushes.Black, new Point(100, 196));
//    e.Graphics.DrawString("2", new Font("tahoma", 9), Brushes.Black, new Point(175, 196));
//    e.Graphics.DrawString("300", new Font("tahoma", 9), Brushes.Black, new Point(250, 196));
//    //Space = 15
//    e.Graphics.DrawString("ยาอม", new Font("tahoma", 9), Brushes.Black, new Point(5, 211));
//    e.Graphics.DrawString("10", new Font("tahoma", 9), Brushes.Black, new Point(100, 211));
//    e.Graphics.DrawString("1", new Font("tahoma", 9), Brushes.Black, new Point(175, 211));
//    e.Graphics.DrawString("10", new Font("tahoma", 9), Brushes.Black, new Point(250, 211));
//    //Space = 15
//    e.Graphics.DrawString("ลำโพง", new Font("tahoma", 9), Brushes.Black, new Point(5, 226));
//    e.Graphics.DrawString("800", new Font("tahoma", 9), Brushes.Black, new Point(100, 226));
//    e.Graphics.DrawString("1", new Font("tahoma", 9), Brushes.Black, new Point(175, 226));
//    e.Graphics.DrawString("800", new Font("tahoma", 9), Brushes.Black, new Point(250, 226));
//    //Space = 15
//    e.Graphics.DrawString("น้ำยาทำค", new Font("tahoma", 9), Brushes.Black, new Point(5, 241));
//    e.Graphics.DrawString("50", new Font("tahoma", 9), Brushes.Black, new Point(100, 241));
//    e.Graphics.DrawString("2", new Font("tahoma", 9), Brushes.Black, new Point(175, 241));
//    e.Graphics.DrawString("100", new Font("tahoma", 9), Brushes.Black, new Point(250, 241));
//    //Space = 15
//    e.Graphics.DrawString("สบู่", new Font("tahoma", 9), Brushes.Black, new Point(5, 256));
//    e.Graphics.DrawString("30", new Font("tahoma", 9), Brushes.Black, new Point(100, 256));
//    e.Graphics.DrawString("2", new Font("tahoma", 9), Brushes.Black, new Point(175, 256));
//    e.Graphics.DrawString("60", new Font("tahoma", 9), Brushes.Black, new Point(250, 256));
//    //Space = 15
//    e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 271));
//    //Space = 15
//    e.Graphics.DrawString("ยอดสุทธิ", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(5, 286));
//    e.Graphics.DrawString("1,270", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(250, 286));
//    //Space = 15
//    e.Graphics.DrawString("=============================", new Font("tahoma", 10), Brushes.Black, new Point(2, 301));

//}