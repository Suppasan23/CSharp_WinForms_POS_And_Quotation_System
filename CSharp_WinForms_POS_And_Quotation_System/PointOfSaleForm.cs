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
    public partial class PointOfSaleForm : Form
    {
        public PointOfSaleForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 1000);
            this.Size = new Size(1200, 1300);
        }

        private void PointOfSaleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
