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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1800, 1200);
            WindowState = FormWindowState.Maximized;
        }


        private List<Form> openedForms = new List<Form>();

        private void openChildForms(Form childForm)
        {
            // Check if the form is already open
            foreach (Form showingForm in openedForms)
            {
                if (showingForm.GetType() == childForm.GetType())
                {
                    showingForm.Activate();
                    return;
                }
            }

            // Add the form to the list of opened forms
            openedForms.Add(childForm);

            // Set the form properties and show it
            childForm.MdiParent = this;
            childForm.FormClosed += (sender, args) => openedForms.Remove(childForm);
            childForm.Show();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductManagementToolStripButton_Click(object sender, EventArgs e)
        {
            ProductManagementForm childForm = new ProductManagementForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 0;
            openChildForms(childForm);
        }

        private void PointOfSaleToolStripButton_Click(object sender, EventArgs e)
        {
            PointOfSaleForm childForm = new PointOfSaleForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 600;
            openChildForms(childForm);
        }

        private void CreateQuotationToolStripButton_Click(object sender, EventArgs e)
        {
            CreateQuotationForm childForm = new CreateQuotationForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 100;
            childForm.Left = 0;
            openChildForms(childForm);
        }

        private void ArchiveQuotationToolStripButton_Click(object sender, EventArgs e)
        {
            ArchiveQuotationForm childForm = new ArchiveQuotationForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 100;
            childForm.Left = 600;
            openChildForms(childForm);
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
