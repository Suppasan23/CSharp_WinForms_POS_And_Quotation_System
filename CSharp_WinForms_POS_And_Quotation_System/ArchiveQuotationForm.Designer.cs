namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class ArchiveQuotationForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            AQ_Panel2 = new Panel();
            AQ_SplitContainer = new SplitContainer();
            AQ_TableLayoutPanel1 = new TableLayoutPanel();
            AQ_TableLayoutPanel2 = new TableLayoutPanel();
            AQ_TemporaryDataGridView = new DataGridView();
            AQ_TemporaryDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            AQ_TemporaryDataGridViewIdColumn = new DataGridViewTextBoxColumn();
            AQ_TemporaryDataGridViewQuotationNumberColumn = new DataGridViewTextBoxColumn();
            AQ_TemporaryDataGridViewDueDateColumn = new DataGridViewTextBoxColumn();
            AQ_TemporaryDataGridViewCustomerNameColumn = new DataGridViewTextBoxColumn();
            AQ_TemporaryDataGridViewSellingPriceColumn = new DataGridViewTextBoxColumn();
            AQ_TemporaryDataGridViewPDFColumn = new DataGridViewLinkColumn();
            AQ_TableLayoutPanel3 = new TableLayoutPanel();
            AQ_InsideArchiveButton = new Button();
            AQ_DeleteButton = new Button();
            AQ_TemporaryQuotationLabel = new Label();
            AQ_TableLayoutPanel4 = new TableLayoutPanel();
            AQ_PermanentDataGridView = new DataGridView();
            AQ_PermanentDataGridViewIdColumn = new DataGridViewTextBoxColumn();
            AQ_PermanentDataGridViewQuotationNumberColumn = new DataGridViewTextBoxColumn();
            AQ_PermanentDataGridViewDateIssueColumn = new DataGridViewTextBoxColumn();
            AQ_PermanentDataGridViewCustomerNameColumn = new DataGridViewTextBoxColumn();
            AQ_PermanentDataGridViewSellingPriceColumn = new DataGridViewTextBoxColumn();
            AQ_PermanentDataGridViewPDF1Column = new DataGridViewLinkColumn();
            AQ_PermanentDataGridViewPDF2Column = new DataGridViewLinkColumn();
            AQ_PermanentDataGridViewPDF3Column = new DataGridViewLinkColumn();
            AQ_TableLayoutPanel5 = new TableLayoutPanel();
            AQ_PermanentQuotationLabel = new Label();
            AQ_OutsideArchiveButton = new Button();
            AQ_Panel1 = new Panel();
            AQ_HeadingLabel = new Label();
            panel1.SuspendLayout();
            AQ_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AQ_SplitContainer).BeginInit();
            AQ_SplitContainer.Panel1.SuspendLayout();
            AQ_SplitContainer.Panel2.SuspendLayout();
            AQ_SplitContainer.SuspendLayout();
            AQ_TableLayoutPanel1.SuspendLayout();
            AQ_TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AQ_TemporaryDataGridView).BeginInit();
            AQ_TableLayoutPanel3.SuspendLayout();
            AQ_TableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AQ_PermanentDataGridView).BeginInit();
            AQ_TableLayoutPanel5.SuspendLayout();
            AQ_Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AQ_Panel2);
            panel1.Controls.Add(AQ_Panel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 1131);
            panel1.TabIndex = 0;
            // 
            // AQ_Panel2
            // 
            AQ_Panel2.BackColor = Color.FromArgb(251, 240, 240);
            AQ_Panel2.Controls.Add(AQ_SplitContainer);
            AQ_Panel2.Dock = DockStyle.Fill;
            AQ_Panel2.Location = new Point(0, 60);
            AQ_Panel2.Margin = new Padding(3, 2, 3, 2);
            AQ_Panel2.Name = "AQ_Panel2";
            AQ_Panel2.Size = new Size(1162, 1069);
            AQ_Panel2.TabIndex = 2;
            // 
            // AQ_SplitContainer
            // 
            AQ_SplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AQ_SplitContainer.BorderStyle = BorderStyle.FixedSingle;
            AQ_SplitContainer.Location = new Point(5, 5);
            AQ_SplitContainer.Margin = new Padding(0);
            AQ_SplitContainer.Name = "AQ_SplitContainer";
            AQ_SplitContainer.Orientation = Orientation.Horizontal;
            // 
            // AQ_SplitContainer.Panel1
            // 
            AQ_SplitContainer.Panel1.AutoScroll = true;
            AQ_SplitContainer.Panel1.BackColor = Color.LightGray;
            AQ_SplitContainer.Panel1.Controls.Add(AQ_TableLayoutPanel1);
            AQ_SplitContainer.Panel1MinSize = 38;
            // 
            // AQ_SplitContainer.Panel2
            // 
            AQ_SplitContainer.Panel2.BackColor = Color.SkyBlue;
            AQ_SplitContainer.Panel2.Controls.Add(AQ_TableLayoutPanel4);
            AQ_SplitContainer.Panel2MinSize = 38;
            AQ_SplitContainer.Size = new Size(1152, 1059);
            AQ_SplitContainer.SplitterDistance = 185;
            AQ_SplitContainer.SplitterIncrement = 2;
            AQ_SplitContainer.SplitterWidth = 6;
            AQ_SplitContainer.TabIndex = 4;
            AQ_SplitContainer.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // AQ_TableLayoutPanel1
            // 
            AQ_TableLayoutPanel1.BackColor = Color.LightGray;
            AQ_TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            AQ_TableLayoutPanel1.ColumnCount = 1;
            AQ_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel1.Controls.Add(AQ_TableLayoutPanel2, 0, 1);
            AQ_TableLayoutPanel1.Controls.Add(AQ_TemporaryQuotationLabel, 0, 0);
            AQ_TableLayoutPanel1.Dock = DockStyle.Fill;
            AQ_TableLayoutPanel1.Location = new Point(0, 0);
            AQ_TableLayoutPanel1.Name = "AQ_TableLayoutPanel1";
            AQ_TableLayoutPanel1.RowCount = 2;
            AQ_TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            AQ_TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel1.Size = new Size(1150, 183);
            AQ_TableLayoutPanel1.TabIndex = 3;
            // 
            // AQ_TableLayoutPanel2
            // 
            AQ_TableLayoutPanel2.BackColor = Color.WhiteSmoke;
            AQ_TableLayoutPanel2.ColumnCount = 2;
            AQ_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            AQ_TableLayoutPanel2.Controls.Add(AQ_TemporaryDataGridView, 0, 0);
            AQ_TableLayoutPanel2.Controls.Add(AQ_TableLayoutPanel3, 1, 0);
            AQ_TableLayoutPanel2.Dock = DockStyle.Fill;
            AQ_TableLayoutPanel2.Location = new Point(1, 37);
            AQ_TableLayoutPanel2.Margin = new Padding(0);
            AQ_TableLayoutPanel2.Name = "AQ_TableLayoutPanel2";
            AQ_TableLayoutPanel2.RowCount = 1;
            AQ_TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel2.Size = new Size(1148, 145);
            AQ_TableLayoutPanel2.TabIndex = 0;
            // 
            // AQ_TemporaryDataGridView
            // 
            AQ_TemporaryDataGridView.AllowUserToAddRows = false;
            AQ_TemporaryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AQ_TemporaryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AQ_TemporaryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AQ_TemporaryDataGridView.Columns.AddRange(new DataGridViewColumn[] { AQ_TemporaryDataGridViewCheckBoxColumn, AQ_TemporaryDataGridViewIdColumn, AQ_TemporaryDataGridViewQuotationNumberColumn, AQ_TemporaryDataGridViewDueDateColumn, AQ_TemporaryDataGridViewCustomerNameColumn, AQ_TemporaryDataGridViewSellingPriceColumn, AQ_TemporaryDataGridViewPDFColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AQ_TemporaryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            AQ_TemporaryDataGridView.Dock = DockStyle.Fill;
            AQ_TemporaryDataGridView.Location = new Point(0, 0);
            AQ_TemporaryDataGridView.Margin = new Padding(0);
            AQ_TemporaryDataGridView.MultiSelect = false;
            AQ_TemporaryDataGridView.Name = "AQ_TemporaryDataGridView";
            AQ_TemporaryDataGridView.ReadOnly = true;
            AQ_TemporaryDataGridView.RowTemplate.Height = 25;
            AQ_TemporaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AQ_TemporaryDataGridView.Size = new Size(1056, 145);
            AQ_TemporaryDataGridView.TabIndex = 6;
            // 
            // AQ_TemporaryDataGridViewCheckBoxColumn
            // 
            AQ_TemporaryDataGridViewCheckBoxColumn.HeaderText = "เลือก";
            AQ_TemporaryDataGridViewCheckBoxColumn.Name = "AQ_TemporaryDataGridViewCheckBoxColumn";
            AQ_TemporaryDataGridViewCheckBoxColumn.ReadOnly = true;
            AQ_TemporaryDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.True;
            AQ_TemporaryDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            AQ_TemporaryDataGridViewCheckBoxColumn.Width = 50;
            // 
            // AQ_TemporaryDataGridViewIdColumn
            // 
            AQ_TemporaryDataGridViewIdColumn.HeaderText = "ที่";
            AQ_TemporaryDataGridViewIdColumn.Name = "AQ_TemporaryDataGridViewIdColumn";
            AQ_TemporaryDataGridViewIdColumn.ReadOnly = true;
            AQ_TemporaryDataGridViewIdColumn.Width = 30;
            // 
            // AQ_TemporaryDataGridViewQuotationNumberColumn
            // 
            AQ_TemporaryDataGridViewQuotationNumberColumn.HeaderText = "เลขที่ใบเสนอราคา";
            AQ_TemporaryDataGridViewQuotationNumberColumn.Name = "AQ_TemporaryDataGridViewQuotationNumberColumn";
            AQ_TemporaryDataGridViewQuotationNumberColumn.ReadOnly = true;
            AQ_TemporaryDataGridViewQuotationNumberColumn.Width = 300;
            // 
            // AQ_TemporaryDataGridViewDueDateColumn
            // 
            AQ_TemporaryDataGridViewDueDateColumn.HeaderText = "เวลาคงเหลือ";
            AQ_TemporaryDataGridViewDueDateColumn.Name = "AQ_TemporaryDataGridViewDueDateColumn";
            AQ_TemporaryDataGridViewDueDateColumn.ReadOnly = true;
            AQ_TemporaryDataGridViewDueDateColumn.Width = 120;
            // 
            // AQ_TemporaryDataGridViewCustomerNameColumn
            // 
            AQ_TemporaryDataGridViewCustomerNameColumn.HeaderText = "ชื่อลูกค้า";
            AQ_TemporaryDataGridViewCustomerNameColumn.Name = "AQ_TemporaryDataGridViewCustomerNameColumn";
            AQ_TemporaryDataGridViewCustomerNameColumn.ReadOnly = true;
            AQ_TemporaryDataGridViewCustomerNameColumn.Width = 500;
            // 
            // AQ_TemporaryDataGridViewSellingPriceColumn
            // 
            AQ_TemporaryDataGridViewSellingPriceColumn.HeaderText = "ราคาขาย";
            AQ_TemporaryDataGridViewSellingPriceColumn.Name = "AQ_TemporaryDataGridViewSellingPriceColumn";
            AQ_TemporaryDataGridViewSellingPriceColumn.ReadOnly = true;
            // 
            // AQ_TemporaryDataGridViewPDFColumn
            // 
            AQ_TemporaryDataGridViewPDFColumn.HeaderText = "PDF";
            AQ_TemporaryDataGridViewPDFColumn.Name = "AQ_TemporaryDataGridViewPDFColumn";
            AQ_TemporaryDataGridViewPDFColumn.ReadOnly = true;
            AQ_TemporaryDataGridViewPDFColumn.Resizable = DataGridViewTriState.True;
            AQ_TemporaryDataGridViewPDFColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            AQ_TemporaryDataGridViewPDFColumn.Width = 80;
            // 
            // AQ_TableLayoutPanel3
            // 
            AQ_TableLayoutPanel3.BackColor = Color.WhiteSmoke;
            AQ_TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            AQ_TableLayoutPanel3.ColumnCount = 1;
            AQ_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            AQ_TableLayoutPanel3.Controls.Add(AQ_InsideArchiveButton, 0, 0);
            AQ_TableLayoutPanel3.Controls.Add(AQ_DeleteButton, 0, 1);
            AQ_TableLayoutPanel3.Dock = DockStyle.Fill;
            AQ_TableLayoutPanel3.Location = new Point(1056, 0);
            AQ_TableLayoutPanel3.Margin = new Padding(0);
            AQ_TableLayoutPanel3.Name = "AQ_TableLayoutPanel3";
            AQ_TableLayoutPanel3.RowCount = 3;
            AQ_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            AQ_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            AQ_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel3.Size = new Size(92, 145);
            AQ_TableLayoutPanel3.TabIndex = 7;
            // 
            // AQ_InsideArchiveButton
            // 
            AQ_InsideArchiveButton.BackColor = Color.Honeydew;
            AQ_InsideArchiveButton.Dock = DockStyle.Fill;
            AQ_InsideArchiveButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AQ_InsideArchiveButton.Image = Properties.Resources.download_16;
            AQ_InsideArchiveButton.ImageAlign = ContentAlignment.MiddleRight;
            AQ_InsideArchiveButton.Location = new Point(2, 2);
            AQ_InsideArchiveButton.Margin = new Padding(1);
            AQ_InsideArchiveButton.Name = "AQ_InsideArchiveButton";
            AQ_InsideArchiveButton.Size = new Size(88, 58);
            AQ_InsideArchiveButton.TabIndex = 0;
            AQ_InsideArchiveButton.Text = "เก็บถาวร";
            AQ_InsideArchiveButton.TextAlign = ContentAlignment.MiddleRight;
            AQ_InsideArchiveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AQ_InsideArchiveButton.UseVisualStyleBackColor = false;
            // 
            // AQ_DeleteButton
            // 
            AQ_DeleteButton.BackColor = Color.MistyRose;
            AQ_DeleteButton.Dock = DockStyle.Fill;
            AQ_DeleteButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AQ_DeleteButton.Image = Properties.Resources.delete_16;
            AQ_DeleteButton.Location = new Point(2, 63);
            AQ_DeleteButton.Margin = new Padding(1);
            AQ_DeleteButton.Name = "AQ_DeleteButton";
            AQ_DeleteButton.Size = new Size(88, 58);
            AQ_DeleteButton.TabIndex = 6;
            AQ_DeleteButton.Text = "ทิ้ง";
            AQ_DeleteButton.TextAlign = ContentAlignment.MiddleRight;
            AQ_DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AQ_DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AQ_TemporaryQuotationLabel
            // 
            AQ_TemporaryQuotationLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AQ_TemporaryQuotationLabel.AutoSize = true;
            AQ_TemporaryQuotationLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AQ_TemporaryQuotationLabel.Location = new Point(4, 9);
            AQ_TemporaryQuotationLabel.Name = "AQ_TemporaryQuotationLabel";
            AQ_TemporaryQuotationLabel.Size = new Size(1142, 19);
            AQ_TemporaryQuotationLabel.TabIndex = 3;
            AQ_TemporaryQuotationLabel.Text = "ใบเสนอราคารอดำเนินการ";
            AQ_TemporaryQuotationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AQ_TableLayoutPanel4
            // 
            AQ_TableLayoutPanel4.BackColor = Color.SkyBlue;
            AQ_TableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            AQ_TableLayoutPanel4.ColumnCount = 1;
            AQ_TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel4.Controls.Add(AQ_PermanentDataGridView, 0, 1);
            AQ_TableLayoutPanel4.Controls.Add(AQ_TableLayoutPanel5, 0, 0);
            AQ_TableLayoutPanel4.Dock = DockStyle.Fill;
            AQ_TableLayoutPanel4.Location = new Point(0, 0);
            AQ_TableLayoutPanel4.Name = "AQ_TableLayoutPanel4";
            AQ_TableLayoutPanel4.RowCount = 2;
            AQ_TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            AQ_TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel4.Size = new Size(1150, 866);
            AQ_TableLayoutPanel4.TabIndex = 1;
            // 
            // AQ_PermanentDataGridView
            // 
            AQ_PermanentDataGridView.AllowUserToAddRows = false;
            AQ_PermanentDataGridView.AllowUserToDeleteRows = false;
            AQ_PermanentDataGridView.BackgroundColor = Color.SlateGray;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            AQ_PermanentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            AQ_PermanentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AQ_PermanentDataGridView.Columns.AddRange(new DataGridViewColumn[] { AQ_PermanentDataGridViewIdColumn, AQ_PermanentDataGridViewQuotationNumberColumn, AQ_PermanentDataGridViewDateIssueColumn, AQ_PermanentDataGridViewCustomerNameColumn, AQ_PermanentDataGridViewSellingPriceColumn, AQ_PermanentDataGridViewPDF1Column, AQ_PermanentDataGridViewPDF2Column, AQ_PermanentDataGridViewPDF3Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            AQ_PermanentDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            AQ_PermanentDataGridView.Dock = DockStyle.Fill;
            AQ_PermanentDataGridView.Location = new Point(1, 37);
            AQ_PermanentDataGridView.Margin = new Padding(0);
            AQ_PermanentDataGridView.MultiSelect = false;
            AQ_PermanentDataGridView.Name = "AQ_PermanentDataGridView";
            AQ_PermanentDataGridView.ReadOnly = true;
            AQ_PermanentDataGridView.RowTemplate.Height = 25;
            AQ_PermanentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AQ_PermanentDataGridView.Size = new Size(1148, 828);
            AQ_PermanentDataGridView.TabIndex = 0;
            // 
            // AQ_PermanentDataGridViewIdColumn
            // 
            AQ_PermanentDataGridViewIdColumn.HeaderText = "ที่";
            AQ_PermanentDataGridViewIdColumn.Name = "AQ_PermanentDataGridViewIdColumn";
            AQ_PermanentDataGridViewIdColumn.ReadOnly = true;
            AQ_PermanentDataGridViewIdColumn.Width = 30;
            // 
            // AQ_PermanentDataGridViewQuotationNumberColumn
            // 
            AQ_PermanentDataGridViewQuotationNumberColumn.HeaderText = "เลขที่ใบเสนอราคา";
            AQ_PermanentDataGridViewQuotationNumberColumn.Name = "AQ_PermanentDataGridViewQuotationNumberColumn";
            AQ_PermanentDataGridViewQuotationNumberColumn.ReadOnly = true;
            AQ_PermanentDataGridViewQuotationNumberColumn.Width = 300;
            // 
            // AQ_PermanentDataGridViewDateIssueColumn
            // 
            AQ_PermanentDataGridViewDateIssueColumn.HeaderText = "วันที่ออก";
            AQ_PermanentDataGridViewDateIssueColumn.Name = "AQ_PermanentDataGridViewDateIssueColumn";
            AQ_PermanentDataGridViewDateIssueColumn.ReadOnly = true;
            AQ_PermanentDataGridViewDateIssueColumn.Width = 120;
            // 
            // AQ_PermanentDataGridViewCustomerNameColumn
            // 
            AQ_PermanentDataGridViewCustomerNameColumn.HeaderText = "ชื่อลูกค้า";
            AQ_PermanentDataGridViewCustomerNameColumn.Name = "AQ_PermanentDataGridViewCustomerNameColumn";
            AQ_PermanentDataGridViewCustomerNameColumn.ReadOnly = true;
            AQ_PermanentDataGridViewCustomerNameColumn.Width = 500;
            // 
            // AQ_PermanentDataGridViewSellingPriceColumn
            // 
            AQ_PermanentDataGridViewSellingPriceColumn.HeaderText = "ราคาขาย";
            AQ_PermanentDataGridViewSellingPriceColumn.Name = "AQ_PermanentDataGridViewSellingPriceColumn";
            AQ_PermanentDataGridViewSellingPriceColumn.ReadOnly = true;
            // 
            // AQ_PermanentDataGridViewPDF1Column
            // 
            AQ_PermanentDataGridViewPDF1Column.HeaderText = "PDF1";
            AQ_PermanentDataGridViewPDF1Column.Name = "AQ_PermanentDataGridViewPDF1Column";
            AQ_PermanentDataGridViewPDF1Column.ReadOnly = true;
            AQ_PermanentDataGridViewPDF1Column.Resizable = DataGridViewTriState.True;
            AQ_PermanentDataGridViewPDF1Column.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AQ_PermanentDataGridViewPDF2Column
            // 
            AQ_PermanentDataGridViewPDF2Column.HeaderText = "PDF2";
            AQ_PermanentDataGridViewPDF2Column.Name = "AQ_PermanentDataGridViewPDF2Column";
            AQ_PermanentDataGridViewPDF2Column.ReadOnly = true;
            AQ_PermanentDataGridViewPDF2Column.Resizable = DataGridViewTriState.True;
            AQ_PermanentDataGridViewPDF2Column.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AQ_PermanentDataGridViewPDF3Column
            // 
            AQ_PermanentDataGridViewPDF3Column.HeaderText = "PDF3";
            AQ_PermanentDataGridViewPDF3Column.Name = "AQ_PermanentDataGridViewPDF3Column";
            AQ_PermanentDataGridViewPDF3Column.ReadOnly = true;
            AQ_PermanentDataGridViewPDF3Column.Resizable = DataGridViewTriState.True;
            AQ_PermanentDataGridViewPDF3Column.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AQ_TableLayoutPanel5
            // 
            AQ_TableLayoutPanel5.BackColor = Color.SkyBlue;
            AQ_TableLayoutPanel5.ColumnCount = 3;
            AQ_TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            AQ_TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            AQ_TableLayoutPanel5.Controls.Add(AQ_PermanentQuotationLabel, 1, 0);
            AQ_TableLayoutPanel5.Controls.Add(AQ_OutsideArchiveButton, 2, 0);
            AQ_TableLayoutPanel5.Dock = DockStyle.Fill;
            AQ_TableLayoutPanel5.Location = new Point(1, 1);
            AQ_TableLayoutPanel5.Margin = new Padding(0);
            AQ_TableLayoutPanel5.Name = "AQ_TableLayoutPanel5";
            AQ_TableLayoutPanel5.RowCount = 1;
            AQ_TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AQ_TableLayoutPanel5.Size = new Size(1148, 35);
            AQ_TableLayoutPanel5.TabIndex = 0;
            // 
            // AQ_PermanentQuotationLabel
            // 
            AQ_PermanentQuotationLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AQ_PermanentQuotationLabel.AutoSize = true;
            AQ_PermanentQuotationLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AQ_PermanentQuotationLabel.Location = new Point(233, 8);
            AQ_PermanentQuotationLabel.Name = "AQ_PermanentQuotationLabel";
            AQ_PermanentQuotationLabel.Size = new Size(682, 19);
            AQ_PermanentQuotationLabel.TabIndex = 1;
            AQ_PermanentQuotationLabel.Text = "ใบเสนอราคาเก็บถาวร";
            AQ_PermanentQuotationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AQ_OutsideArchiveButton
            // 
            AQ_OutsideArchiveButton.Anchor = AnchorStyles.Right;
            AQ_OutsideArchiveButton.BackColor = Color.Azure;
            AQ_OutsideArchiveButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AQ_OutsideArchiveButton.Image = Properties.Resources.download_blue_16_;
            AQ_OutsideArchiveButton.ImageAlign = ContentAlignment.MiddleRight;
            AQ_OutsideArchiveButton.Location = new Point(935, 1);
            AQ_OutsideArchiveButton.Margin = new Padding(0);
            AQ_OutsideArchiveButton.Name = "AQ_OutsideArchiveButton";
            AQ_OutsideArchiveButton.Padding = new Padding(5, 0, 0, 0);
            AQ_OutsideArchiveButton.Size = new Size(213, 33);
            AQ_OutsideArchiveButton.TabIndex = 5;
            AQ_OutsideArchiveButton.Text = "เก็บใบเสนอราคาจากภายนอก";
            AQ_OutsideArchiveButton.TextAlign = ContentAlignment.MiddleRight;
            AQ_OutsideArchiveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AQ_OutsideArchiveButton.UseVisualStyleBackColor = false;
            // 
            // AQ_Panel1
            // 
            AQ_Panel1.BackColor = Color.FromArgb(219, 138, 138);
            AQ_Panel1.Controls.Add(AQ_HeadingLabel);
            AQ_Panel1.Dock = DockStyle.Top;
            AQ_Panel1.Location = new Point(0, 0);
            AQ_Panel1.Margin = new Padding(3, 2, 3, 2);
            AQ_Panel1.Name = "AQ_Panel1";
            AQ_Panel1.Size = new Size(1162, 60);
            AQ_Panel1.TabIndex = 1;
            // 
            // AQ_HeadingLabel
            // 
            AQ_HeadingLabel.AutoSize = true;
            AQ_HeadingLabel.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AQ_HeadingLabel.Location = new Point(8, 8);
            AQ_HeadingLabel.Margin = new Padding(0);
            AQ_HeadingLabel.Name = "AQ_HeadingLabel";
            AQ_HeadingLabel.Size = new Size(259, 39);
            AQ_HeadingLabel.TabIndex = 0;
            AQ_HeadingLabel.Text = "ที่เก็บใบเสนอราคา";
            // 
            // ArchiveQuotationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 1131);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ArchiveQuotationForm";
            Text = "Archive Quotation";
            Load += ArchiveQuotationForm_Load;
            panel1.ResumeLayout(false);
            AQ_Panel2.ResumeLayout(false);
            AQ_SplitContainer.Panel1.ResumeLayout(false);
            AQ_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AQ_SplitContainer).EndInit();
            AQ_SplitContainer.ResumeLayout(false);
            AQ_TableLayoutPanel1.ResumeLayout(false);
            AQ_TableLayoutPanel1.PerformLayout();
            AQ_TableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AQ_TemporaryDataGridView).EndInit();
            AQ_TableLayoutPanel3.ResumeLayout(false);
            AQ_TableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AQ_PermanentDataGridView).EndInit();
            AQ_TableLayoutPanel5.ResumeLayout(false);
            AQ_TableLayoutPanel5.PerformLayout();
            AQ_Panel1.ResumeLayout(false);
            AQ_Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel AQ_Panel2;
        private Panel AQ_Panel1;
        private Label AQ_HeadingLabel;
        private TableLayoutPanel AQ_TableLayoutPanel4;
        private DataGridView AQ_PermanentDataGridView;
        private TableLayoutPanel AQ_TableLayoutPanel1;
        private Button AQ_InsideArchiveButton;
        private Label AQ_TemporaryQuotationLabel;
        private Label AQ_PermanentQuotationLabel;
        private SplitContainer AQ_SplitContainer;
        private Button AQ_DeleteButton;
        private DataGridView AQ_TemporaryDataGridView;
        private Button AQ_OutsideArchiveButton;
        private TableLayoutPanel AQ_TableLayoutPanel5;
        private TableLayoutPanel AQ_TableLayoutPanel3;
        private TableLayoutPanel AQ_TableLayoutPanel2;
        private DataGridViewTextBoxColumn AQ_PermanentDataGridViewIdColumn;
        private DataGridViewTextBoxColumn AQ_PermanentDataGridViewQuotationNumberColumn;
        private DataGridViewTextBoxColumn AQ_PermanentDataGridViewDateIssueColumn;
        private DataGridViewTextBoxColumn AQ_PermanentDataGridViewCustomerNameColumn;
        private DataGridViewTextBoxColumn AQ_PermanentDataGridViewSellingPriceColumn;
        private DataGridViewLinkColumn AQ_PermanentDataGridViewPDF1Column;
        private DataGridViewLinkColumn AQ_PermanentDataGridViewPDF2Column;
        private DataGridViewLinkColumn AQ_PermanentDataGridViewPDF3Column;
        private DataGridViewCheckBoxColumn AQ_TemporaryDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn AQ_TemporaryDataGridViewIdColumn;
        private DataGridViewTextBoxColumn AQ_TemporaryDataGridViewQuotationNumberColumn;
        private DataGridViewTextBoxColumn AQ_TemporaryDataGridViewDueDateColumn;
        private DataGridViewTextBoxColumn AQ_TemporaryDataGridViewCustomerNameColumn;
        private DataGridViewTextBoxColumn AQ_TemporaryDataGridViewSellingPriceColumn;
        private DataGridViewLinkColumn AQ_TemporaryDataGridViewPDFColumn;
    }
}