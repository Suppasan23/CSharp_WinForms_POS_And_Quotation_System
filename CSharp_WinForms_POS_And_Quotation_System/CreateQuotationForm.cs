﻿using System;
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
            this.Size = new Size(1180, 1250);
        }

        private void CreateQuotationForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateQuotationCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
