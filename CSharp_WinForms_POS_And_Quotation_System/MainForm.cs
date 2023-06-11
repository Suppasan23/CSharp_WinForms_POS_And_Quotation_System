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

        private void M_ProductManagementToolStripButton_Click(object sender, EventArgs e)
        {
            ProductManagementForm childForm = new ProductManagementForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 0;
            openChildForms(childForm);
        }

        private void M_PointOfSaleToolStripButton_Click(object sender, EventArgs e)
        {
            PointOfSaleForm childForm = new PointOfSaleForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 800;
            openChildForms(childForm);
        }

        private void M_CreateQuotationToolStripButton_Click(object sender, EventArgs e)
        {
            CreateQuotationForm childForm = new CreateQuotationForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 200;
            openChildForms(childForm);
        }

        private void M_ArchiveQuotationToolStripButton_Click(object sender, EventArgs e)
        {
            ArchiveQuotationForm childForm = new ArchiveQuotationForm();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 1000;
            openChildForms(childForm);
        }

        private void M_CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagementForm_Category childForm = new ProductManagementForm_Category();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 1000;
            openChildForms(childForm);
        }

        private void M_CRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagementForm_CRUD childForm = new ProductManagementForm_CRUD();
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Top = 0;
            childForm.Left = 1000;
            openChildForms(childForm);
        }

        private void M_ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void M_ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
