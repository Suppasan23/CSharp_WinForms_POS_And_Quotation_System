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
            tableLayoutPanel4 = new TableLayoutPanel();
            PM_C_Label1 = new Label();
            PM_C_TextBox1 = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            PM_C_AddLinkLabel = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            PM_C_EditLinkLabel = new LinkLabel();
            PM_C_DeleteLinkLabel = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)PM_C_DataGridView1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            PM_C_HeadingLabel.Size = new Size(462, 50);
            PM_C_HeadingLabel.TabIndex = 3;
            PM_C_HeadingLabel.Text = "จัดการประเภทสินค้า";
            PM_C_HeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PM_C_DataGridView1
            // 
            PM_C_DataGridView1.BorderStyle = BorderStyle.None;
            PM_C_DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PM_C_DataGridView1.Dock = DockStyle.Fill;
            PM_C_DataGridView1.Location = new Point(1, 103);
            PM_C_DataGridView1.Margin = new Padding(0);
            PM_C_DataGridView1.Name = "PM_C_DataGridView1";
            PM_C_DataGridView1.RowTemplate.Height = 25;
            PM_C_DataGridView1.Size = new Size(462, 407);
            PM_C_DataGridView1.TabIndex = 4;
            PM_C_DataGridView1.SelectionChanged += PM_C_DataGridView1_SelectionChanged;
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
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(464, 511);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1, 52);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(462, 50);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(PM_C_Label1, 0, 0);
            tableLayoutPanel4.Controls.Add(PM_C_TextBox1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1, 1);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tableLayoutPanel4.Size = new Size(299, 48);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // PM_C_Label1
            // 
            PM_C_Label1.AutoSize = true;
            PM_C_Label1.Dock = DockStyle.Fill;
            PM_C_Label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PM_C_Label1.Location = new Point(0, 0);
            PM_C_Label1.Margin = new Padding(0);
            PM_C_Label1.Name = "PM_C_Label1";
            PM_C_Label1.Size = new Size(299, 20);
            PM_C_Label1.TabIndex = 0;
            PM_C_Label1.Text = "โปรดใส่ชื่อประเภทสินค้า:";
            PM_C_Label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PM_C_TextBox1
            // 
            PM_C_TextBox1.BackColor = Color.LightCyan;
            PM_C_TextBox1.Dock = DockStyle.Fill;
            PM_C_TextBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_TextBox1.Location = new Point(1, 21);
            PM_C_TextBox1.Margin = new Padding(1);
            PM_C_TextBox1.Name = "PM_C_TextBox1";
            PM_C_TextBox1.Size = new Size(297, 26);
            PM_C_TextBox1.TabIndex = 13;
            PM_C_TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(PM_C_AddLinkLabel, 0, 0);
            tableLayoutPanel6.Controls.Add(label3, 3, 0);
            tableLayoutPanel6.Controls.Add(label2, 1, 0);
            tableLayoutPanel6.Controls.Add(PM_C_EditLinkLabel, 2, 0);
            tableLayoutPanel6.Controls.Add(PM_C_DeleteLinkLabel, 4, 0);
            tableLayoutPanel6.Location = new Point(301, 1);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(160, 46);
            tableLayoutPanel6.TabIndex = 13;
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
            PM_C_AddLinkLabel.Size = new Size(39, 46);
            PM_C_AddLinkLabel.TabIndex = 11;
            PM_C_AddLinkLabel.TabStop = true;
            PM_C_AddLinkLabel.Text = "เพิ่ม";
            PM_C_AddLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_AddLinkLabel.VisitedLinkColor = Color.FromArgb(128, 93, 7);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(14, 46);
            label3.TabIndex = 11;
            label3.Text = "/";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(15, 46);
            label2.TabIndex = 11;
            label2.Text = "/";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PM_C_EditLinkLabel
            // 
            PM_C_EditLinkLabel.AutoSize = true;
            PM_C_EditLinkLabel.Dock = DockStyle.Fill;
            PM_C_EditLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PM_C_EditLinkLabel.LinkColor = Color.FromArgb(128, 93, 7);
            PM_C_EditLinkLabel.Location = new Point(54, 0);
            PM_C_EditLinkLabel.Margin = new Padding(0);
            PM_C_EditLinkLabel.Name = "PM_C_EditLinkLabel";
            PM_C_EditLinkLabel.Size = new Size(52, 46);
            PM_C_EditLinkLabel.TabIndex = 11;
            PM_C_EditLinkLabel.TabStop = true;
            PM_C_EditLinkLabel.Text = "แก้ไข";
            PM_C_EditLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_EditLinkLabel.VisitedLinkColor = Color.FromArgb(128, 93, 7);
            // 
            // PM_C_DeleteLinkLabel
            // 
            PM_C_DeleteLinkLabel.AutoSize = true;
            PM_C_DeleteLinkLabel.Dock = DockStyle.Fill;
            PM_C_DeleteLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PM_C_DeleteLinkLabel.LinkColor = Color.FromArgb(192, 0, 0);
            PM_C_DeleteLinkLabel.Location = new Point(120, 0);
            PM_C_DeleteLinkLabel.Margin = new Padding(0);
            PM_C_DeleteLinkLabel.Name = "PM_C_DeleteLinkLabel";
            PM_C_DeleteLinkLabel.Size = new Size(40, 46);
            PM_C_DeleteLinkLabel.TabIndex = 11;
            PM_C_DeleteLinkLabel.TabStop = true;
            PM_C_DeleteLinkLabel.Text = "ลบ";
            PM_C_DeleteLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            PM_C_DeleteLinkLabel.VisitedLinkColor = Color.FromArgb(192, 0, 0);
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
            ClientSize = new Size(464, 511);
            Controls.Add(tableLayoutPanel5);
            Name = "ProductManagementForm_Category";
            Text = "Product Category";
            Load += ProductManagementForm_Category_Load;
            ((System.ComponentModel.ISupportInitialize)PM_C_DataGridView1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label PM_C_HeadingLabel;
        private DataGridView PM_C_DataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel2;
        private LinkLabel PM_C_DeleteLinkLabel;
        private Label label3;
        private Label label2;
        private LinkLabel PM_C_AddLinkLabel;
        private LinkLabel PM_C_EditLinkLabel;
        private TextBox PM_C_TextBox1;
        private Label PM_C_Label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel6;
    }
}