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
            this.MinimumSize = new Size(1100, 900);
            this.Size = new Size(1100, 1200);
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
