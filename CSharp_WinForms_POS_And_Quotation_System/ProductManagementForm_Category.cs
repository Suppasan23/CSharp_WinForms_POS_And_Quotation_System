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

                PM_C_DataGridView1.Rows.Add(0, "+", "");

                //id, ที่, ชื่อประเภทสินค้า
                PM_C_DataGridView1.Columns[0].Visible = false;
                PM_C_DataGridView1.Columns[1].Width = 60;
                PM_C_DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        ///////////////////////////////////////////// GataGridView Cell SelectChange , Key up , Key down  /////////////////////////////////////////////
        private void PM_C_DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (PM_C_DataGridView1.Rows.Count > 0 && PM_C_DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PM_C_DataGridView1.SelectedRows[0];
                HandleCellSelectChange(selectedRow);
            }
            else
            {
                PM_C_TextBox1.Clear();
            }
        }

        private void HandleCellSelectChange(DataGridViewRow recieveSelectedRow)
        {
            PM_C_TextBox1.Clear();

            int catSelectedID = Convert.ToInt32(recieveSelectedRow.Cells[0].Value);
            string catSelectedName = Convert.ToString(recieveSelectedRow.Cells[2].Value);

            PM_C_TextBox1.Text = Convert.ToString(catSelectedName);

        }


    }
}
