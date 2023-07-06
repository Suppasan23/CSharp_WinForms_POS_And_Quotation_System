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
    public partial class dummyForm : Form
    {
        public dummyForm()
        {
            InitializeComponent();
        }

        private void dummyForm_Load(object sender, EventArgs e)
        {
            Dummy_CloseButton.PerformClick();
        }

        private void Dummy_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
