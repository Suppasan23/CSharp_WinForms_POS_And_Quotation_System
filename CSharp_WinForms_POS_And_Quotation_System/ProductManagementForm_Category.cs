using CSharp_WinForms_POS_And_Quotation_System.Models.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WinForms_POS_And_Quotation_System
{
    public partial class ProductManagementForm_Category : Form
    {

        CsharpWinFormsPosAndQuotationSystemDbContext db = new CsharpWinFormsPosAndQuotationSystemDbContext();

        private int whichOperation = -1; //1=ADD, 2=EDIT, 3=DELETE
        private int catSelectedID = -1;
        private string? catSelectedName = "";

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
            this.PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.PM_C_DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

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
            center.isExecuted = false;
            loadData();
        }

        private void loadData()
        {
            whichOperation = -1;
            catSelectedID = -1;
            catSelectedName = "";

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

            PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            PM_C_DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            PM_C_DataGridView1.Enabled = true;

            PM_C_TextBox1.Clear();

            PM_C_DataGridView1.DataSource = null; //Clear DataGridView

            var data = (from i in db.ProductCategories
                        select new
                        {
                            CategoryId = i.CategoryId,
                            ชื่อประเภทสินค้า = i.Name
                        }).ToList(); ;

            if (data.Any())
            {
                var modifiedData = data.Select((item, index) => new
                {
                    item.CategoryId,
                    ที่ = (index).ToString(),
                    item.ชื่อประเภทสินค้า
                }).ToList();

                PM_C_DataGridView1.DataSource = modifiedData;

                // Hide the first column and config the other collumn
                PM_C_DataGridView1.Columns[0].Visible = false;
                PM_C_DataGridView1.Columns[1].Width = 60;
                PM_C_DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                PM_C_DataGridView1.ClearSelection();

                // Hide the first row
                PM_C_DataGridView1.ClearSelection();
                PM_C_DataGridView1.Rows[0].Selected = true;
                PM_C_DataGridView1.CurrentCell = null;
                PM_C_DataGridView1.Rows[0].Visible = false;
            }
            else
            {
                PM_C_DataGridView1.DataSource = null; //Clear DataGridView
                PM_C_DataGridView1.ClearSelection(); //Selected no row
            }
        }

        ///////////////////////////////////////////// ADD BUTTON CLICK /////////////////////////////////////////////
        private void PM_C_AddLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            whichOperation = 1;
            catSelectedID = -1;
            catSelectedName = "";

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
            PM_C_TextBox1.Focus();
        }

        ///////////////////////////////////////////// EDIT BUTTON CLICK /////////////////////////////////////////////
        private void PM_C_EditLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PM_C_DataGridView1.Rows.Count > 0 && PM_C_DataGridView1.SelectedRows.Count > 0)
            {
                whichOperation = 2;


                DataGridViewRow selectedRow = PM_C_DataGridView1.SelectedRows[0];
                catSelectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
                catSelectedName = String.IsNullOrEmpty(selectedRow.Cells[2].Value.ToString()) ? "" : Convert.ToString(selectedRow.Cells[2].Value);


                PM_C_Label1.Text = "แก้ไขชื่อประเภทสินค้า:";

                PM_C_TextBox1.Enabled = true;
                PM_C_TextBox1.ReadOnly = false;
                PM_C_TextBox1.BackColor = Color.Tan;

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

                PM_C_DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Tan;
                PM_C_DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                PM_C_DataGridView1.Enabled = false;

                PM_C_TextBox1.Text = catSelectedName;
                PM_C_TextBox1.Select(catSelectedName.Length, 0);
                PM_C_TextBox1.Focus();
            }
            else
            {
                return;
            }
        }

        ///////////////////////////////////////////// DELETE BUTTON CLICK /////////////////////////////////////////////
        private void PM_C_DeleteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PM_C_DataGridView1.Rows.Count > 0 && PM_C_DataGridView1.SelectedRows.Count > 0)
            {
                whichOperation = 3;

                DataGridViewRow selectedRow = PM_C_DataGridView1.SelectedRows[0];
                catSelectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
                catSelectedName = String.IsNullOrEmpty(selectedRow.Cells[2].Value.ToString()) ? "" : Convert.ToString(selectedRow.Cells[2].Value);


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
                PM_C_DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                PM_C_DataGridView1.Enabled = false;

                PM_C_TextBox1.Text = catSelectedName;
                PM_C_SaveLabel.Select();
            }
            else
            {
                return;
            }
        }

        ///////////////////////////////////////////// SAVE BUTTON CLICK  /////////////////////////////////////////////
        private void PM_C_SaveLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            switch (whichOperation)
            {
                case 1://ADD
                    addExecute();
                    break;
                case 2://EDIT
                    editExecute();
                    break;
                case 3://REMOVE
                    deleteExecute();
                    break;
                default:
                    break;
            }
        }

        private void addExecute() //ADD
        {
            if (catSelectedID >= 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(PM_C_TextBox1.Text))
            {
                MessageBox.Show("โปรดระบุชื่อประเภทสินค้า", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    var tr = db.Database.BeginTransaction();//Transaction control: ADD
                    ProductCategory A = new ProductCategory();

                    A.Name = PM_C_TextBox1.Text.Trim();

                    db.ProductCategories.Add(A);
                    db.SaveChanges();
                    tr.Commit();

                    MessageBox.Show("เพิ่มประเภทสินค้าสำเร็จ", "เพิ่มประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    center.isExecuted = true;
                    loadData();

                    PM_C_DataGridView1.Rows[PM_C_DataGridView1.Rows.Count - 1].Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "เพิ่มประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void editExecute() //EDIT
        {
            if (catSelectedID <= 0)
            {
                return;
            }
            else if (catSelectedName == PM_C_TextBox1.Text.Trim())
            {
                return;
            }
            else if (string.IsNullOrEmpty(PM_C_TextBox1.Text))
            {
                MessageBox.Show("โปรดระบุชื่อประเภทสินค้า", "แก้ไขประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var E = (from e in db.ProductCategories
                         where e.CategoryId == catSelectedID
                         select e).FirstOrDefault();

                if (E != null)
                {
                    try
                    {
                        var tr = db.Database.BeginTransaction();//Transaction control: EDIT

                        E.Name = PM_C_TextBox1.Text.Trim();

                        db.SaveChanges();
                        tr.Commit();

                        MessageBox.Show("แก้ไขประเภทสินค้าสำเร็จ", "แก้ไขประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        center.isExecuted = true;

                        int previousSelectedIndex = PM_C_DataGridView1.SelectedRows[0].Index;

                        loadData();

                        PM_C_DataGridView1.Rows[previousSelectedIndex].Selected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "แก้ไขประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void deleteExecute() //DELETE
        {
            if (catSelectedID <= 0)
            {
                return;
            }
            else
            {
                var U = from u in db.Products
                        where u.CategoryId == catSelectedID
                        select u;
                if (U.Any())
                {
                    try
                    {
                        var tr = db.Database.BeginTransaction();//Transaction control: UPDATE

                        foreach (var item in U)
                        {
                            item.CategoryId = 0;
                        }

                        db.SaveChanges();
                        tr.Commit();
                        deleteProductCategory();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "ลบประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    deleteProductCategory();
                }
            }

            void deleteProductCategory()
            {
                var againU = from aU in db.Products
                             where aU.CategoryId == catSelectedID
                             select aU;
                if (!againU.Any())
                {
                    var D = (from d in db.ProductCategories
                             where d.CategoryId == catSelectedID
                             select d).FirstOrDefault();
                    if (D != null)
                    {
                        try
                        {
                            var tr = db.Database.BeginTransaction();//Transaction control: DELETE
                            db.ProductCategories.Remove(D);
                            db.SaveChanges();
                            tr.Commit();

                            MessageBox.Show("ลบประเภทสินค้าสำเร็จ", "ลบประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            center.isExecuted = true;
                            loadData();

                            PM_C_DataGridView1.ClearSelection();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "ลบประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("เกิดความผิดพลาดในการลบประเภทสินค้า", "ลบประเภทสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        ///////////////////////////////////////////// CANCEL BUTTON CLICK  /////////////////////////////////////////////
        private void PM_C_CancelLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int previousSelectedIndex = -1;
            if (PM_C_DataGridView1.SelectedRows.Count > 0)
            {
                previousSelectedIndex = PM_C_DataGridView1.SelectedRows[0].Index;
            }
            else
            {
                previousSelectedIndex = -1;
            }

            loadData();

            if ((previousSelectedIndex >= 0) && (previousSelectedIndex < PM_C_DataGridView1.Rows.Count))
            {
                PM_C_DataGridView1.Rows[previousSelectedIndex].Selected = true;
            }
            else
            {
                PM_C_DataGridView1.ClearSelection();
            }
        }
    }
}