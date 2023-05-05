namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class ProductManagementForm
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
            PM_Panel1 = new Panel();
            PM_HeadingLabel = new Label();
            PM_PanelBase = new Panel();
            PM_Panel2 = new Panel();
            PM_TableLayoutPanel1 = new TableLayoutPanel();
            PM_SearchButton = new Button();
            PM_RefreshButton = new Button();
            PM_AddButton = new Button();
            PM_EditButton = new Button();
            PM_DeleteButton = new Button();
            PM_Panel1.SuspendLayout();
            PM_PanelBase.SuspendLayout();
            PM_Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PM_Panel1
            // 
            PM_Panel1.BackColor = SystemColors.InactiveCaption;
            PM_Panel1.Controls.Add(PM_HeadingLabel);
            PM_Panel1.Dock = DockStyle.Top;
            PM_Panel1.Location = new Point(0, 0);
            PM_Panel1.Margin = new Padding(3, 4, 3, 4);
            PM_Panel1.Name = "PM_Panel1";
            PM_Panel1.Size = new Size(1162, 60);
            PM_Panel1.TabIndex = 0;
            // 
            // PM_HeadingLabel
            // 
            PM_HeadingLabel.AutoSize = true;
            PM_HeadingLabel.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PM_HeadingLabel.Location = new Point(9, 10);
            PM_HeadingLabel.Margin = new Padding(0);
            PM_HeadingLabel.Name = "PM_HeadingLabel";
            PM_HeadingLabel.Size = new Size(179, 39);
            PM_HeadingLabel.TabIndex = 1;
            PM_HeadingLabel.Text = "จัดการสินค้า";
            // 
            // PM_PanelBase
            // 
            PM_PanelBase.BackColor = Color.Transparent;
            PM_PanelBase.BorderStyle = BorderStyle.FixedSingle;
            PM_PanelBase.Controls.Add(PM_Panel2);
            PM_PanelBase.Controls.Add(PM_Panel1);
            PM_PanelBase.Dock = DockStyle.Fill;
            PM_PanelBase.Location = new Point(0, 0);
            PM_PanelBase.Margin = new Padding(3, 4, 3, 4);
            PM_PanelBase.Name = "PM_PanelBase";
            PM_PanelBase.Size = new Size(1164, 1211);
            PM_PanelBase.TabIndex = 1;
            // 
            // PM_Panel2
            // 
            PM_Panel2.Controls.Add(PM_DeleteButton);
            PM_Panel2.Controls.Add(PM_EditButton);
            PM_Panel2.Controls.Add(PM_AddButton);
            PM_Panel2.Controls.Add(PM_RefreshButton);
            PM_Panel2.Controls.Add(PM_SearchButton);
            PM_Panel2.Controls.Add(PM_TableLayoutPanel1);
            PM_Panel2.Dock = DockStyle.Fill;
            PM_Panel2.Location = new Point(0, 60);
            PM_Panel2.Margin = new Padding(3, 4, 3, 4);
            PM_Panel2.Name = "PM_Panel2";
            PM_Panel2.Size = new Size(1162, 1149);
            PM_Panel2.TabIndex = 1;
            // 
            // PM_TableLayoutPanel1
            // 
            PM_TableLayoutPanel1.ColumnCount = 2;
            PM_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PM_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PM_TableLayoutPanel1.Dock = DockStyle.Top;
            PM_TableLayoutPanel1.Location = new Point(0, 0);
            PM_TableLayoutPanel1.Name = "PM_TableLayoutPanel1";
            PM_TableLayoutPanel1.RowCount = 1;
            PM_TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            PM_TableLayoutPanel1.Size = new Size(1162, 30);
            PM_TableLayoutPanel1.TabIndex = 0;
            // 
            // PM_SearchButton
            // 
            PM_SearchButton.BackColor = Color.WhiteSmoke;
            PM_SearchButton.Image = Properties.Resources.search_3_16;
            PM_SearchButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_SearchButton.Location = new Point(236, 379);
            PM_SearchButton.Name = "PM_SearchButton";
            PM_SearchButton.Size = new Size(100, 30);
            PM_SearchButton.TabIndex = 1;
            PM_SearchButton.Text = "ค้นหา";
            PM_SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_SearchButton.UseVisualStyleBackColor = false;
            // 
            // PM_RefreshButton
            // 
            PM_RefreshButton.BackColor = Color.Azure;
            PM_RefreshButton.Image = Properties.Resources.refresh_2_16;
            PM_RefreshButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_RefreshButton.Location = new Point(371, 379);
            PM_RefreshButton.Name = "PM_RefreshButton";
            PM_RefreshButton.Size = new Size(100, 30);
            PM_RefreshButton.TabIndex = 1;
            PM_RefreshButton.Text = "รีเฟรช";
            PM_RefreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_RefreshButton.UseVisualStyleBackColor = false;
            // 
            // PM_AddButton
            // 
            PM_AddButton.BackColor = Color.Honeydew;
            PM_AddButton.Image = Properties.Resources.plus_2_16;
            PM_AddButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_AddButton.Location = new Point(504, 379);
            PM_AddButton.Name = "PM_AddButton";
            PM_AddButton.Size = new Size(100, 30);
            PM_AddButton.TabIndex = 1;
            PM_AddButton.Text = "เพิ่ม";
            PM_AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_AddButton.UseVisualStyleBackColor = false;
            // 
            // PM_EditButton
            // 
            PM_EditButton.BackColor = Color.Cornsilk;
            PM_EditButton.Image = Properties.Resources.edit_16;
            PM_EditButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_EditButton.Location = new Point(634, 379);
            PM_EditButton.Name = "PM_EditButton";
            PM_EditButton.Size = new Size(100, 30);
            PM_EditButton.TabIndex = 1;
            PM_EditButton.Text = "แก้ไข";
            PM_EditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_EditButton.UseVisualStyleBackColor = false;
            // 
            // PM_DeleteButton
            // 
            PM_DeleteButton.BackColor = Color.MistyRose;
            PM_DeleteButton.Image = Properties.Resources.delete_16;
            PM_DeleteButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_DeleteButton.Location = new Point(758, 379);
            PM_DeleteButton.Name = "PM_DeleteButton";
            PM_DeleteButton.Size = new Size(100, 30);
            PM_DeleteButton.TabIndex = 1;
            PM_DeleteButton.Text = "ลบ";
            PM_DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 1211);
            Controls.Add(PM_PanelBase);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductManagementForm";
            Text = "Product Management";
            Load += ProductManagementForm_Load;
            PM_Panel1.ResumeLayout(false);
            PM_Panel1.PerformLayout();
            PM_PanelBase.ResumeLayout(false);
            PM_Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PM_Panel1;
        private Panel PM_PanelBase;
        private Label PM_HeadingLabel;
        private Panel PM_Panel2;
        private TableLayoutPanel PM_TableLayoutPanel1;
        private Button PM_DeleteButton;
        private Button PM_EditButton;
        private Button PM_AddButton;
        private Button PM_RefreshButton;
        private Button PM_SearchButton;
    }
}