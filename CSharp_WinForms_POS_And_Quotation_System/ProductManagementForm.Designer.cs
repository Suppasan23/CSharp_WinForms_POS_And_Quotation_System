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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PM_PanelBase = new Panel();
            PM_Panel2 = new Panel();
            PM_DataGridView = new DataGridView();
            PM_StatusStrip = new StatusStrip();
            PM_ToolStripStatusLabel1 = new ToolStripStatusLabel();
            PM_TableLayoutPanel1 = new TableLayoutPanel();
            PM_TableLayoutPanel3 = new TableLayoutPanel();
            PM_DeleteButton = new Button();
            PM_AddButton = new Button();
            PM_EditButton = new Button();
            PM_TableLayoutPanel2 = new TableLayoutPanel();
            PM_SearchTextBox = new TextBox();
            PM_RefreshButton = new Button();
            PM_SearchButton = new Button();
            PM_ComboBox = new ComboBox();
            PM_Panel1 = new Panel();
            PM_HeadingLabel = new Label();
            PM_PanelBase.SuspendLayout();
            PM_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PM_DataGridView).BeginInit();
            PM_StatusStrip.SuspendLayout();
            PM_TableLayoutPanel1.SuspendLayout();
            PM_TableLayoutPanel3.SuspendLayout();
            PM_TableLayoutPanel2.SuspendLayout();
            PM_Panel1.SuspendLayout();
            SuspendLayout();
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
            PM_PanelBase.Size = new Size(1164, 1131);
            PM_PanelBase.TabIndex = 1;
            // 
            // PM_Panel2
            // 
            PM_Panel2.Controls.Add(PM_DataGridView);
            PM_Panel2.Controls.Add(PM_StatusStrip);
            PM_Panel2.Controls.Add(PM_TableLayoutPanel1);
            PM_Panel2.Dock = DockStyle.Fill;
            PM_Panel2.Location = new Point(0, 60);
            PM_Panel2.Margin = new Padding(3, 4, 3, 4);
            PM_Panel2.Name = "PM_Panel2";
            PM_Panel2.Size = new Size(1162, 1069);
            PM_Panel2.TabIndex = 1;
            // 
            // PM_DataGridView
            // 
            PM_DataGridView.AllowUserToAddRows = false;
            PM_DataGridView.AllowUserToDeleteRows = false;
            PM_DataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PM_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PM_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PM_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            PM_DataGridView.Dock = DockStyle.Fill;
            PM_DataGridView.Location = new Point(0, 42);
            PM_DataGridView.MultiSelect = false;
            PM_DataGridView.Name = "PM_DataGridView";
            PM_DataGridView.ReadOnly = true;
            PM_DataGridView.RowHeadersWidth = 51;
            PM_DataGridView.RowTemplate.Height = 25;
            PM_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PM_DataGridView.Size = new Size(1162, 1004);
            PM_DataGridView.TabIndex = 4;
            // 
            // PM_StatusStrip
            // 
            PM_StatusStrip.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_StatusStrip.ImageScalingSize = new Size(20, 20);
            PM_StatusStrip.Items.AddRange(new ToolStripItem[] { PM_ToolStripStatusLabel1 });
            PM_StatusStrip.Location = new Point(0, 1046);
            PM_StatusStrip.Name = "PM_StatusStrip";
            PM_StatusStrip.Size = new Size(1162, 23);
            PM_StatusStrip.TabIndex = 3;
            PM_StatusStrip.Text = "statusStrip1";
            // 
            // PM_ToolStripStatusLabel1
            // 
            PM_ToolStripStatusLabel1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_ToolStripStatusLabel1.Name = "PM_ToolStripStatusLabel1";
            PM_ToolStripStatusLabel1.Size = new Size(52, 18);
            PM_ToolStripStatusLabel1.Text = "รายการ";
            // 
            // PM_TableLayoutPanel1
            // 
            PM_TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PM_TableLayoutPanel1.ColumnCount = 2;
            PM_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            PM_TableLayoutPanel1.Controls.Add(PM_TableLayoutPanel3, 1, 0);
            PM_TableLayoutPanel1.Controls.Add(PM_TableLayoutPanel2, 0, 0);
            PM_TableLayoutPanel1.Dock = DockStyle.Top;
            PM_TableLayoutPanel1.Location = new Point(0, 0);
            PM_TableLayoutPanel1.Name = "PM_TableLayoutPanel1";
            PM_TableLayoutPanel1.RowCount = 1;
            PM_TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel1.Size = new Size(1162, 42);
            PM_TableLayoutPanel1.TabIndex = 2;
            // 
            // PM_TableLayoutPanel3
            // 
            PM_TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PM_TableLayoutPanel3.ColumnCount = 3;
            PM_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            PM_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            PM_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            PM_TableLayoutPanel3.Controls.Add(PM_DeleteButton, 2, 0);
            PM_TableLayoutPanel3.Controls.Add(PM_AddButton, 0, 0);
            PM_TableLayoutPanel3.Controls.Add(PM_EditButton, 1, 0);
            PM_TableLayoutPanel3.Dock = DockStyle.Fill;
            PM_TableLayoutPanel3.Location = new Point(881, 1);
            PM_TableLayoutPanel3.Margin = new Padding(0);
            PM_TableLayoutPanel3.Name = "PM_TableLayoutPanel3";
            PM_TableLayoutPanel3.RowCount = 1;
            PM_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel3.Size = new Size(280, 40);
            PM_TableLayoutPanel3.TabIndex = 0;
            // 
            // PM_DeleteButton
            // 
            PM_DeleteButton.Anchor = AnchorStyles.Left;
            PM_DeleteButton.BackColor = Color.MistyRose;
            PM_DeleteButton.Image = Properties.Resources.delete_16;
            PM_DeleteButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_DeleteButton.Location = new Point(189, 3);
            PM_DeleteButton.Margin = new Padding(2);
            PM_DeleteButton.Name = "PM_DeleteButton";
            PM_DeleteButton.Size = new Size(88, 34);
            PM_DeleteButton.TabIndex = 1;
            PM_DeleteButton.Text = "ลบ";
            PM_DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_DeleteButton.UseVisualStyleBackColor = false;
            // 
            // PM_AddButton
            // 
            PM_AddButton.Anchor = AnchorStyles.Left;
            PM_AddButton.BackColor = Color.Honeydew;
            PM_AddButton.Image = Properties.Resources.plus_2_16;
            PM_AddButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_AddButton.Location = new Point(3, 3);
            PM_AddButton.Margin = new Padding(2);
            PM_AddButton.Name = "PM_AddButton";
            PM_AddButton.Size = new Size(88, 34);
            PM_AddButton.TabIndex = 1;
            PM_AddButton.Text = "เพิ่ม";
            PM_AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_AddButton.UseVisualStyleBackColor = false;
            // 
            // PM_EditButton
            // 
            PM_EditButton.Anchor = AnchorStyles.Left;
            PM_EditButton.BackColor = Color.Cornsilk;
            PM_EditButton.Image = Properties.Resources.edit_16;
            PM_EditButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_EditButton.Location = new Point(96, 3);
            PM_EditButton.Margin = new Padding(2);
            PM_EditButton.Name = "PM_EditButton";
            PM_EditButton.Size = new Size(88, 34);
            PM_EditButton.TabIndex = 1;
            PM_EditButton.Text = "แก้ไข";
            PM_EditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_EditButton.UseVisualStyleBackColor = false;
            // 
            // PM_TableLayoutPanel2
            // 
            PM_TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PM_TableLayoutPanel2.ColumnCount = 4;
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            PM_TableLayoutPanel2.Controls.Add(PM_SearchTextBox, 0, 0);
            PM_TableLayoutPanel2.Controls.Add(PM_RefreshButton, 3, 0);
            PM_TableLayoutPanel2.Controls.Add(PM_SearchButton, 2, 0);
            PM_TableLayoutPanel2.Controls.Add(PM_ComboBox, 1, 0);
            PM_TableLayoutPanel2.Dock = DockStyle.Fill;
            PM_TableLayoutPanel2.Location = new Point(1, 1);
            PM_TableLayoutPanel2.Margin = new Padding(0);
            PM_TableLayoutPanel2.Name = "PM_TableLayoutPanel2";
            PM_TableLayoutPanel2.RowCount = 1;
            PM_TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel2.Size = new Size(879, 40);
            PM_TableLayoutPanel2.TabIndex = 1;
            // 
            // PM_SearchTextBox
            // 
            PM_SearchTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PM_SearchTextBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PM_SearchTextBox.Location = new Point(3, 6);
            PM_SearchTextBox.Margin = new Padding(2);
            PM_SearchTextBox.Name = "PM_SearchTextBox";
            PM_SearchTextBox.Size = new Size(486, 27);
            PM_SearchTextBox.TabIndex = 3;
            PM_SearchTextBox.KeyUp += PM_SearchTextBox_KeyUp;
            // 
            // PM_RefreshButton
            // 
            PM_RefreshButton.Anchor = AnchorStyles.Left;
            PM_RefreshButton.BackColor = Color.Azure;
            PM_RefreshButton.Image = Properties.Resources.refresh_2_16;
            PM_RefreshButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_RefreshButton.Location = new Point(788, 3);
            PM_RefreshButton.Margin = new Padding(2);
            PM_RefreshButton.Name = "PM_RefreshButton";
            PM_RefreshButton.Size = new Size(88, 34);
            PM_RefreshButton.TabIndex = 1;
            PM_RefreshButton.Text = "รีเฟรช";
            PM_RefreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_RefreshButton.UseVisualStyleBackColor = false;
            PM_RefreshButton.Click += PM_RefreshButton_Click;
            // 
            // PM_SearchButton
            // 
            PM_SearchButton.Anchor = AnchorStyles.Left;
            PM_SearchButton.BackColor = Color.WhiteSmoke;
            PM_SearchButton.Image = Properties.Resources.search_3_16;
            PM_SearchButton.ImageAlign = ContentAlignment.MiddleRight;
            PM_SearchButton.Location = new Point(695, 3);
            PM_SearchButton.Margin = new Padding(2);
            PM_SearchButton.Name = "PM_SearchButton";
            PM_SearchButton.Size = new Size(88, 34);
            PM_SearchButton.TabIndex = 1;
            PM_SearchButton.Text = "ค้นหา";
            PM_SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_SearchButton.UseVisualStyleBackColor = false;
            PM_SearchButton.Click += PM_SearchButton_Click;
            // 
            // PM_ComboBox
            // 
            PM_ComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PM_ComboBox.BackColor = SystemColors.Control;
            PM_ComboBox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PM_ComboBox.FormattingEnabled = true;
            PM_ComboBox.Location = new Point(494, 6);
            PM_ComboBox.Margin = new Padding(2);
            PM_ComboBox.Name = "PM_ComboBox";
            PM_ComboBox.Size = new Size(196, 27);
            PM_ComboBox.TabIndex = 4;
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
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 1131);
            Controls.Add(PM_PanelBase);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductManagementForm";
            Text = "Product Management";
            Load += ProductManagementForm_Load;
            PM_PanelBase.ResumeLayout(false);
            PM_Panel2.ResumeLayout(false);
            PM_Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PM_DataGridView).EndInit();
            PM_StatusStrip.ResumeLayout(false);
            PM_StatusStrip.PerformLayout();
            PM_TableLayoutPanel1.ResumeLayout(false);
            PM_TableLayoutPanel3.ResumeLayout(false);
            PM_TableLayoutPanel2.ResumeLayout(false);
            PM_TableLayoutPanel2.PerformLayout();
            PM_Panel1.ResumeLayout(false);
            PM_Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PM_PanelBase;
        private Panel PM_Panel2;
        private Button PM_DeleteButton;
        private Button PM_EditButton;
        private Button PM_AddButton;
        private Button PM_RefreshButton;
        private Button PM_SearchButton;
        private TableLayoutPanel PM_TableLayoutPanel1;
        private TableLayoutPanel PM_TableLayoutPanel3;
        private TableLayoutPanel PM_TableLayoutPanel2;
        private TextBox PM_SearchTextBox;
        private StatusStrip PM_StatusStrip;
        private ToolStripStatusLabel PM_ToolStripStatusLabel1;
        private DataGridView PM_DataGridView;
        private Panel PM_Panel1;
        private Label PM_HeadingLabel;
        private ComboBox PM_ComboBox;
    }
}