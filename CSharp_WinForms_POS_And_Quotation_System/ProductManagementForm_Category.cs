using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WinForms_POS_And_Quotation_System
{
    public partial class ProductManagementForm_Category : Form
    {

        CsharpWinFormsPosAndQuotationSystemDbContext db = new CsharpWinFormsPosAndQuotationSystemDbContext();

        public ProductManagementForm_Category()
        {
            InitializeComponent();
            this.MinimumSize = new Size(400, 500);
            this.Size = new Size(480, 550);

            this.PM_C_DataGridView1.ReadOnly = true;
            this.PM_C_DataGridView1.MultiSelect = false;
            this.PM_C_DataGridView1.AllowUserToAddRows = false;
            this.PM_C_DataGridView1.AllowUserToDeleteRows = false;
            this.PM_C_DataGridView1.AllowUserToResizeRows = false;

            this.PM_C_DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
            this.PM_C_DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.PM_C_DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.PM_C_DataGridView1.AllowUserToResizeColumns = false;
            this.PM_C_DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PM_C_DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);
            this.PM_C_DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.PM_C_DataGridView1.EnableHeadersVisualStyles = false;
            this.PM_C_DataGridView1.ColumnHeadersVisible = false;

            this.PM_C_DataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Regular);
            this.PM_C_DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.PM_C_DataGridView1.ClearSelection();
        }

        private void ProductManagementForm_Category_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            PM_C_Label1.Text = "โปรดเลือกการดำเนินการ:";

            PM_C_TextBox1.Enabled = false;
            PM_C_TextBox1.ReadOnly = true;
            PM_C_TextBox1.BackColor = Color.DarkGray;

            PM_C_AddLinkLabel.Visible = true;
            PM_C_EditLinkLabel.Visible = true;
            PM_C_DeleteLinkLabel.Visible = true;

            PM_C_AddLinkLabel.Text = "เพิ่ม";
            PM_C_EditLinkLabel.Text = "แก้ไข";
            PM_C_DeleteLinkLabel.Text = "ลบ";

            PM_C_SaveLabel.Visible = false;
            PM_C_CancelLabel.Visible = false;

            PM_C_SaveLabel.Text = "";
            PM_C_CancelLabel.Text = "";

            var data = from i in db.ProductCategories
                       select new { i.Id, i.Name };

            if (data != null)
            {

                PM_C_DataGridView1.Columns.Add("id", "id");
                PM_C_DataGridView1.Columns.Add("No", "ที่");
                PM_C_DataGridView1.Columns.Add("categoryName", "ชื่อประเภทสินค้า");

                int n = 1;

                foreach (var item in data)
                {
                    PM_C_DataGridView1.Rows.Add(item.Id, n, item.Name);
                    n++;
                }

                PM_C_DataGridView1.Rows.Add(0, "", "");

                //id, ที่, ชื่อประเภทสินค้า
                PM_C_DataGridView1.Columns[0].Visible = false;
                PM_C_DataGridView1.Columns[1].Width = 60;
                PM_C_DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        ///////////////////////////////////////////// ADD BUTTON CLICK /////////////////////////////////////////////
        private void PM_C_AddLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PM_C_Label1.Text = "ตั้งชื่อประเภทสินค้า:";

            PM_C_TextBox1.Enabled = true;
            PM_C_TextBox1.ReadOnly = false;
            PM_C_TextBox1.BackColor = Color.LightGreen;

            PM_C_AddLinkLabel.Visible = false;
            PM_C_EditLinkLabel.Visible = false;
            PM_C_DeleteLinkLabel.Visible = false;

            PM_C_AddLinkLabel.Text = "";
            PM_C_EditLinkLabel.Text = "";
            PM_C_DeleteLinkLabel.Text = "";

            PM_C_SaveLabel.Visible = true;
            PM_C_CancelLabel.Visible = true;

            PM_C_SaveLabel.Text = "บันทึก";
            PM_C_CancelLabel.Text = "ยกเลิก";

            PM_C_DataGridView1.ClearSelection();
            PM_C_DataGridView1.Enabled = false;

            PM_C_TextBox1.Clear();

        }

        ///////////////////////////////////////////// EDIT BUTTON CLICK /////////////////////////////////////////////
        private void PM_C_EditLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PM_C_DataGridView1.Rows.Count > 0 && PM_C_DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PM_C_DataGridView1.SelectedRows[0];
                int catSelectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
                string catSelectedName = Convert.ToString(selectedRow.Cells[2].Value);

                PM_C_Label1.Text = "แก้ไขชื่อประเภทสินค้า:";

                PM_C_TextBox1.Enabled = true;
                PM_C_TextBox1.ReadOnly = false;
                PM_C_TextBox1.BackColor = Color.Wheat;

                PM_C_AddLinkLabel.Visible = false;
                PM_C_EditLinkLabel.Visible = false;
                PM_C_DeleteLinkLabel.Visible = false;

                PM_C_AddLinkLabel.Text = "";
                PM_C_EditLinkLabel.Text = "";
                PM_C_DeleteLinkLabel.Text = "";

                PM_C_SaveLabel.Visible = true;
                PM_C_CancelLabel.Visible = true;

                PM_C_SaveLabel.Text = "บันทึก";
                PM_C_CancelLabel.Text = "ยกเลิก";

                PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Wheat;
                PM_C_DataGridView1.Enabled = false;

                PM_C_TextBox1.Text = Convert.ToString(catSelectedName);
            }
            else
            {
                return;
            }
        }

        ///////////////////////////////////////////// DELETE BUTTON CLICK /////////////////////////////////////////////
        private void PM_C_DeleteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PM_C_Label1.Text = "คุณต้องการลบประเภทสินค้านี้ ใช่หรือไม่:";

            PM_C_TextBox1.Enabled = true;
            PM_C_TextBox1.ReadOnly = true;
            PM_C_TextBox1.BackColor = Color.LightCoral;

            PM_C_AddLinkLabel.Visible = false;
            PM_C_EditLinkLabel.Visible = false;
            PM_C_DeleteLinkLabel.Visible = false;

            PM_C_AddLinkLabel.Text = "";
            PM_C_EditLinkLabel.Text = "";
            PM_C_DeleteLinkLabel.Text = "";

            PM_C_SaveLabel.Visible = true;
            PM_C_CancelLabel.Visible = true;

            PM_C_SaveLabel.Text = "ยืนยัน";
            PM_C_CancelLabel.Text = "ยกเลิก";

            PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightCoral;
            PM_C_DataGridView1.Enabled = false;
        }

        ///////////////////////////////////////////// SAVE BUTTON CLICK  /////////////////////////////////////////////
        private void PM_C_SaveLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        ///////////////////////////////////////////// CANCEL BUTTON CLICK  /////////////////////////////////////////////
        private void PM_C_CancelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PM_C_Label1.Text = "โปรดเลือกการดำเนินการ:";

            PM_C_TextBox1.Enabled = false;
            PM_C_TextBox1.ReadOnly = true;
            PM_C_TextBox1.BackColor = Color.DarkGray;

            PM_C_AddLinkLabel.Visible = true;
            PM_C_EditLinkLabel.Visible = true;
            PM_C_DeleteLinkLabel.Visible = true;

            PM_C_AddLinkLabel.Text = "เพิ่ม";
            PM_C_EditLinkLabel.Text = "แก้ไข";
            PM_C_DeleteLinkLabel.Text = "ลบ";

            PM_C_SaveLabel.Visible = false;
            PM_C_CancelLabel.Visible = false;

            PM_C_SaveLabel.Text = "";
            PM_C_CancelLabel.Text = "";

            PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
            PM_C_DataGridView1.Enabled = true;

            PM_C_TextBox1.Clear();
        }

    }
}
