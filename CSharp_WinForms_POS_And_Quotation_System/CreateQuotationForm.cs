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
    public partial class CreateQuotationForm : Form
    {
        public CreateQuotationForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1200, 1300);
        }

        private void CreateQuotationForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create a new row for the DataGridView
            DataGridViewRow newRow = new DataGridViewRow();

            int rowCount = CQ_ProductDetailsDataGridView.RowCount - 1;

            // Create and add a cell for the "number" column
            DataGridViewTextBoxCell numberCell = new DataGridViewTextBoxCell();
            numberCell.Value = rowCount + 1;
            newRow.Cells.Add(numberCell);

            // Create and add a cell for the "I am here" column
            DataGridViewTextBoxCell hereCell = new DataGridViewTextBoxCell();
            hereCell.Value = "I am here";
            newRow.Cells.Add(hereCell);

            // Create and add a cell for the "5,000" column
            DataGridViewTextBoxCell fiveThousandCell = new DataGridViewTextBoxCell();
            fiveThousandCell.Value = "5,000";
            newRow.Cells.Add(fiveThousandCell);

            // Add the new row to the DataGridView
            CQ_ProductDetailsDataGridView.Rows.Add(newRow);
        }

        private void CreateQuotationCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
