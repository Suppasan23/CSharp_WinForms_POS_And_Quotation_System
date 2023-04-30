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
            this.Size = new Size(1200, 1300);
        }

        private void ArchiveQuotationForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
