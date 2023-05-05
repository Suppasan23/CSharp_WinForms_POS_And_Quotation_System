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
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            PM_DataGridView.RowTemplate.Height = 100;
            PM_DataGridView.Rows.Add("1", Image.FromFile(@"C:\Users\SUPPASAN\Desktop\CSharp_WinForms_POS_And_Quotation_System\Test-Picture\แปรงลวดเหล็ก.jpg"), "3562147859651", "แปรงลวดเหล็ก", "50", "80", "12", "อัน", "-");
            PM_DataGridView.Rows.Add("2", Image.FromFile(@"C:\Users\SUPPASAN\Desktop\CSharp_WinForms_POS_And_Quotation_System\Test-Picture\wilson basketball.jpg"), "4521584758632", "ลูกบาสเกตบอล", "200", "250", "2", "ลูก", "-");
            PM_DataGridView.Rows.Add("2", Image.FromFile(@"C:\Users\SUPPASAN\Desktop\CSharp_WinForms_POS_And_Quotation_System\Test-Picture\metalsquare.jpg"), "1247854785963", "เหล็กกล่องรูปพรรณ 1 1/2 x 1 1/2", "800", "1,000", "10", "ท่อน", "-");
            PM_DataGridView.Rows[1].Cells[6].Style.ForeColor = Color.Red;
        }

    }
}
