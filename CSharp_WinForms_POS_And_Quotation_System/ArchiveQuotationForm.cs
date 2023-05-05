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
    public partial class ArchiveQuotationForm : Form
    {
        public ArchiveQuotationForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1180, 1250);
        }

        private void ArchiveQuotationForm_Load(object sender, EventArgs e)
        {
            AQ_TemporaryDataGridView.Rows.Add(false, "1", "65475214582", "10", "มทร.ศรีวิชัย", "40,000", "PDF");
            AQ_TemporaryDataGridView.Rows.Add(false, "2", "3698754245", "-5", "ม.ทักษิณ", "120,000", "PDF");
            AQ_TemporaryDataGridView.Rows[0].Cells[3].Style.ForeColor = Color.Green;
            AQ_TemporaryDataGridView.Rows[1].Cells[3].Style.ForeColor = Color.Red;
            AQ_TemporaryDataGridView.CellContentClick += AQ_TemporaryDataGridView_CellContentClick;

            AQ_PermanentDataGridView.Rows.Add("1", "3256487452", "2/05/2023", "มทร.ศรีวิชัย", "90,000", "PDF1", "PDF2", "PDF3");

        }

        private void AQ_TemporaryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the first column (index 0)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                // Toggle the value of the clicked checkbox
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)AQ_TemporaryDataGridView.Rows[e.RowIndex].Cells[0];
                checkbox.Value = !(bool)checkbox.Value;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
