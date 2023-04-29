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
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            KeywordTextBox = new TextBox();
            SearchButton = new Button();
            RefreshButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            AddItemButton = new Button();
            DeleteItemButton = new Button();
            EditItemButton = new Button();
            panel3 = new Panel();
            PM_DataGridView = new DataGridView();
            PM_StatusStrip = new StatusStrip();
            PM_ToolStripStatusLabel = new ToolStripStatusLabel();
            PM_TableLayoutPanel1 = new TableLayoutPanel();
            PM_TableLayoutPanel2 = new TableLayoutPanel();
            PM_SearchTextBox = new TextBox();
            PM_SerachButton = new Button();
            PM_RefreshButton = new Button();
            PM_TableLayoutPanel3 = new TableLayoutPanel();
            PM_AddButton = new Button();
            PM_DeleteButton = new Button();
            PM_EditButton = new Button();
            PM_Panel1 = new Panel();
            PM_HeadingLabel = new Label();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PM_DataGridView).BeginInit();
            PM_StatusStrip.SuspendLayout();
            PM_TableLayoutPanel1.SuspendLayout();
            PM_TableLayoutPanel2.SuspendLayout();
            PM_TableLayoutPanel3.SuspendLayout();
            PM_Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 334F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel5.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel5.Controls.Add(button1, 1, 0);
            tableLayoutPanel5.Controls.Add(button2, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(1, 1);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1, 98);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(2, 2);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1, 30);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(-219, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(106, 94);
            button1.TabIndex = 1;
            button1.Text = "ค้นหา";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Azure;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(-109, 2);
            button2.Margin = new Padding(2, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 94);
            button2.TabIndex = 2;
            button2.Text = "รีเฟรช";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel6.Controls.Add(button3, 0, 0);
            tableLayoutPanel6.Controls.Add(button4, 2, 0);
            tableLayoutPanel6.Controls.Add(button5, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(-135, 1);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(334, 98);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(4, 2);
            button3.Margin = new Padding(4, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(106, 94);
            button3.TabIndex = 0;
            button3.Text = "เพิ่ม";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 221, 221);
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(224, 2);
            button4.Margin = new Padding(2, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(106, 94);
            button4.TabIndex = 2;
            button4.Text = "ลบ";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Cornsilk;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(114, 2);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(106, 94);
            button5.TabIndex = 1;
            button5.Text = "แก้ไข";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 334F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.Controls.Add(KeywordTextBox, 0, 0);
            tableLayoutPanel2.Controls.Add(SearchButton, 1, 0);
            tableLayoutPanel2.Controls.Add(RefreshButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1, 1);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1, 98);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // KeywordTextBox
            // 
            KeywordTextBox.Dock = DockStyle.Fill;
            KeywordTextBox.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            KeywordTextBox.Location = new Point(2, 2);
            KeywordTextBox.Margin = new Padding(2);
            KeywordTextBox.Name = "KeywordTextBox";
            KeywordTextBox.Size = new Size(1, 30);
            KeywordTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.WhiteSmoke;
            SearchButton.Dock = DockStyle.Fill;
            SearchButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(-219, 2);
            SearchButton.Margin = new Padding(2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(106, 94);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "ค้นหา";
            SearchButton.TextAlign = ContentAlignment.MiddleRight;
            SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.Azure;
            RefreshButton.Dock = DockStyle.Fill;
            RefreshButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.Location = new Point(-109, 2);
            RefreshButton.Margin = new Padding(2, 2, 4, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(106, 94);
            RefreshButton.TabIndex = 2;
            RefreshButton.Text = "รีเฟรช";
            RefreshButton.TextAlign = ContentAlignment.MiddleRight;
            RefreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RefreshButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.Controls.Add(AddItemButton, 0, 0);
            tableLayoutPanel3.Controls.Add(DeleteItemButton, 2, 0);
            tableLayoutPanel3.Controls.Add(EditItemButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(-135, 1);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(334, 98);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // AddItemButton
            // 
            AddItemButton.BackColor = Color.Honeydew;
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemButton.Location = new Point(4, 2);
            AddItemButton.Margin = new Padding(4, 2, 2, 2);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(106, 94);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "เพิ่ม";
            AddItemButton.TextAlign = ContentAlignment.MiddleRight;
            AddItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddItemButton.UseVisualStyleBackColor = false;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.BackColor = Color.FromArgb(255, 221, 221);
            DeleteItemButton.Dock = DockStyle.Fill;
            DeleteItemButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteItemButton.Location = new Point(224, 2);
            DeleteItemButton.Margin = new Padding(2, 2, 4, 2);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(106, 94);
            DeleteItemButton.TabIndex = 2;
            DeleteItemButton.Text = "ลบ";
            DeleteItemButton.TextAlign = ContentAlignment.MiddleRight;
            DeleteItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteItemButton.UseVisualStyleBackColor = false;
            // 
            // EditItemButton
            // 
            EditItemButton.BackColor = Color.Cornsilk;
            EditItemButton.Dock = DockStyle.Fill;
            EditItemButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditItemButton.Location = new Point(114, 2);
            EditItemButton.Margin = new Padding(2);
            EditItemButton.Name = "EditItemButton";
            EditItemButton.Size = new Size(106, 94);
            EditItemButton.TabIndex = 1;
            EditItemButton.Text = "แก้ไข";
            EditItemButton.TextAlign = ContentAlignment.MiddleRight;
            EditItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditItemButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(PM_DataGridView);
            panel3.Controls.Add(PM_StatusStrip);
            panel3.Controls.Add(PM_TableLayoutPanel1);
            panel3.Controls.Add(PM_Panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1184, 1261);
            panel3.TabIndex = 0;
            // 
            // PM_DataGridView
            // 
            PM_DataGridView.BackgroundColor = SystemColors.ControlLight;
            PM_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PM_DataGridView.Dock = DockStyle.Fill;
            PM_DataGridView.Location = new Point(0, 96);
            PM_DataGridView.MultiSelect = false;
            PM_DataGridView.Name = "PM_DataGridView";
            PM_DataGridView.RowHeadersWidth = 51;
            PM_DataGridView.RowTemplate.Height = 25;
            PM_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PM_DataGridView.Size = new Size(1182, 1140);
            PM_DataGridView.TabIndex = 6;
            // 
            // PM_StatusStrip
            // 
            PM_StatusStrip.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_StatusStrip.ImageScalingSize = new Size(20, 20);
            PM_StatusStrip.Items.AddRange(new ToolStripItem[] { PM_ToolStripStatusLabel });
            PM_StatusStrip.Location = new Point(0, 1236);
            PM_StatusStrip.Name = "PM_StatusStrip";
            PM_StatusStrip.Size = new Size(1182, 23);
            PM_StatusStrip.TabIndex = 5;
            PM_StatusStrip.Text = "statusStrip1";
            // 
            // PM_ToolStripStatusLabel
            // 
            PM_ToolStripStatusLabel.Name = "PM_ToolStripStatusLabel";
            PM_ToolStripStatusLabel.Size = new Size(52, 18);
            PM_ToolStripStatusLabel.Text = "รายการ";
            // 
            // PM_TableLayoutPanel1
            // 
            PM_TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PM_TableLayoutPanel1.ColumnCount = 2;
            PM_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 334F));
            PM_TableLayoutPanel1.Controls.Add(PM_TableLayoutPanel2, 0, 0);
            PM_TableLayoutPanel1.Controls.Add(PM_TableLayoutPanel3, 1, 0);
            PM_TableLayoutPanel1.Dock = DockStyle.Top;
            PM_TableLayoutPanel1.Location = new Point(0, 60);
            PM_TableLayoutPanel1.Name = "PM_TableLayoutPanel1";
            PM_TableLayoutPanel1.RowCount = 1;
            PM_TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel1.Size = new Size(1182, 36);
            PM_TableLayoutPanel1.TabIndex = 4;
            // 
            // PM_TableLayoutPanel2
            // 
            PM_TableLayoutPanel2.ColumnCount = 3;
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            PM_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            PM_TableLayoutPanel2.Controls.Add(PM_SearchTextBox, 0, 0);
            PM_TableLayoutPanel2.Controls.Add(PM_SerachButton, 1, 0);
            PM_TableLayoutPanel2.Controls.Add(PM_RefreshButton, 2, 0);
            PM_TableLayoutPanel2.Dock = DockStyle.Fill;
            PM_TableLayoutPanel2.Location = new Point(1, 1);
            PM_TableLayoutPanel2.Margin = new Padding(0);
            PM_TableLayoutPanel2.Name = "PM_TableLayoutPanel2";
            PM_TableLayoutPanel2.RowCount = 1;
            PM_TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel2.Size = new Size(845, 34);
            PM_TableLayoutPanel2.TabIndex = 0;
            // 
            // PM_SearchTextBox
            // 
            PM_SearchTextBox.Dock = DockStyle.Fill;
            PM_SearchTextBox.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_SearchTextBox.Location = new Point(2, 2);
            PM_SearchTextBox.Margin = new Padding(2);
            PM_SearchTextBox.Name = "PM_SearchTextBox";
            PM_SearchTextBox.Size = new Size(619, 30);
            PM_SearchTextBox.TabIndex = 0;
            // 
            // PM_SerachButton
            // 
            PM_SerachButton.BackColor = Color.WhiteSmoke;
            PM_SerachButton.Dock = DockStyle.Fill;
            PM_SerachButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_SerachButton.Image = Properties.Resources.search_3_16;
            PM_SerachButton.Location = new Point(625, 2);
            PM_SerachButton.Margin = new Padding(2);
            PM_SerachButton.Name = "PM_SerachButton";
            PM_SerachButton.Size = new Size(106, 30);
            PM_SerachButton.TabIndex = 1;
            PM_SerachButton.Text = "ค้นหา";
            PM_SerachButton.TextAlign = ContentAlignment.MiddleRight;
            PM_SerachButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_SerachButton.UseVisualStyleBackColor = false;
            // 
            // PM_RefreshButton
            // 
            PM_RefreshButton.BackColor = Color.Azure;
            PM_RefreshButton.Dock = DockStyle.Fill;
            PM_RefreshButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_RefreshButton.Image = Properties.Resources.refresh_2_16;
            PM_RefreshButton.Location = new Point(735, 2);
            PM_RefreshButton.Margin = new Padding(2, 2, 4, 2);
            PM_RefreshButton.Name = "PM_RefreshButton";
            PM_RefreshButton.Size = new Size(106, 30);
            PM_RefreshButton.TabIndex = 2;
            PM_RefreshButton.Text = "รีเฟรช";
            PM_RefreshButton.TextAlign = ContentAlignment.MiddleRight;
            PM_RefreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_RefreshButton.UseVisualStyleBackColor = false;
            // 
            // PM_TableLayoutPanel3
            // 
            PM_TableLayoutPanel3.ColumnCount = 3;
            PM_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            PM_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            PM_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            PM_TableLayoutPanel3.Controls.Add(PM_AddButton, 0, 0);
            PM_TableLayoutPanel3.Controls.Add(PM_DeleteButton, 2, 0);
            PM_TableLayoutPanel3.Controls.Add(PM_EditButton, 1, 0);
            PM_TableLayoutPanel3.Dock = DockStyle.Fill;
            PM_TableLayoutPanel3.Location = new Point(847, 1);
            PM_TableLayoutPanel3.Margin = new Padding(0);
            PM_TableLayoutPanel3.Name = "PM_TableLayoutPanel3";
            PM_TableLayoutPanel3.RowCount = 1;
            PM_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PM_TableLayoutPanel3.Size = new Size(334, 34);
            PM_TableLayoutPanel3.TabIndex = 1;
            // 
            // PM_AddButton
            // 
            PM_AddButton.BackColor = Color.Honeydew;
            PM_AddButton.Dock = DockStyle.Fill;
            PM_AddButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_AddButton.Image = Properties.Resources.plus_2_16;
            PM_AddButton.Location = new Point(4, 2);
            PM_AddButton.Margin = new Padding(4, 2, 2, 2);
            PM_AddButton.Name = "PM_AddButton";
            PM_AddButton.Size = new Size(106, 30);
            PM_AddButton.TabIndex = 0;
            PM_AddButton.Text = "เพิ่ม";
            PM_AddButton.TextAlign = ContentAlignment.MiddleRight;
            PM_AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_AddButton.UseVisualStyleBackColor = false;
            // 
            // PM_DeleteButton
            // 
            PM_DeleteButton.BackColor = Color.FromArgb(255, 221, 221);
            PM_DeleteButton.Dock = DockStyle.Fill;
            PM_DeleteButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_DeleteButton.Image = Properties.Resources.delete_16;
            PM_DeleteButton.Location = new Point(224, 2);
            PM_DeleteButton.Margin = new Padding(2, 2, 4, 2);
            PM_DeleteButton.Name = "PM_DeleteButton";
            PM_DeleteButton.Size = new Size(106, 30);
            PM_DeleteButton.TabIndex = 2;
            PM_DeleteButton.Text = "ลบ";
            PM_DeleteButton.TextAlign = ContentAlignment.MiddleRight;
            PM_DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_DeleteButton.UseVisualStyleBackColor = false;
            // 
            // PM_EditButton
            // 
            PM_EditButton.BackColor = Color.Cornsilk;
            PM_EditButton.Dock = DockStyle.Fill;
            PM_EditButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_EditButton.Image = Properties.Resources.edit;
            PM_EditButton.Location = new Point(114, 2);
            PM_EditButton.Margin = new Padding(2);
            PM_EditButton.Name = "PM_EditButton";
            PM_EditButton.Size = new Size(106, 30);
            PM_EditButton.TabIndex = 1;
            PM_EditButton.Text = "แก้ไข";
            PM_EditButton.TextAlign = ContentAlignment.MiddleRight;
            PM_EditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            PM_EditButton.UseVisualStyleBackColor = false;
            // 
            // PM_Panel1
            // 
            PM_Panel1.BackColor = SystemColors.InactiveCaption;
            PM_Panel1.Controls.Add(PM_HeadingLabel);
            PM_Panel1.Dock = DockStyle.Top;
            PM_Panel1.Location = new Point(0, 0);
            PM_Panel1.Margin = new Padding(2, 3, 2, 3);
            PM_Panel1.Name = "PM_Panel1";
            PM_Panel1.Size = new Size(1182, 60);
            PM_Panel1.TabIndex = 3;
            // 
            // PM_HeadingLabel
            // 
            PM_HeadingLabel.AutoSize = true;
            PM_HeadingLabel.BackColor = Color.Transparent;
            PM_HeadingLabel.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PM_HeadingLabel.ForeColor = Color.Black;
            PM_HeadingLabel.Location = new Point(8, 8);
            PM_HeadingLabel.Margin = new Padding(0);
            PM_HeadingLabel.Name = "PM_HeadingLabel";
            PM_HeadingLabel.Size = new Size(179, 39);
            PM_HeadingLabel.TabIndex = 0;
            PM_HeadingLabel.Text = "จัดการสินค้า";
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 1261);
            Controls.Add(panel3);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductManagementForm";
            Text = "Product Management";
            Load += ProductManagementForm_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PM_DataGridView).EndInit();
            PM_StatusStrip.ResumeLayout(false);
            PM_StatusStrip.PerformLayout();
            PM_TableLayoutPanel1.ResumeLayout(false);
            PM_TableLayoutPanel2.ResumeLayout(false);
            PM_TableLayoutPanel2.PerformLayout();
            PM_TableLayoutPanel3.ResumeLayout(false);
            PM_Panel1.ResumeLayout(false);
            PM_Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox KeywordTextBox;
        private Button SearchButton;
        private Button RefreshButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button AddItemButton;
        private Button DeleteItemButton;
        private Button EditItemButton;
        private Panel panel3;
        private DataGridView PM_DataGridView;
        private StatusStrip PM_StatusStrip;
        private ToolStripStatusLabel PM_ToolStripStatusLabel;
        private TableLayoutPanel PM_TableLayoutPanel1;
        private TableLayoutPanel PM_TableLayoutPanel2;
        private TextBox PM_SearchTextBox;
        private Button PM_SerachButton;
        private Button PM_RefreshButton;
        private TableLayoutPanel PM_TableLayoutPanel3;
        private Button PM_AddButton;
        private Button PM_DeleteButton;
        private Button PM_EditButton;
        private Panel PM_Panel1;
        private Label PM_HeadingLabel;
    }
}