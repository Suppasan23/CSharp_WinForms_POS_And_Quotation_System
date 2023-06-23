namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class ProductManagementForm_Category
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
            PM_C_HeadingLabel = new Label();
            PM_C_DataGridView1 = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            PM_C_DeleteLinkLabel = new LinkLabel();
            PM_C_AddLinkLabel = new LinkLabel();
            PM_C_CancelLabel = new LinkLabel();
            PM_C_EditLinkLabel = new LinkLabel();
            PM_C_SaveLabel = new LinkLabel();
            tableLayoutPanel4 = new TableLayoutPanel();
            PM_C_TextBox1 = new TextBox();
            PM_C_Label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)PM_C_DataGridView1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // PM_C_HeadingLabel
            // 
            PM_C_HeadingLabel.AutoSize = true;
            PM_C_HeadingLabel.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel5.SetColumnSpan(PM_C_HeadingLabel, 5);
            PM_C_HeadingLabel.Dock = DockStyle.Fill;
            PM_C_HeadingLabel.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_HeadingLabel.Location = new Point(1, 1);
            PM_C_HeadingLabel.Margin = new Padding(0);
            PM_C_HeadingLabel.Name = "PM_C_HeadingLabel";
            PM_C_HeadingLabel.Size = new Size(541, 50);
            PM_C_HeadingLabel.TabIndex = 3;
            PM_C_HeadingLabel.Text = "จัดการประเภทสินค้า";
            PM_C_HeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PM_C_DataGridView1
            // 
            PM_C_DataGridView1.BorderStyle = BorderStyle.None;
            PM_C_DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PM_C_DataGridView1.Dock = DockStyle.Fill;
            PM_C_DataGridView1.Location = new Point(1, 113);
            PM_C_DataGridView1.Margin = new Padding(0);
            PM_C_DataGridView1.Name = "PM_C_DataGridView1";
            PM_C_DataGridView1.RowHeadersWidth = 51;
            PM_C_DataGridView1.RowTemplate.Height = 25;
            PM_C_DataGridView1.Size = new Size(541, 409);
            PM_C_DataGridView1.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(PM_C_DataGridView1, 0, 2);
            tableLayoutPanel5.Controls.Add(PM_C_HeadingLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(543, 523);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1, 52);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(541, 60);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.8461151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.236496F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9173946F));
            tableLayoutPanel1.Controls.Add(PM_C_DeleteLinkLabel, 4, 0);
            tableLayoutPanel1.Controls.Add(PM_C_AddLinkLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(PM_C_CancelLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(PM_C_EditLinkLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(PM_C_SaveLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(391, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(146, 52);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // PM_C_DeleteLinkLabel
            // 
            PM_C_DeleteLinkLabel.AutoSize = true;
            PM_C_DeleteLinkLabel.Dock = DockStyle.Fill;
            PM_C_DeleteLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PM_C_DeleteLinkLabel.LinkColor = Color.FromArgb(192, 0, 0);
            PM_C_DeleteLinkLabel.Location = new Point(109, 0);
            PM_C_DeleteLinkLabel.Margin = new Padding(0);
            PM_C_DeleteLinkLabel.Name = "PM_C_DeleteLinkLabel";
            PM_C_DeleteLinkLabel.Size = new Size(37, 52);
            PM_C_DeleteLinkLabel.TabIndex = 11;
            PM_C_DeleteLinkLabel.TabStop = true;
            PM_C_DeleteLinkLabel.Text = "ลบ";
            PM_C_DeleteLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_DeleteLinkLabel.VisitedLinkColor = Color.FromArgb(192, 0, 0);
            PM_C_DeleteLinkLabel.LinkClicked += PM_C_DeleteLinkLabel_LinkClicked;
            // 
            // PM_C_AddLinkLabel
            // 
            PM_C_AddLinkLabel.AutoSize = true;
            PM_C_AddLinkLabel.Dock = DockStyle.Fill;
            PM_C_AddLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PM_C_AddLinkLabel.LinkColor = Color.Green;
            PM_C_AddLinkLabel.Location = new Point(0, 0);
            PM_C_AddLinkLabel.Margin = new Padding(0);
            PM_C_AddLinkLabel.Name = "PM_C_AddLinkLabel";
            PM_C_AddLinkLabel.Size = new Size(44, 52);
            PM_C_AddLinkLabel.TabIndex = 11;
            PM_C_AddLinkLabel.TabStop = true;
            PM_C_AddLinkLabel.Text = "เพิ่ม";
            PM_C_AddLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_AddLinkLabel.VisitedLinkColor = Color.FromArgb(128, 93, 7);
            PM_C_AddLinkLabel.LinkClicked += PM_C_AddLinkLabel_LinkClicked;
            // 
            // PM_C_CancelLabel
            // 
            PM_C_CancelLabel.AutoSize = true;
            PM_C_CancelLabel.Dock = DockStyle.Fill;
            PM_C_CancelLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_CancelLabel.ForeColor = Color.Black;
            PM_C_CancelLabel.LinkColor = Color.Black;
            PM_C_CancelLabel.Location = new Point(106, 0);
            PM_C_CancelLabel.Name = "PM_C_CancelLabel";
            PM_C_CancelLabel.Size = new Size(1, 52);
            PM_C_CancelLabel.TabIndex = 12;
            PM_C_CancelLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_CancelLabel.VisitedLinkColor = Color.Black;
            PM_C_CancelLabel.LinkClicked += PM_C_CancelLabel_LinkClicked;
            // 
            // PM_C_EditLinkLabel
            // 
            PM_C_EditLinkLabel.AutoSize = true;
            PM_C_EditLinkLabel.Dock = DockStyle.Fill;
            PM_C_EditLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PM_C_EditLinkLabel.LinkColor = Color.FromArgb(128, 93, 7);
            PM_C_EditLinkLabel.Location = new Point(50, 0);
            PM_C_EditLinkLabel.Margin = new Padding(0);
            PM_C_EditLinkLabel.Name = "PM_C_EditLinkLabel";
            PM_C_EditLinkLabel.Size = new Size(53, 52);
            PM_C_EditLinkLabel.TabIndex = 11;
            PM_C_EditLinkLabel.TabStop = true;
            PM_C_EditLinkLabel.Text = "แก้ไข";
            PM_C_EditLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_EditLinkLabel.VisitedLinkColor = Color.FromArgb(128, 93, 7);
            PM_C_EditLinkLabel.LinkClicked += PM_C_EditLinkLabel_LinkClicked;
            // 
            // PM_C_SaveLabel
            // 
            PM_C_SaveLabel.AutoSize = true;
            PM_C_SaveLabel.Dock = DockStyle.Fill;
            PM_C_SaveLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_SaveLabel.ForeColor = Color.FromArgb(0, 0, 192);
            PM_C_SaveLabel.LinkColor = Color.FromArgb(0, 0, 192);
            PM_C_SaveLabel.Location = new Point(47, 0);
            PM_C_SaveLabel.Name = "PM_C_SaveLabel";
            PM_C_SaveLabel.Size = new Size(1, 52);
            PM_C_SaveLabel.TabIndex = 12;
            PM_C_SaveLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_SaveLabel.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            PM_C_SaveLabel.LinkClicked += PM_C_SaveLabel_LinkClicked;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(PM_C_TextBox1, 0, 1);
            tableLayoutPanel4.Controls.Add(PM_C_Label1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1, 1);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(386, 58);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // PM_C_TextBox1
            // 
            PM_C_TextBox1.BackColor = Color.DarkGray;
            PM_C_TextBox1.Dock = DockStyle.Fill;
            PM_C_TextBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_TextBox1.Location = new Point(1, 30);
            PM_C_TextBox1.Margin = new Padding(1);
            PM_C_TextBox1.Name = "PM_C_TextBox1";
            PM_C_TextBox1.RightToLeft = RightToLeft.No;
            PM_C_TextBox1.Size = new Size(384, 26);
            PM_C_TextBox1.TabIndex = 13;
            PM_C_TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PM_C_Label1
            // 
            PM_C_Label1.AutoSize = true;
            PM_C_Label1.Dock = DockStyle.Fill;
            PM_C_Label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_Label1.Location = new Point(0, 0);
            PM_C_Label1.Margin = new Padding(0);
            PM_C_Label1.Name = "PM_C_Label1";
            PM_C_Label1.Size = new Size(386, 29);
            PM_C_Label1.TabIndex = 0;
            PM_C_Label1.Text = "...";
            PM_C_Label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // ProductManagementForm_Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 523);
            Controls.Add(tableLayoutPanel5);
            Name = "ProductManagementForm_Category";
            Text = "Product Category";
            Load += ProductManagementForm_Category_Load;
            ((System.ComponentModel.ISupportInitialize)PM_C_DataGridView1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label PM_C_HeadingLabel;
        private DataGridView PM_C_DataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel2;
        private LinkLabel PM_C_DeleteLinkLabel;
        private LinkLabel PM_C_AddLinkLabel;
        private LinkLabel PM_C_EditLinkLabel;
        private TextBox PM_C_TextBox1;
        private Label PM_C_Label1;
        private LinkLabel PM_C_CancelLabel;
        private LinkLabel PM_C_SaveLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
    }
}