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
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1180, 1250);

            this.PM_DataGridView.ReadOnly = true;
            this.PM_DataGridView.MultiSelect = false;
            this.PM_DataGridView.AllowUserToAddRows = false;
            this.PM_DataGridView.AllowUserToDeleteRows = false;
            this.PM_DataGridView.AllowUserToResizeRows = false;
            this.PM_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PM_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.PM_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PM_DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(PM_DataGridView.Font, FontStyle.Bold);
            this.PM_DataGridView.EnableHeadersVisualStyles = false;
            this.PM_DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            this.PM_DataGridView.ClearSelection();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
