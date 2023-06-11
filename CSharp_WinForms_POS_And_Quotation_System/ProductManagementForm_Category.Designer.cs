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
            tableLayoutPanel1 = new TableLayoutPanel();
            PM_C_DeleteLinkLabel = new LinkLabel();
            label3 = new Label();
            PM_C_EditLinkLabel = new LinkLabel();
            label2 = new Label();
            PM_C_AddLinkLabel = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)PM_C_DataGridView1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            PM_C_HeadingLabel.Size = new Size(332, 50);
            PM_C_HeadingLabel.TabIndex = 3;
            PM_C_HeadingLabel.Text = "จัดการประเภทสินค้า";
            PM_C_HeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PM_C_DataGridView1
            // 
            PM_C_DataGridView1.BackgroundColor = SystemColors.Window;
            PM_C_DataGridView1.BorderStyle = BorderStyle.None;
            PM_C_DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel5.SetColumnSpan(PM_C_DataGridView1, 5);
            PM_C_DataGridView1.Dock = DockStyle.Fill;
            PM_C_DataGridView1.Location = new Point(1, 71);
            PM_C_DataGridView1.Margin = new Padding(0);
            PM_C_DataGridView1.Name = "PM_C_DataGridView1";
            PM_C_DataGridView1.RowTemplate.Height = 25;
            PM_C_DataGridView1.Size = new Size(332, 389);
            PM_C_DataGridView1.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel5.Controls.Add(PM_C_HeadingLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(PM_C_DataGridView1, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(334, 461);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.Controls.Add(PM_C_DeleteLinkLabel, 5, 0);
            tableLayoutPanel1.Controls.Add(label3, 4, 0);
            tableLayoutPanel1.Controls.Add(PM_C_EditLinkLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(PM_C_AddLinkLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(1, 52);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(332, 18);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // PM_C_DeleteLinkLabel
            // 
            PM_C_DeleteLinkLabel.Anchor = AnchorStyles.Bottom;
            PM_C_DeleteLinkLabel.AutoSize = true;
            PM_C_DeleteLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_DeleteLinkLabel.LinkColor = Color.FromArgb(192, 0, 0);
            PM_C_DeleteLinkLabel.Location = new Point(300, 0);
            PM_C_DeleteLinkLabel.Margin = new Padding(0);
            PM_C_DeleteLinkLabel.Name = "PM_C_DeleteLinkLabel";
            PM_C_DeleteLinkLabel.Size = new Size(26, 18);
            PM_C_DeleteLinkLabel.TabIndex = 11;
            PM_C_DeleteLinkLabel.TabStop = true;
            PM_C_DeleteLinkLabel.Text = "ลบ";
            PM_C_DeleteLinkLabel.TextAlign = ContentAlignment.BottomCenter;
            PM_C_DeleteLinkLabel.VisitedLinkColor = Color.FromArgb(192, 0, 0);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(278, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(22, 18);
            label3.TabIndex = 11;
            label3.Text = "/";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PM_C_EditLinkLabel
            // 
            PM_C_EditLinkLabel.Anchor = AnchorStyles.Bottom;
            PM_C_EditLinkLabel.AutoSize = true;
            PM_C_EditLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_EditLinkLabel.LinkColor = Color.FromArgb(128, 93, 7);
            PM_C_EditLinkLabel.Location = new Point(235, 0);
            PM_C_EditLinkLabel.Margin = new Padding(0);
            PM_C_EditLinkLabel.Name = "PM_C_EditLinkLabel";
            PM_C_EditLinkLabel.Size = new Size(43, 18);
            PM_C_EditLinkLabel.TabIndex = 11;
            PM_C_EditLinkLabel.TabStop = true;
            PM_C_EditLinkLabel.Text = "แก้ไข";
            PM_C_EditLinkLabel.TextAlign = ContentAlignment.BottomCenter;
            PM_C_EditLinkLabel.VisitedLinkColor = Color.FromArgb(128, 93, 7);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(22, 18);
            label2.TabIndex = 11;
            label2.Text = "/";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PM_C_AddLinkLabel
            // 
            PM_C_AddLinkLabel.Anchor = AnchorStyles.Bottom;
            PM_C_AddLinkLabel.AutoSize = true;
            PM_C_AddLinkLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_C_AddLinkLabel.LinkColor = Color.Green;
            PM_C_AddLinkLabel.Location = new Point(180, 0);
            PM_C_AddLinkLabel.Margin = new Padding(0);
            PM_C_AddLinkLabel.Name = "PM_C_AddLinkLabel";
            PM_C_AddLinkLabel.Size = new Size(33, 18);
            PM_C_AddLinkLabel.TabIndex = 11;
            PM_C_AddLinkLabel.TabStop = true;
            PM_C_AddLinkLabel.Text = "เพิ่ม";
            PM_C_AddLinkLabel.TextAlign = ContentAlignment.BottomCenter;
            PM_C_AddLinkLabel.VisitedLinkColor = Color.FromArgb(128, 93, 7);
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
            ClientSize = new Size(334, 461);
            Controls.Add(tableLayoutPanel5);
            Name = "ProductManagementForm_Category";
            Text = "Product Category";
            Load += ProductManagementForm_Category_Load;
            ((System.ComponentModel.ISupportInitialize)PM_C_DataGridView1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label PM_C_HeadingLabel;
        private DataGridView PM_C_DataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private LinkLabel PM_C_EditLinkLabel;
        private LinkLabel PM_C_DeleteLinkLabel;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel PM_C_AddLinkLabel;
    }
}