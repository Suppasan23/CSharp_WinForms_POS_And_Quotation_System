using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            string[] headerCol = new[] { "ที่", "รหัสสินค้า", "ชื่อสินค้า", "CostPrice", "ราคาขาย", "UnitInStock", "จำนวนที่ซื้อ", "Subtotal" };
            POS_DataGridView.ColumnCount = headerCol.Length;

            for (var i = 0; i < POS_DataGridView.Columns.Count; i++)
            {
                POS_DataGridView.Columns[i].HeaderText = headerCol[i];
                POS_DataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                POS_DataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //0=ที่, 1=รหัสสินค้า, 2=ชื่อสินค้า, 3=CostPrice, 4=ราคาขาย, 5=UnitInStock, 6=จำนวนที่ซื้อ, 7=Subtotal
            POS_DataGridView.Columns[0].Width = 40;
            POS_DataGridView.Columns[1].Width = 150;
            POS_DataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            POS_DataGridView.Columns[3].Visible = false;
            POS_DataGridView.Columns[4].Width = 150;
            POS_DataGridView.Columns[5].Visible = false;
            POS_DataGridView.Columns[6].Width = 150;
            POS_DataGridView.Columns[7].Width = 150;
            POS_DataGridView.Columns[7].DefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);

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

            POS_DataGridView.Rows.Clear();

            POS_BarcodeTextBox.Clear();
            POS_BarcodeTextBox.ReadOnly = false;
            POS_BarcodeTextBox.BackColor = Color.White;

            POS_DateTimeTextBox.ReadOnly = true;

            POS_SaleIDTextBox.Clear();
            POS_SaleIDTextBox.Text = generateSaleID();
            POS_SaleIDTextBox.ReadOnly = true;

            POS_TransactionHistoryButton.Enabled = false;
            POS_TransactionHistoryButton.BackColor = SystemColors.Control;
            LastTenSellingHistory(false);

            POS_ProductBarcodeTextBox.Clear();
            POS_ProductBarcodeTextBox.ReadOnly = true;

            POS_ProductNameTextBox.Clear();
            POS_ProductNameTextBox.ReadOnly = true;

            POS_CostPriceTextBox.Clear();
            POS_CostPriceTextBox.ReadOnly = true;

            POS_SellingPriceTextBox.Clear();
            POS_SellingPriceTextBox.ReadOnly = true;

            POS_UnitInStockTextBox.Clear();
            POS_UnitInStockTextBox.ReadOnly = true;

            POS_SellingUnitNumericUpDown.Enabled = false;
            POS_SellingUnitNumericUpDown.ReadOnly = true;
            POS_SellingUnitNumericUpDown.Minimum = 0;
            POS_SellingUnitNumericUpDown.Maximum = int.MaxValue;
            POS_SellingUnitNumericUpDown.BackColor = Color.White;

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

            POS_SaveButton.Enabled = false;
            POS_SaveButton.BackColor = SystemColors.ControlDark;
        }

        private void disableState()
        {
            POS_AddNewSubjectButton.Text = "รายการใหม่...";
            POS_AddNewSubjectButton.BackColor = Color.LightGreen;

            POS_DataGridView.Rows.Clear();

            POS_BarcodeTextBox.Clear();
            POS_BarcodeTextBox.ReadOnly = true;
            POS_BarcodeTextBox.BackColor = SystemColors.Control;

            POS_DateTimeTextBox.ReadOnly = true;

            POS_SaleIDTextBox.Clear();
            POS_SaleIDTextBox.ReadOnly = true;

            POS_TransactionHistoryButton.Enabled = true;
            POS_TransactionHistoryButton.BackColor = Color.LightGoldenrodYellow;
            LastTenSellingHistory(true);

            POS_ProductBarcodeTextBox.Clear();
            POS_ProductBarcodeTextBox.ReadOnly = true;

            POS_ProductNameTextBox.Clear();
            POS_ProductNameTextBox.ReadOnly = true;

            POS_CostPriceTextBox.Clear();
            POS_CostPriceTextBox.ReadOnly = true;

            POS_SellingPriceTextBox.Clear();
            POS_SellingPriceTextBox.ReadOnly = true;

            POS_UnitInStockTextBox.Clear();
            POS_UnitInStockTextBox.ReadOnly = true;

            POS_SellingUnitNumericUpDown.Enabled = false;
            POS_SellingUnitNumericUpDown.ReadOnly = true;
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

            POS_SaveButton.Enabled = false;
            POS_SaveButton.BackColor = SystemColors.ControlDark;
        }

        private string generateSaleID() // GENERATE SALE ID
        {
            var today = DateTime.Today;
            string currentDate = today.ToString("ddMMyyyy");

            var data = from s in db.Sales
                       where s.Date.Date.Equals(today)
                       select s;

            if (data.Any())
            {
                int ordinalNumber = data.Count() + 1;
                return Convert.ToString(currentDate + ordinalNumber.ToString("00000"));
            }
            else
            {
                int ordinalNumber = 1;
                return Convert.ToString(currentDate + ordinalNumber.ToString("00000"));
            }
        }

        private void LastTenSellingHistory(bool state) // LOAD LAST TEN SELLING HISTORY
        {
            if (state)
            {
                var data = (from h in db.Sales
                            orderby h.Date descending
                            select new { h.ReceiptId }).Take(10).ToArray();

                if (data.Any())
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i == 0)
                        {
                            contextMenuStrip1.Items.Add($"{data[i].ReceiptId} (ใบเสร็จล่าสุด)");
                            continue;
                        }
                        contextMenuStrip1.Items.Add($"{data[i].ReceiptId} (ใบเสร็จเก่าที่ {i})");
                    }
                }
            }
            else
            {
                contextMenuStrip1.Items.Clear();
            }
        }

        //////////////////////////////////////////// BARCODE SEARCH 13 DIGIT GOTTEN//////////////////////////////////////
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
                        addProductToSellingList(getBarcode);
                        POS_BarcodeTextBox.Clear(); // Clear the textbox for the next input
                        POS_BarcodeTextBox.Focus(); // Focus textbox for the next inpt
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
            POS_BarcodeTextBox.Focus();
        }

        /////////////////////////////////////////// DATAGRIDVIEW SELETION CHANGE /////////////////////////////////////
        private DataGridViewRow? selectedRow = null;
        private void POS_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (POS_DataGridView.Rows.Count > 0 && POS_DataGridView.SelectedRows.Count > 0)
            {
                selectedRow = POS_DataGridView.SelectedRows[0];
            }
            else
            {
                selectedRow = null;
            }

            showItemInListToTextbox();
        }

        /////////////////////////////////////////// SHOW PRODUCT LIST TO TEXTBOX /////////////////////////////////////
        private void showItemInListToTextbox()
        {
            if (selectedRow == null)
            {
                POS_ProductBarcodeTextBox.Clear();
                POS_ProductNameTextBox.Clear();
                POS_CostPriceTextBox.Clear();
                POS_SellingPriceTextBox.Clear();
                POS_UnitInStockTextBox.Clear();

                POS_SellingUnitNumericUpDown.Value = 0;
                POS_SellingUnitNumericUpDown.Enabled = false;
                POS_SellingUnitNumericUpDown.ReadOnly = true;

                POS_DeleteButton.Enabled = false;
                return;
            }

            if (selectedRow != null)
            {
                //0=ที่, 1=รหัสสินค้า, 2=ชื่อสินค้า, 3=CostPrice, 4=ราคาขาย, 5=UnitInStock, 6=จำนวนที่ซื้อ, 7=Subtotal
                POS_ProductBarcodeTextBox.Text = Convert.ToString(selectedRow.Cells[1].Value);
                POS_ProductNameTextBox.Text = Convert.ToString(selectedRow.Cells[2].Value);
                POS_CostPriceTextBox.Text = Convert.ToDouble(selectedRow.Cells[3].Value).ToString("#,###,##0");
                POS_SellingPriceTextBox.Text = Convert.ToDouble(selectedRow.Cells[4].Value).ToString("#,###,##0");
                POS_UnitInStockTextBox.Text = Convert.ToString(selectedRow.Cells[5].Value);
                if (Convert.ToInt32(POS_UnitInStockTextBox.Text) > 0)
                {
                    POS_UnitInStockTextBox.ForeColor = Color.Black;
                }
                else
                {
                    POS_UnitInStockTextBox.ForeColor = Color.Red;
                }

                POS_SellingUnitNumericUpDown.Enabled = true;
                POS_SellingUnitNumericUpDown.ReadOnly = false;
                POS_SellingUnitNumericUpDown.Value = Convert.ToInt32(selectedRow.Cells[6].Value);

                POS_DeleteButton.Enabled = true;
                return;
            }
        }

        /////////////////////////////////////////// ADD PRODUCT TO SELLING LIST ////////////////////////////////////////
        private void addProductToSellingList(string receiveBarcode)
        {
            var data = (from i in db.Products
                        where i.Barcode == receiveBarcode
                        select new
                        {
                            i.Barcode,
                            i.Name,
                            i.CostPrice,
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

                if (barcodeExist < 0) // Barcode not exists : Add new row
                {
                    //0=ที่, 1=รหัสสินค้า, 2=ชื่อสินค้า, 3=CostPrice, 4=ราคาขาย, 5=UnitInStock, 6=จำนวนที่ซื้อ, 7=Subtotal

                    int No = POS_DataGridView.Rows.Count + 1;
                    string barcode = Convert.ToString(data.Barcode);
                    string productName = Convert.ToString(data.Name);
                    double costPrice = Convert.ToDouble(data.CostPrice);
                    double sellingPrice = Convert.ToDouble(data.SellingPrice);
                    int unitInStock = Convert.ToInt32(data.Quantity);

                    int pickQTY = 1;

                    double subTotal = sellingPrice * pickQTY;

                    POS_DataGridView.Rows.Add(No, barcode, productName, costPrice, sellingPrice.ToString("#,###,##0"), unitInStock, pickQTY, subTotal.ToString("#,###,##0"));
                    POS_DataGridView.ClearSelection(); //Selected no row
                    POS_DataGridView.Rows[POS_DataGridView.Rows.Count - 1].Selected = true; //Selected last row
                }
                else // Barcode exists : Stack existing row
                {
                    //0=ที่, 1=รหัสสินค้า, 2=ชื่อสินค้า, 3=CostPrice, 4=ราคาขาย, 5=UnitInStock, 6=จำนวนที่ซื้อ, 7=Subtotal

                    double sellingPrice = Convert.ToDouble(POS_DataGridView.Rows[barcodeExist].Cells[4].Value);
                    int pickQTY = Convert.ToInt32(POS_DataGridView.Rows[barcodeExist].Cells[6].Value);

                    pickQTY += 1;

                    double subTotal = sellingPrice * pickQTY;

                    POS_DataGridView.Rows[barcodeExist].Cells[6].Value = pickQTY;
                    POS_DataGridView.Rows[barcodeExist].Cells[7].Value = subTotal.ToString("#,###,##0");
                    POS_DataGridView.ClearSelection(); //Selected no row
                    POS_DataGridView.Rows[barcodeExist].Selected = true; //Selected previous row
                }

                calculateTotalAmount();
            }
            else
            {
                MessageBox.Show("ไม่พบสินค้า", "ขายสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        ////////////////////////////////////NUMERIC UP-DOWN VALUE CHANGE////////////////////////////////
        private void POS_SellingUnitNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                return;
            }

            int qtyInRow = Convert.ToInt32(selectedRow.Cells[6].Value);
            int qtyInTextbox = Convert.ToInt32(POS_SellingUnitNumericUpDown.Value);

            if (qtyInRow == qtyInTextbox)
            {
                return;
            }

            double price = Convert.ToDouble(selectedRow.Cells[4].Value);
            double subTotal = price * qtyInTextbox;

            //0=ที่, 1=รหัสสินค้า, 2=ชื่อสินค้า, 3=CostPrice, 4=ราคาขาย, 5=UnitInStock, 6=จำนวนที่ซื้อ, 7=Subtotal
            selectedRow.Cells[6].Value = qtyInTextbox;
            selectedRow.Cells[7].Value = subTotal.ToString("#,###,##0");
            selectedRow.Selected = true; //Selected existing row

            calculateTotalAmount();
        }

        ////////////////////////////////////DELETE ITEM LIST BUTTON////////////////////////////////
        private void POS_DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                return;
            }

            POS_DataGridView.Rows.Remove(selectedRow);
            calculateTotalAmount();
            POS_DataGridView.ClearSelection(); //Selected no row
        }

        ////////////////////////////////////////////CALCULATE TOTAL AMOUNT///////////////////////////////////////
        private void calculateTotalAmount()
        {
            if (POS_DataGridView.Rows.Count > 0)
            {
                double totalAmount = 0;

                foreach (DataGridViewRow row in POS_DataGridView.Rows)
                {
                    totalAmount += Convert.ToDouble(row.Cells[7].Value);
                }

                POS_TotalAmountTextBox.Text = totalAmount.ToString("#,###,##0");
                POS_TotalAmountTextBox.ReadOnly = true;
                POS_TotalAmountTextBox.BackColor = Color.LightCyan;
            }
            else
            {
                POS_TotalAmountTextBox.Clear();
                POS_TotalAmountTextBox.ReadOnly = true;
                POS_TotalAmountTextBox.BackColor = SystemColors.Control;
            }
        }

        ////////////////////////////////TOTAL AMOUNT TEXTBOX HAS CHANGE////////////////////////////////
        private void POS_TotalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(POS_TotalAmountTextBox.Text))
            {
                POS_ReceiveMoneyTextBox.Clear();
                POS_ReceiveMoneyTextBox.ReadOnly = false;
                POS_ReceiveMoneyTextBox.BackColor = Color.White;
            }
            else
            {
                POS_ReceiveMoneyTextBox.Clear();
                POS_ReceiveMoneyTextBox.ReadOnly = true;
                POS_ReceiveMoneyTextBox.BackColor = SystemColors.Control;
            }
        }

        ////////////////////////////////RECEIVE MONEY TEXTBOX HAS CHANGE////////////////////////////////
        private void POS_ReceiveMoneyTextBox_TextChanged(object sender, EventArgs e)
        {
            POS_ReceiveMoneyTextBox.ForeColor = Color.Black;
            POS_ChangeMoneyTextBox.Clear();
            POS_ChangeMoneyTextBox.ReadOnly = true;
            POS_ChangeMoneyTextBox.BackColor = SystemColors.Control;
        }

        ////////////////////////////////RECEIVE MONEY TEXTBOX ENTER KEYPDOWN////////////////////////////////
        private void POS_ReceiveMoneyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrEmpty(POS_TotalAmountTextBox.Text) && string.IsNullOrEmpty(POS_ReceiveMoneyTextBox.Text))
                {
                    return;
                }

                if (double.TryParse(POS_TotalAmountTextBox.Text.Trim(), out double totalAmount) && double.TryParse(POS_ReceiveMoneyTextBox.Text.Trim(), out double receiveMoney))
                {
                    double changeMoney = receiveMoney - totalAmount;
                    if (changeMoney >= 0)
                    {
                        POS_ChangeMoneyTextBox.Text = changeMoney.ToString("#,###,##0");
                        POS_ChangeMoneyTextBox.ReadOnly = true;
                        POS_ChangeMoneyTextBox.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        POS_ReceiveMoneyTextBox.ForeColor = Color.Red;
                    }
                }
            }
        }

        ////////////////////////////////CHANGE MONEY TEXTBOX HAS CHANGE////////////////////////////////
        private void POS_ChangeMoneyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(POS_ChangeMoneyTextBox.Text))
            {
                POS_SaveButton.Enabled = true;
                POS_SaveButton.BackColor = Color.LimeGreen;
                POS_SaveButton.Focus();
            }
            else
            {
                POS_SaveButton.Enabled = false;
                POS_SaveButton.BackColor = SystemColors.ControlDark;
            }
        }

        ////////////////////////////////////////SAVE BUTTON CLICK & KEYDOWN///////////////////////////////////
        private void POS_SaveButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveData();
            }
        }
        private void POS_SaveButton_Click(object sender, EventArgs e)
        {
            saveData();
        }
        private void saveData()
        {
            try
            {
                using var tr = db.Database.BeginTransaction();
                Sale sale = new Sale();

                sale.ReceiptId = Convert.ToString(POS_SaleIDTextBox.Text);
                sale.Date = DateTime.Now;
                sale.Total = Convert.ToDecimal(POS_TotalAmountTextBox.Text);
                sale.ReceiveMoney = Convert.ToDecimal(POS_ReceiveMoneyTextBox.Text);
                sale.ChangeMoney = Convert.ToDecimal(POS_ChangeMoneyTextBox.Text);

                db.Sales.Add(sale);//ADD Sale

                foreach (DataGridViewRow row in POS_DataGridView.Rows)
                {
                    SaleDetail saleDetail = new SaleDetail();

                    //0=ที่, 1=รหัสสินค้า, 2=ชื่อสินค้า, 3=CostPrice, 4=ราคาขาย, 5=UnitInStock, 6=จำนวนที่ซื้อ, 7=Subtotal
                    saleDetail.ReceiptId = sale.ReceiptId;
                    saleDetail.ProductName = Convert.ToString(row.Cells[2].Value) ?? "unknow";
                    saleDetail.ProductSellingPrice = Convert.ToDecimal(row.Cells[4].Value);
                    saleDetail.PickQuantity = Convert.ToInt32(row.Cells[6].Value);
                    saleDetail.SubTotal = Convert.ToDecimal(row.Cells[7].Value);

                    db.SaleDetails.Add(saleDetail);//ADD Sale Detail

                    var data = (from c in db.Products
                                where c.Barcode == Convert.ToString(row.Cells[1].Value)
                                select c).FirstOrDefault();
                    if (data != null)
                    {
                        data.Quantity = Convert.ToInt32(data.Quantity - saleDetail.PickQuantity);//Cut Stock Quantity
                    }
                }

                db.SaveChanges();
                tr.Commit();

                MessageBox.Show("บันทึกข้อมูลการขายสำเร็จ!", "บันทึกข้อมูลการขาย", MessageBoxButtons.OK, MessageBoxIcon.Information);
                POS_AddNewSubjectButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "บันทึกข้อมูลการขาย", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////POS_TRANSACTIONHISTORY BUTTON CLICKED///////////////////////////////////
        private void POS_TransactionHistoryButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
            contextMenuStrip1.Items[0].Font = new Font(contextMenuStrip1.Font, FontStyle.Bold);
        }

        //////////////////////////////////////// PRINT RECIPT ///////////////////////////////////
        string extractedReceiptId;
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == null)
            {
                return;
            }

            extractedReceiptId = e.ClickedItem.Text.Substring(0, 13);

            if (extractedReceiptId.Length == 13)
            {
                POS_PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 300, 700); //set paper size to Receipt

                // Find the ToolStrip in the PrintPreviewDialog controls
                ToolStrip toolStrip = (ToolStrip)POS_PrintPreviewDialog.Controls[1];

                // Create a new ToolStripButton
                ToolStripButton printButton = new ToolStripButton();
                printButton.Image = toolStrip.ImageList.Images[0];
                printButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
                printButton.Click += POS_PrintPreviewDialog_PrintClick;

                // Replace the first item in the ToolStrip with the new printButton
                toolStrip.Items.RemoveAt(0);
                toolStrip.Items.Insert(0, printButton);

                PrintPreviewDialog f = new PrintPreviewDialog();
                f = POS_PrintPreviewDialog;
                f.Document = POS_PrintDocument;
                f.StartPosition = FormStartPosition.Manual;
                // Calculate the center position of the child form
                int x = this.Left + ((this.Width - f.Width) / 2) + ((f.Width - (f.Width / 8)) / 2 / 2);
                int y = this.Top + ((this.Height - f.Height) / 5);
                f.Location = new Point(x, y);

                // Show the PrintPreviewDialog
                f.ShowDialog();
            }
        }

        private void POS_PrintPreviewDialog_PrintClick(object sender, EventArgs e)
        {
            // Open dummyForm just for solve a bug
            dummyForm d = new dummyForm();
            d.ShowDialog();

            PrintDialog k = new PrintDialog();
            k = POS_PrintDialog;
            k.Document = POS_PrintDocument;

            if (k.ShowDialog() == DialogResult.OK)
            {
                POS_PrintDocument.PrinterSettings = POS_PrintDialog.PrinterSettings;
                POS_PrintDocument.Print();

                POS_PrintPreviewDialog.Close();
            }
        }

        private void POS_PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var data = (from i in db.Sales
                        join q in db.SaleDetails on i.ReceiptId equals q.ReceiptId
                        where i.ReceiptId == extractedReceiptId
                        select new 
                        {   i.ReceiptId, 
                            i.Date,
                            i.Total,
                            i.ReceiveMoney,
                            i.ChangeMoney,
                            q.ProductName,
                            q.ProductSellingPrice,
                            q.PickQuantity,
                            q.SubTotal,
                        }).FirstOrDefault();

            //if(data != null)
            //{
            //    e.Graphics.DrawString("ร้านธีรภัทร์", new Font("tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(110, 5));
            //    //Space = 23
            //    e.Graphics.DrawString("20/54, หมู่.2 ถนนกาญจนวนิช", new Font("tahoma", 10), Brushes.Black, new Point(61, 28));//Space = 15
            //    e.Graphics.DrawString("ตำบลเขารูปช้าง อำเภอเมืองสงขลา ", new Font("tahoma", 10), Brushes.Black, new Point(48, 43));//Space = 15
            //    e.Graphics.DrawString("จังหวัดสงขลา 90000", new Font("tahoma", 10), Brushes.Black, new Point(88, 58));//Space = 15
            //    e.Graphics.DrawString("โทรศัพท์ 0-7444-7848", new Font("tahoma", 10), Brushes.Black, new Point(81, 73));//Space = 15
            //    //Space = 23
            //    e.Graphics.DrawString("เลขที่ใบเสร็จ", new Font("tahoma", 10), Brushes.Black, new Point(5, 96));
            //    e.Graphics.DrawString("#" + data.ReceiptId, new Font("tahoma", 10), Brushes.Black, new Point(90, 96));
            //    //Space = 23
            //    e.Graphics.DrawString("วันที่", new Font("tahoma", 10), Brushes.Black, new Point(5, 111));
            //    e.Graphics.DrawString(data.Date.ToString("dd MMMM yyyy", new CultureInfo("th-TH")), new Font("tahoma", 10), Brushes.Black, new Point(39, 111));
            //    e.Graphics.DrawString("เวลา", new Font("tahoma", 10), Brushes.Black, new Point(180, 111));
            //    e.Graphics.DrawString(data.Date.ToString("HH:mm") + " น.", new Font("tahoma", 10), Brushes.Black, new Point(215, 111));
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

            //    for()
            //    {
            //        e.Graphics.DrawString(data.ProductName, new Font("tahoma", 9), Brushes.Black, new Point(5, 196));
            //        e.Graphics.DrawString(data.ProductSellingPrice.ToString("#,###,##0"), new Font("tahoma", 9), Brushes.Black, new Point(100, 196));
            //        e.Graphics.DrawString(Convert.ToString(data.PickQuantity), new Font("tahoma", 9), Brushes.Black, new Point(175, 196));
            //        e.Graphics.DrawString(data.SubTotal.ToString("#,###,##0"), new Font("tahoma", 9), Brushes.Black, new Point(250, 196));
            //        //Space = 15
            //    }

            //    e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 271));
            //    //Space = 15
            //    e.Graphics.DrawString("ยอดสุทธิ", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(5, 286));
            //    e.Graphics.DrawString(data.Total.ToString("#,###,##0"), new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(250, 286));
            //    //Space = 15
            //    e.Graphics.DrawString("=============================", new Font("tahoma", 10), Brushes.Black, new Point(2, 301));
            //}

            PaperSize paperSize = e.PageSettings.PaperSize;

            float paperWidth = paperSize.Width;
            //float paperHeight = paperSize.Height;

            Font font12Bold = new Font("tahoma", 12, FontStyle.Bold);
            Font font10Normal = new Font("Tahoma", 10);
            Font font9Bold = new Font("tahoma", 9, FontStyle.Bold);
            Font font9Normal = new Font("Tahoma", 9);
            Brush brush = Brushes.Black;

            /*===============================HEADER===============================*/
            string[] head = new string[5]
            {
                "ร้านธีรภัทร์",
                "20/54, หมู่.2 ถนนกาญจนวนิช",
                "ตำบลเขารูปช้าง อำเภอเมืองสงขลา",
                "จังหวัดสงขลา 90000",
                "โทรศัพท์ 0-7444-7848"
            };

            float[] headStartX = new float[5];
            {
                headStartX[0] = (paperWidth - e.Graphics.MeasureString(head[0], font12Bold).Width) / 2;
                headStartX[1] = (paperWidth - e.Graphics.MeasureString(head[1], font10Normal).Width) / 2;
                headStartX[2] = (paperWidth - e.Graphics.MeasureString(head[2], font10Normal).Width) / 2;
                headStartX[3] = (paperWidth - e.Graphics.MeasureString(head[3], font10Normal).Width) / 2;
                headStartX[4] = (paperWidth - e.Graphics.MeasureString(head[4], font10Normal).Width) / 2;
            }

            float[] headStartY = new float[5];
            {
                headStartY[0] = 5;
                headStartY[1] = headStartY[0] + 23;
                headStartY[2] = headStartY[1] + 15;
                headStartY[3] = headStartY[2] + 15;
                headStartY[4] = headStartY[3] + 15;
            }

            e.Graphics.DrawString(head[0], font12Bold, brush, headStartX[0], headStartY[0]);
            e.Graphics.DrawString(head[1], font10Normal, brush, headStartX[1], headStartY[1]);
            e.Graphics.DrawString(head[2], font10Normal, brush, headStartX[2], headStartY[2]);
            e.Graphics.DrawString(head[3], font10Normal, brush, headStartX[3], headStartY[3]);
            e.Graphics.DrawString(head[4], font10Normal, brush, headStartX[4], headStartY[4]);

            /*===============================RECEIPT AND DATE TIME===============================*/

            string[] receiptAndDateTime = new string[6];
            {
                receiptAndDateTime[0] = "เลขที่ใบเสร็จ";
                receiptAndDateTime[1] = "#" + data.ReceiptId;
                receiptAndDateTime[2] = "วันที่";
                receiptAndDateTime[3] = data.Date.ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
                receiptAndDateTime[4] = "เวลา";
                receiptAndDateTime[5] = data.Date.ToString("HH:mm") + " น.";
            }

            float[] receiptAndDateTimeStartX = new float[6];
            {
                receiptAndDateTimeStartX[0] = 5;
                receiptAndDateTimeStartX[1] = receiptAndDateTimeStartX[0] + e.Graphics.MeasureString(receiptAndDateTime[0], font9Bold).Width;
                receiptAndDateTimeStartX[2] = 5;
                receiptAndDateTimeStartX[3] = receiptAndDateTimeStartX[2] + e.Graphics.MeasureString(receiptAndDateTime[2], font9Bold).Width;
                receiptAndDateTimeStartX[5] = paperWidth - e.Graphics.MeasureString(receiptAndDateTime[5], font9Normal).Width - 5;
                receiptAndDateTimeStartX[4] = paperWidth - 5 - e.Graphics.MeasureString(receiptAndDateTime[4], font9Bold).Width - e.Graphics.MeasureString(receiptAndDateTime[5], font9Normal).Width;
            }

            float[] receiptAndDateTimeStartY = new float[6];
            {
                receiptAndDateTimeStartY[0] = headStartY[4] + 23;
                receiptAndDateTimeStartY[1] = headStartY[4] + 23;
                receiptAndDateTimeStartY[2] = receiptAndDateTimeStartY[0] + 15;
                receiptAndDateTimeStartY[3] = receiptAndDateTimeStartY[0] + 15;
                receiptAndDateTimeStartY[4] = receiptAndDateTimeStartY[0] + 15;
                receiptAndDateTimeStartY[5] = receiptAndDateTimeStartY[0] + 15;
            }

            e.Graphics.DrawString(receiptAndDateTime[0], font9Bold, brush, receiptAndDateTimeStartX[0], receiptAndDateTimeStartY[0]);
            e.Graphics.DrawString(receiptAndDateTime[1], font9Normal, brush, receiptAndDateTimeStartX[1], receiptAndDateTimeStartY[1]);
            e.Graphics.DrawString(receiptAndDateTime[2], font9Bold, brush, receiptAndDateTimeStartX[2], receiptAndDateTimeStartY[2]);
            e.Graphics.DrawString(receiptAndDateTime[3], font9Normal, brush, receiptAndDateTimeStartX[3], receiptAndDateTimeStartY[3]);
            e.Graphics.DrawString(receiptAndDateTime[4], font9Bold, brush, receiptAndDateTimeStartX[4], receiptAndDateTimeStartY[4]);
            e.Graphics.DrawString(receiptAndDateTime[5], font9Normal, brush, receiptAndDateTimeStartX[5], receiptAndDateTimeStartY[5]);

            /*===============================WORD SEPARATOR===============================*/
            //Space = 20
            e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 131));//Space = 15
            e.Graphics.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", new Font("tahoma", 10), Brushes.Black, new Point(51, 146));//Space = 15
            e.Graphics.DrawString("---------------------------------------------------------", new Font("tahoma", 10), Brushes.Black, new Point(4, 161));//Space = 15
            //Space = 15
            e.Graphics.DrawString("สินค้า", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(5, 176));
            e.Graphics.DrawString("ราคา", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(100, 176));
            e.Graphics.DrawString("จำนวน", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(175, 176));
            e.Graphics.DrawString("เงินรวม", new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(245, 176));
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
            string price = "127,000";
            int xPointPrice = 245 - price.Length;
            e.Graphics.DrawString(price, new Font("tahoma", 9, FontStyle.Bold), Brushes.Black, new Point(xPointPrice, 286));
            //Space = 15
            string ReceiveAndChangeMoney = "รับเงิน" + " " + "1300" + " " + "ทอนเงิน" + " " + "30";
            int xPointReceiveAndChangeMoney = 187 - ReceiveAndChangeMoney.Length;
            e.Graphics.DrawString(ReceiveAndChangeMoney, new Font("tahoma", 9), Brushes.Black, new Point(xPointReceiveAndChangeMoney, 301));
            //Space = 15
            e.Graphics.DrawString("=============================", new Font("tahoma", 10), Brushes.Black, new Point(2, 316));
        }
    }
}