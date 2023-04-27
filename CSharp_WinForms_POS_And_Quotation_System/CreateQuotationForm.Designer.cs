namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class CreateQuotationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            CompanyNameLabel = new Label();
            CompanyNameEditButton = new Button();
            CustomerNameEditButton = new Button();
            CompanyAddressLabel = new Label();
            CompanyAddressTextBox = new TextBox();
            CompanyNameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tableLayoutPanel1 = new TableLayoutPanel();
            CompanyTelephoneLabel = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 1161);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(250, 253, 236);
            panel3.Controls.Add(CompanyNameEditButton);
            panel3.Controls.Add(CustomerNameEditButton);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 1099);
            panel3.TabIndex = 2;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Dock = DockStyle.Top;
            CompanyNameLabel.Location = new Point(0, 0);
            CompanyNameLabel.Margin = new Padding(0);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(177, 18);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "ชื่อบริษัท";
            CompanyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CompanyNameEditButton
            // 
            CompanyNameEditButton.Location = new Point(859, 638);
            CompanyNameEditButton.Margin = new Padding(0);
            CompanyNameEditButton.Name = "CompanyNameEditButton";
            CompanyNameEditButton.Size = new Size(103, 30);
            CompanyNameEditButton.TabIndex = 2;
            CompanyNameEditButton.Text = "แก้ไข";
            CompanyNameEditButton.UseVisualStyleBackColor = true;
            // 
            // CustomerNameEditButton
            // 
            CustomerNameEditButton.Location = new Point(859, 816);
            CustomerNameEditButton.Margin = new Padding(0);
            CustomerNameEditButton.Name = "CustomerNameEditButton";
            CustomerNameEditButton.Size = new Size(103, 30);
            CustomerNameEditButton.TabIndex = 0;
            CustomerNameEditButton.Text = "แก้ไข";
            CustomerNameEditButton.UseVisualStyleBackColor = true;
            // 
            // CompanyAddressLabel
            // 
            CompanyAddressLabel.AutoSize = true;
            CompanyAddressLabel.Dock = DockStyle.Top;
            CompanyAddressLabel.Location = new Point(0, 58);
            CompanyAddressLabel.Margin = new Padding(0);
            CompanyAddressLabel.Name = "CompanyAddressLabel";
            CompanyAddressLabel.Size = new Size(177, 18);
            CompanyAddressLabel.TabIndex = 3;
            CompanyAddressLabel.Text = "ที่อยู่บริษัท";
            CompanyAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CompanyAddressTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(CompanyAddressTextBox, 5);
            CompanyAddressTextBox.Dock = DockStyle.Top;
            CompanyAddressTextBox.Location = new Point(177, 58);
            CompanyAddressTextBox.Margin = new Padding(0);
            CompanyAddressTextBox.Multiline = true;
            CompanyAddressTextBox.Name = "CompanyAddressTextBox";
            tableLayoutPanel1.SetRowSpan(CompanyAddressTextBox, 2);
            CompanyAddressTextBox.Size = new Size(889, 50);
            CompanyAddressTextBox.TabIndex = 4;
            // 
            // CompanyNameTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(CompanyNameTextBox, 5);
            CompanyNameTextBox.Dock = DockStyle.Top;
            CompanyNameTextBox.Location = new Point(177, 0);
            CompanyNameTextBox.Margin = new Padding(0);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.Size = new Size(889, 26);
            CompanyNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(3, 432);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 180);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ชื่อ/ที่อยู่ลูกค้า";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Location = new Point(5, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1066, 127);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1076, 299);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ชื่อ/ที่อยู่บริษัท";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 232, 74);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 8);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(251, 39);
            label1.TabIndex = 0;
            label1.Text = "สร้างใบเสนอราคา";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(CompanyNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(CompanyNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(CompanyAddressTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(CompanyAddressLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(CompanyTelephoneLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 5);
            tableLayoutPanel1.Location = new Point(5, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(1066, 208);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // CompanyTelephoneLabel
            // 
            CompanyTelephoneLabel.AutoSize = true;
            CompanyTelephoneLabel.Dock = DockStyle.Top;
            CompanyTelephoneLabel.Location = new Point(0, 145);
            CompanyTelephoneLabel.Margin = new Padding(0);
            CompanyTelephoneLabel.Name = "CompanyTelephoneLabel";
            CompanyTelephoneLabel.Size = new Size(177, 18);
            CompanyTelephoneLabel.TabIndex = 5;
            CompanyTelephoneLabel.Text = "เบอร์โทรบริษัท";
            CompanyTelephoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(177, 145);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 26);
            textBox1.TabIndex = 6;
            // 
            // CreateQuotationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 1161);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateQuotationForm";
            Text = "Create Quotation";
            Load += CreateQuotationForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Button CompanyNameEditButton;
        private Label CompanyNameLabel;
        private TextBox CompanyNameTextBox;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button CustomerNameEditButton;
        private Label CompanyAddressLabel;
        private TextBox CompanyAddressTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label CompanyTelephoneLabel;
        private TextBox textBox1;
    }
}