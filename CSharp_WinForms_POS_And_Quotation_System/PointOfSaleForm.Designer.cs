namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class PointOfSaleForm
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
            panel1 = new Panel();
            POS_Panel2 = new Panel();
            POS_CalculatePriceGroupBox = new GroupBox();
            POS_SaveButton = new Button();
            SaveButton = new Button();
            POS_ChangeMoneyTextBox = new TextBox();
            POS_ChangeMoneyLabel = new Label();
            POS_ReceiveMoneyTextBox = new TextBox();
            POS_ReceiveMoneyLabel = new Label();
            POS_TotalAmountTextBox = new TextBox();
            POS_TotalAmountLabel = new Label();
            POS_ProductDetailGroupBox = new GroupBox();
            POS_TableLayoutPanel3 = new TableLayoutPanel();
            POS_ProductIDLabel = new Label();
            POS_SellingUnitNumericUpDown = new NumericUpDown();
            POS_UnitInStockTextBox = new TextBox();
            POS_SellingPriceTextBox = new TextBox();
            POS_UnitInStockLabel = new Label();
            POS_CostPriceLabel = new Label();
            POS_SellingPriceLabel = new Label();
            POS_CostPriceTextBox = new TextBox();
            POS_ProductNameTextBox = new TextBox();
            POS_ProductNameLabel = new Label();
            POS_ProductIDTextBox = new TextBox();
            POS_SellingUnitLabel = new Label();
            POS_DataGridView = new DataGridView();
            POS_DataGridViewIdColumn = new DataGridViewTextBoxColumn();
            POS_DataGridViewProductNumberColumn = new DataGridViewTextBoxColumn();
            POS_DataGridViewProductNameColumn = new DataGridViewTextBoxColumn();
            POS_DataGridViewSellingPriceColumn = new DataGridViewTextBoxColumn();
            POS_DataGridViewQuantityColumn = new DataGridViewTextBoxColumn();
            POS_DataGridViewSubTotalColumn = new DataGridViewTextBoxColumn();
            POS_TransactionGroupBox = new GroupBox();
            POS_TableLayoutPanel2 = new TableLayoutPanel();
            POS_TransactionHistoryLabel = new Label();
            POS_TransactionHistoryComboBox = new ComboBox();
            POS_DateTimeLabel = new Label();
            POS_DateTimeTextBox = new TextBox();
            POS_TransactionIDLabel = new Label();
            POS_TransactionIDTextBox = new TextBox();
            POS_AddNewSubjectButton = new Button();
            POS_TableLayoutPanel1 = new TableLayoutPanel();
            POS_BarcodeTextBox = new TextBox();
            POS_PictureBox = new PictureBox();
            POS_StatusStrip = new StatusStrip();
            POS_ToolStripStatusLabel = new ToolStripStatusLabel();
            POS_Panel1 = new Panel();
            POS_HeadingLabel = new Label();
            panel1.SuspendLayout();
            POS_Panel2.SuspendLayout();
            POS_CalculatePriceGroupBox.SuspendLayout();
            POS_ProductDetailGroupBox.SuspendLayout();
            POS_TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)POS_SellingUnitNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)POS_DataGridView).BeginInit();
            POS_TransactionGroupBox.SuspendLayout();
            POS_TableLayoutPanel2.SuspendLayout();
            POS_TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)POS_PictureBox).BeginInit();
            POS_StatusStrip.SuspendLayout();
            POS_Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(POS_Panel2);
            panel1.Controls.Add(POS_StatusStrip);
            panel1.Controls.Add(POS_Panel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 1211);
            panel1.TabIndex = 0;
            // 
            // POS_Panel2
            // 
            POS_Panel2.BackColor = Color.FloralWhite;
            POS_Panel2.Controls.Add(POS_CalculatePriceGroupBox);
            POS_Panel2.Controls.Add(POS_ProductDetailGroupBox);
            POS_Panel2.Controls.Add(POS_TransactionGroupBox);
            POS_Panel2.Controls.Add(POS_AddNewSubjectButton);
            POS_Panel2.Controls.Add(POS_TableLayoutPanel1);
            POS_Panel2.Dock = DockStyle.Fill;
            POS_Panel2.Location = new Point(0, 60);
            POS_Panel2.Name = "POS_Panel2";
            POS_Panel2.Size = new Size(1162, 1127);
            POS_Panel2.TabIndex = 5;
            // 
            // POS_CalculatePriceGroupBox
            // 
            POS_CalculatePriceGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            POS_CalculatePriceGroupBox.Controls.Add(POS_SaveButton);
            POS_CalculatePriceGroupBox.Controls.Add(SaveButton);
            POS_CalculatePriceGroupBox.Controls.Add(POS_ChangeMoneyTextBox);
            POS_CalculatePriceGroupBox.Controls.Add(POS_ChangeMoneyLabel);
            POS_CalculatePriceGroupBox.Controls.Add(POS_ReceiveMoneyTextBox);
            POS_CalculatePriceGroupBox.Controls.Add(POS_ReceiveMoneyLabel);
            POS_CalculatePriceGroupBox.Controls.Add(POS_TotalAmountTextBox);
            POS_CalculatePriceGroupBox.Controls.Add(POS_TotalAmountLabel);
            POS_CalculatePriceGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            POS_CalculatePriceGroupBox.ForeColor = Color.LimeGreen;
            POS_CalculatePriceGroupBox.Location = new Point(1007, 45);
            POS_CalculatePriceGroupBox.Name = "POS_CalculatePriceGroupBox";
            POS_CalculatePriceGroupBox.Size = new Size(150, 1079);
            POS_CalculatePriceGroupBox.TabIndex = 20;
            POS_CalculatePriceGroupBox.TabStop = false;
            POS_CalculatePriceGroupBox.Text = "คำนวณราคา";
            // 
            // POS_SaveButton
            // 
            POS_SaveButton.Anchor = AnchorStyles.Bottom;
            POS_SaveButton.BackColor = Color.LightGreen;
            POS_SaveButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_SaveButton.ForeColor = Color.Black;
            POS_SaveButton.Image = Properties.Resources.save_24;
            POS_SaveButton.Location = new Point(6, 1025);
            POS_SaveButton.Name = "POS_SaveButton";
            POS_SaveButton.Size = new Size(138, 48);
            POS_SaveButton.TabIndex = 20;
            POS_SaveButton.Text = "บันทึก";
            POS_SaveButton.TextAlign = ContentAlignment.MiddleRight;
            POS_SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            POS_SaveButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.BackColor = Color.LightGreen;
            SaveButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(-19, 1628);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(138, 55);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "บันทึก";
            SaveButton.TextAlign = ContentAlignment.MiddleRight;
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // POS_ChangeMoneyTextBox
            // 
            POS_ChangeMoneyTextBox.BackColor = Color.MistyRose;
            POS_ChangeMoneyTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            POS_ChangeMoneyTextBox.Location = new Point(6, 228);
            POS_ChangeMoneyTextBox.Name = "POS_ChangeMoneyTextBox";
            POS_ChangeMoneyTextBox.ReadOnly = true;
            POS_ChangeMoneyTextBox.Size = new Size(138, 36);
            POS_ChangeMoneyTextBox.TabIndex = 18;
            // 
            // POS_ChangeMoneyLabel
            // 
            POS_ChangeMoneyLabel.AutoSize = true;
            POS_ChangeMoneyLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_ChangeMoneyLabel.ForeColor = Color.Black;
            POS_ChangeMoneyLabel.Location = new Point(39, 202);
            POS_ChangeMoneyLabel.Name = "POS_ChangeMoneyLabel";
            POS_ChangeMoneyLabel.Size = new Size(74, 23);
            POS_ChangeMoneyLabel.TabIndex = 17;
            POS_ChangeMoneyLabel.Text = "ทอนเงิน";
            // 
            // POS_ReceiveMoneyTextBox
            // 
            POS_ReceiveMoneyTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            POS_ReceiveMoneyTextBox.Location = new Point(6, 141);
            POS_ReceiveMoneyTextBox.Name = "POS_ReceiveMoneyTextBox";
            POS_ReceiveMoneyTextBox.Size = new Size(138, 36);
            POS_ReceiveMoneyTextBox.TabIndex = 16;
            // 
            // POS_ReceiveMoneyLabel
            // 
            POS_ReceiveMoneyLabel.AutoSize = true;
            POS_ReceiveMoneyLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_ReceiveMoneyLabel.ForeColor = Color.Black;
            POS_ReceiveMoneyLabel.Location = new Point(46, 116);
            POS_ReceiveMoneyLabel.Name = "POS_ReceiveMoneyLabel";
            POS_ReceiveMoneyLabel.Size = new Size(57, 23);
            POS_ReceiveMoneyLabel.TabIndex = 15;
            POS_ReceiveMoneyLabel.Text = "รับเงิน";
            // 
            // POS_TotalAmountTextBox
            // 
            POS_TotalAmountTextBox.BackColor = Color.LightCyan;
            POS_TotalAmountTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            POS_TotalAmountTextBox.Location = new Point(6, 55);
            POS_TotalAmountTextBox.Name = "POS_TotalAmountTextBox";
            POS_TotalAmountTextBox.ReadOnly = true;
            POS_TotalAmountTextBox.Size = new Size(138, 36);
            POS_TotalAmountTextBox.TabIndex = 14;
            // 
            // POS_TotalAmountLabel
            // 
            POS_TotalAmountLabel.AutoSize = true;
            POS_TotalAmountLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_TotalAmountLabel.ForeColor = Color.Black;
            POS_TotalAmountLabel.Location = new Point(25, 30);
            POS_TotalAmountLabel.Name = "POS_TotalAmountLabel";
            POS_TotalAmountLabel.Size = new Size(103, 23);
            POS_TotalAmountLabel.TabIndex = 13;
            POS_TotalAmountLabel.Text = "ยอดทั้งหมด";
            // 
            // POS_ProductDetailGroupBox
            // 
            POS_ProductDetailGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            POS_ProductDetailGroupBox.Controls.Add(POS_TableLayoutPanel3);
            POS_ProductDetailGroupBox.Controls.Add(POS_DataGridView);
            POS_ProductDetailGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            POS_ProductDetailGroupBox.ForeColor = Color.DodgerBlue;
            POS_ProductDetailGroupBox.Location = new Point(5, 121);
            POS_ProductDetailGroupBox.Name = "POS_ProductDetailGroupBox";
            POS_ProductDetailGroupBox.Size = new Size(996, 1003);
            POS_ProductDetailGroupBox.TabIndex = 19;
            POS_ProductDetailGroupBox.TabStop = false;
            POS_ProductDetailGroupBox.Text = "รายละเอียดสินค้า:";
            // 
            // POS_TableLayoutPanel3
            // 
            POS_TableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            POS_TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            POS_TableLayoutPanel3.ColumnCount = 6;
            POS_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            POS_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            POS_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            POS_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            POS_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            POS_TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            POS_TableLayoutPanel3.Controls.Add(POS_ProductIDLabel, 0, 0);
            POS_TableLayoutPanel3.Controls.Add(POS_SellingUnitNumericUpDown, 5, 2);
            POS_TableLayoutPanel3.Controls.Add(POS_UnitInStockTextBox, 3, 2);
            POS_TableLayoutPanel3.Controls.Add(POS_SellingPriceTextBox, 5, 0);
            POS_TableLayoutPanel3.Controls.Add(POS_UnitInStockLabel, 2, 2);
            POS_TableLayoutPanel3.Controls.Add(POS_CostPriceLabel, 2, 0);
            POS_TableLayoutPanel3.Controls.Add(POS_SellingPriceLabel, 4, 0);
            POS_TableLayoutPanel3.Controls.Add(POS_CostPriceTextBox, 3, 0);
            POS_TableLayoutPanel3.Controls.Add(POS_ProductNameTextBox, 1, 2);
            POS_TableLayoutPanel3.Controls.Add(POS_ProductNameLabel, 0, 2);
            POS_TableLayoutPanel3.Controls.Add(POS_ProductIDTextBox, 1, 0);
            POS_TableLayoutPanel3.Controls.Add(POS_SellingUnitLabel, 4, 2);
            POS_TableLayoutPanel3.Location = new Point(6, 25);
            POS_TableLayoutPanel3.Name = "POS_TableLayoutPanel3";
            POS_TableLayoutPanel3.RowCount = 4;
            POS_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            POS_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            POS_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            POS_TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            POS_TableLayoutPanel3.Size = new Size(984, 70);
            POS_TableLayoutPanel3.TabIndex = 14;
            // 
            // POS_ProductIDLabel
            // 
            POS_ProductIDLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_ProductIDLabel.AutoSize = true;
            POS_ProductIDLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_ProductIDLabel.ForeColor = Color.Black;
            POS_ProductIDLabel.Location = new Point(1, 5);
            POS_ProductIDLabel.Margin = new Padding(0);
            POS_ProductIDLabel.Name = "POS_ProductIDLabel";
            POS_ProductIDLabel.Size = new Size(100, 18);
            POS_ProductIDLabel.TabIndex = 0;
            POS_ProductIDLabel.Text = "เลขที่สินค้า:";
            POS_ProductIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_SellingUnitNumericUpDown
            // 
            POS_SellingUnitNumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_SellingUnitNumericUpDown.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_SellingUnitNumericUpDown.Location = new Point(878, 35);
            POS_SellingUnitNumericUpDown.Margin = new Padding(0);
            POS_SellingUnitNumericUpDown.Name = "POS_SellingUnitNumericUpDown";
            POS_SellingUnitNumericUpDown.Size = new Size(105, 26);
            POS_SellingUnitNumericUpDown.TabIndex = 6;
            // 
            // POS_UnitInStockTextBox
            // 
            POS_UnitInStockTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_UnitInStockTextBox.Location = new Point(663, 35);
            POS_UnitInStockTextBox.Margin = new Padding(0);
            POS_UnitInStockTextBox.Name = "POS_UnitInStockTextBox";
            POS_UnitInStockTextBox.ReadOnly = true;
            POS_UnitInStockTextBox.Size = new Size(103, 26);
            POS_UnitInStockTextBox.TabIndex = 12;
            // 
            // POS_SellingPriceTextBox
            // 
            POS_SellingPriceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_SellingPriceTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_SellingPriceTextBox.Location = new Point(878, 1);
            POS_SellingPriceTextBox.Margin = new Padding(0);
            POS_SellingPriceTextBox.Name = "POS_SellingPriceTextBox";
            POS_SellingPriceTextBox.ReadOnly = true;
            POS_SellingPriceTextBox.Size = new Size(105, 26);
            POS_SellingPriceTextBox.TabIndex = 10;
            // 
            // POS_UnitInStockLabel
            // 
            POS_UnitInStockLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_UnitInStockLabel.AutoSize = true;
            POS_UnitInStockLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_UnitInStockLabel.ForeColor = Color.Black;
            POS_UnitInStockLabel.Location = new Point(542, 39);
            POS_UnitInStockLabel.Margin = new Padding(0);
            POS_UnitInStockLabel.Name = "POS_UnitInStockLabel";
            POS_UnitInStockLabel.Size = new Size(120, 18);
            POS_UnitInStockLabel.TabIndex = 11;
            POS_UnitInStockLabel.Text = "จำนวนในสต๊อก:";
            POS_UnitInStockLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_CostPriceLabel
            // 
            POS_CostPriceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_CostPriceLabel.AutoSize = true;
            POS_CostPriceLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_CostPriceLabel.ForeColor = Color.Black;
            POS_CostPriceLabel.Location = new Point(542, 5);
            POS_CostPriceLabel.Margin = new Padding(0);
            POS_CostPriceLabel.Name = "POS_CostPriceLabel";
            POS_CostPriceLabel.Size = new Size(120, 18);
            POS_CostPriceLabel.TabIndex = 9;
            POS_CostPriceLabel.Text = "ราคาทุน:";
            POS_CostPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_SellingPriceLabel
            // 
            POS_SellingPriceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_SellingPriceLabel.AutoSize = true;
            POS_SellingPriceLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_SellingPriceLabel.ForeColor = Color.Black;
            POS_SellingPriceLabel.Location = new Point(767, 5);
            POS_SellingPriceLabel.Margin = new Padding(0);
            POS_SellingPriceLabel.Name = "POS_SellingPriceLabel";
            POS_SellingPriceLabel.Size = new Size(110, 18);
            POS_SellingPriceLabel.TabIndex = 9;
            POS_SellingPriceLabel.Text = "ราคาขาย:";
            POS_SellingPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_CostPriceTextBox
            // 
            POS_CostPriceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_CostPriceTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_CostPriceTextBox.Location = new Point(663, 1);
            POS_CostPriceTextBox.Margin = new Padding(0);
            POS_CostPriceTextBox.Name = "POS_CostPriceTextBox";
            POS_CostPriceTextBox.ReadOnly = true;
            POS_CostPriceTextBox.Size = new Size(103, 26);
            POS_CostPriceTextBox.TabIndex = 10;
            // 
            // POS_ProductNameTextBox
            // 
            POS_ProductNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_ProductNameTextBox.Location = new Point(102, 35);
            POS_ProductNameTextBox.Margin = new Padding(0);
            POS_ProductNameTextBox.Name = "POS_ProductNameTextBox";
            POS_ProductNameTextBox.ReadOnly = true;
            POS_ProductNameTextBox.Size = new Size(439, 26);
            POS_ProductNameTextBox.TabIndex = 8;
            // 
            // POS_ProductNameLabel
            // 
            POS_ProductNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_ProductNameLabel.AutoSize = true;
            POS_ProductNameLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_ProductNameLabel.ForeColor = Color.Black;
            POS_ProductNameLabel.Location = new Point(1, 39);
            POS_ProductNameLabel.Margin = new Padding(0);
            POS_ProductNameLabel.Name = "POS_ProductNameLabel";
            POS_ProductNameLabel.Size = new Size(100, 18);
            POS_ProductNameLabel.TabIndex = 7;
            POS_ProductNameLabel.Text = "ชื่อสินค้า:";
            POS_ProductNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_ProductIDTextBox
            // 
            POS_ProductIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_ProductIDTextBox.Location = new Point(102, 1);
            POS_ProductIDTextBox.Margin = new Padding(0);
            POS_ProductIDTextBox.Name = "POS_ProductIDTextBox";
            POS_ProductIDTextBox.ReadOnly = true;
            POS_ProductIDTextBox.Size = new Size(439, 26);
            POS_ProductIDTextBox.TabIndex = 1;
            // 
            // POS_SellingUnitLabel
            // 
            POS_SellingUnitLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_SellingUnitLabel.AutoSize = true;
            POS_SellingUnitLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_SellingUnitLabel.ForeColor = Color.Black;
            POS_SellingUnitLabel.Location = new Point(767, 39);
            POS_SellingUnitLabel.Margin = new Padding(0);
            POS_SellingUnitLabel.Name = "POS_SellingUnitLabel";
            POS_SellingUnitLabel.Size = new Size(110, 18);
            POS_SellingUnitLabel.TabIndex = 13;
            POS_SellingUnitLabel.Text = "จำนวนที่ขาย:";
            POS_SellingUnitLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_DataGridView
            // 
            POS_DataGridView.AllowUserToAddRows = false;
            POS_DataGridView.AllowUserToDeleteRows = false;
            POS_DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            POS_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            POS_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            POS_DataGridView.Columns.AddRange(new DataGridViewColumn[] { POS_DataGridViewIdColumn, POS_DataGridViewProductNumberColumn, POS_DataGridViewProductNameColumn, POS_DataGridViewSellingPriceColumn, POS_DataGridViewQuantityColumn, POS_DataGridViewSubTotalColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            POS_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            POS_DataGridView.Location = new Point(6, 100);
            POS_DataGridView.Name = "POS_DataGridView";
            POS_DataGridView.ReadOnly = true;
            POS_DataGridView.RowHeadersWidth = 51;
            POS_DataGridView.RowTemplate.Height = 25;
            POS_DataGridView.Size = new Size(984, 897);
            POS_DataGridView.TabIndex = 10;
            // 
            // POS_DataGridViewIdColumn
            // 
            POS_DataGridViewIdColumn.HeaderText = "ที่";
            POS_DataGridViewIdColumn.Name = "POS_DataGridViewIdColumn";
            POS_DataGridViewIdColumn.ReadOnly = true;
            POS_DataGridViewIdColumn.Width = 30;
            // 
            // POS_DataGridViewProductNumberColumn
            // 
            POS_DataGridViewProductNumberColumn.HeaderText = "หมายเลขสินค้า";
            POS_DataGridViewProductNumberColumn.Name = "POS_DataGridViewProductNumberColumn";
            POS_DataGridViewProductNumberColumn.ReadOnly = true;
            POS_DataGridViewProductNumberColumn.Width = 200;
            // 
            // POS_DataGridViewProductNameColumn
            // 
            POS_DataGridViewProductNameColumn.HeaderText = "ชื่อสินค้า";
            POS_DataGridViewProductNameColumn.Name = "POS_DataGridViewProductNameColumn";
            POS_DataGridViewProductNameColumn.ReadOnly = true;
            POS_DataGridViewProductNameColumn.Width = 350;
            // 
            // POS_DataGridViewSellingPriceColumn
            // 
            POS_DataGridViewSellingPriceColumn.HeaderText = "ราคาขาย";
            POS_DataGridViewSellingPriceColumn.Name = "POS_DataGridViewSellingPriceColumn";
            POS_DataGridViewSellingPriceColumn.ReadOnly = true;
            // 
            // POS_DataGridViewQuantityColumn
            // 
            POS_DataGridViewQuantityColumn.HeaderText = "จำนวน";
            POS_DataGridViewQuantityColumn.Name = "POS_DataGridViewQuantityColumn";
            POS_DataGridViewQuantityColumn.ReadOnly = true;
            // 
            // POS_DataGridViewSubTotalColumn
            // 
            POS_DataGridViewSubTotalColumn.HeaderText = "ราคารวม";
            POS_DataGridViewSubTotalColumn.Name = "POS_DataGridViewSubTotalColumn";
            POS_DataGridViewSubTotalColumn.ReadOnly = true;
            // 
            // POS_TransactionGroupBox
            // 
            POS_TransactionGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            POS_TransactionGroupBox.BackColor = Color.FloralWhite;
            POS_TransactionGroupBox.Controls.Add(POS_TableLayoutPanel2);
            POS_TransactionGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            POS_TransactionGroupBox.ForeColor = Color.OrangeRed;
            POS_TransactionGroupBox.Location = new Point(5, 45);
            POS_TransactionGroupBox.Name = "POS_TransactionGroupBox";
            POS_TransactionGroupBox.Size = new Size(996, 74);
            POS_TransactionGroupBox.TabIndex = 18;
            POS_TransactionGroupBox.TabStop = false;
            POS_TransactionGroupBox.Text = "ธุรกรรม:";
            // 
            // POS_TableLayoutPanel2
            // 
            POS_TableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            POS_TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            POS_TableLayoutPanel2.ColumnCount = 6;
            POS_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            POS_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            POS_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            POS_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            POS_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            POS_TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            POS_TableLayoutPanel2.Controls.Add(POS_TransactionHistoryLabel, 4, 0);
            POS_TableLayoutPanel2.Controls.Add(POS_TransactionHistoryComboBox, 5, 0);
            POS_TableLayoutPanel2.Controls.Add(POS_DateTimeLabel, 0, 0);
            POS_TableLayoutPanel2.Controls.Add(POS_DateTimeTextBox, 1, 0);
            POS_TableLayoutPanel2.Controls.Add(POS_TransactionIDLabel, 2, 0);
            POS_TableLayoutPanel2.Controls.Add(POS_TransactionIDTextBox, 3, 0);
            POS_TableLayoutPanel2.Location = new Point(7, 23);
            POS_TableLayoutPanel2.Name = "POS_TableLayoutPanel2";
            POS_TableLayoutPanel2.RowCount = 1;
            POS_TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            POS_TableLayoutPanel2.Size = new Size(984, 40);
            POS_TableLayoutPanel2.TabIndex = 0;
            // 
            // POS_TransactionHistoryLabel
            // 
            POS_TransactionHistoryLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_TransactionHistoryLabel.AutoSize = true;
            POS_TransactionHistoryLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_TransactionHistoryLabel.ForeColor = Color.Black;
            POS_TransactionHistoryLabel.Location = new Point(639, 11);
            POS_TransactionHistoryLabel.Margin = new Padding(0);
            POS_TransactionHistoryLabel.Name = "POS_TransactionHistoryLabel";
            POS_TransactionHistoryLabel.Size = new Size(120, 18);
            POS_TransactionHistoryLabel.TabIndex = 8;
            POS_TransactionHistoryLabel.Text = "ดูใบเสร็จล่าสุด:";
            POS_TransactionHistoryLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_TransactionHistoryComboBox
            // 
            POS_TransactionHistoryComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_TransactionHistoryComboBox.BackColor = SystemColors.Control;
            POS_TransactionHistoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            POS_TransactionHistoryComboBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_TransactionHistoryComboBox.FormattingEnabled = true;
            POS_TransactionHistoryComboBox.Location = new Point(760, 7);
            POS_TransactionHistoryComboBox.Margin = new Padding(0);
            POS_TransactionHistoryComboBox.Name = "POS_TransactionHistoryComboBox";
            POS_TransactionHistoryComboBox.Size = new Size(223, 26);
            POS_TransactionHistoryComboBox.TabIndex = 7;
            // 
            // POS_DateTimeLabel
            // 
            POS_DateTimeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_DateTimeLabel.AutoSize = true;
            POS_DateTimeLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_DateTimeLabel.ForeColor = Color.Black;
            POS_DateTimeLabel.Location = new Point(1, 11);
            POS_DateTimeLabel.Margin = new Padding(0);
            POS_DateTimeLabel.Name = "POS_DateTimeLabel";
            POS_DateTimeLabel.Size = new Size(70, 18);
            POS_DateTimeLabel.TabIndex = 1;
            POS_DateTimeLabel.Text = "วันที่เวลา:";
            POS_DateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_DateTimeTextBox
            // 
            POS_DateTimeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_DateTimeTextBox.Location = new Point(72, 7);
            POS_DateTimeTextBox.Margin = new Padding(0);
            POS_DateTimeTextBox.Name = "POS_DateTimeTextBox";
            POS_DateTimeTextBox.ReadOnly = true;
            POS_DateTimeTextBox.Size = new Size(222, 26);
            POS_DateTimeTextBox.TabIndex = 1;
            // 
            // POS_TransactionIDLabel
            // 
            POS_TransactionIDLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_TransactionIDLabel.AutoSize = true;
            POS_TransactionIDLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_TransactionIDLabel.ForeColor = Color.Black;
            POS_TransactionIDLabel.Location = new Point(295, 11);
            POS_TransactionIDLabel.Margin = new Padding(0);
            POS_TransactionIDLabel.Name = "POS_TransactionIDLabel";
            POS_TransactionIDLabel.Size = new Size(120, 18);
            POS_TransactionIDLabel.TabIndex = 5;
            POS_TransactionIDLabel.Text = "เลขที่ใบเสร็จ:";
            POS_TransactionIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // POS_TransactionIDTextBox
            // 
            POS_TransactionIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_TransactionIDTextBox.Location = new Point(416, 7);
            POS_TransactionIDTextBox.Margin = new Padding(0);
            POS_TransactionIDTextBox.Name = "POS_TransactionIDTextBox";
            POS_TransactionIDTextBox.ReadOnly = true;
            POS_TransactionIDTextBox.Size = new Size(222, 26);
            POS_TransactionIDTextBox.TabIndex = 6;
            // 
            // POS_AddNewSubjectButton
            // 
            POS_AddNewSubjectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            POS_AddNewSubjectButton.BackColor = Color.Chartreuse;
            POS_AddNewSubjectButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            POS_AddNewSubjectButton.ForeColor = Color.Black;
            POS_AddNewSubjectButton.Location = new Point(1007, 3);
            POS_AddNewSubjectButton.Margin = new Padding(0);
            POS_AddNewSubjectButton.Name = "POS_AddNewSubjectButton";
            POS_AddNewSubjectButton.Size = new Size(150, 42);
            POS_AddNewSubjectButton.TabIndex = 17;
            POS_AddNewSubjectButton.Text = "รายการใหม่...";
            POS_AddNewSubjectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            POS_AddNewSubjectButton.UseVisualStyleBackColor = false;
            // 
            // POS_TableLayoutPanel1
            // 
            POS_TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            POS_TableLayoutPanel1.ColumnCount = 2;
            POS_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            POS_TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            POS_TableLayoutPanel1.Controls.Add(POS_BarcodeTextBox, 1, 0);
            POS_TableLayoutPanel1.Controls.Add(POS_PictureBox, 0, 0);
            POS_TableLayoutPanel1.Location = new Point(5, 6);
            POS_TableLayoutPanel1.Margin = new Padding(0);
            POS_TableLayoutPanel1.Name = "POS_TableLayoutPanel1";
            POS_TableLayoutPanel1.RowCount = 1;
            POS_TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            POS_TableLayoutPanel1.Size = new Size(996, 36);
            POS_TableLayoutPanel1.TabIndex = 16;
            // 
            // POS_BarcodeTextBox
            // 
            POS_BarcodeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_BarcodeTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            POS_BarcodeTextBox.Location = new Point(52, 0);
            POS_BarcodeTextBox.Margin = new Padding(0);
            POS_BarcodeTextBox.Name = "POS_BarcodeTextBox";
            POS_BarcodeTextBox.RightToLeft = RightToLeft.Yes;
            POS_BarcodeTextBox.Size = new Size(944, 36);
            POS_BarcodeTextBox.TabIndex = 16;
            // 
            // POS_PictureBox
            // 
            POS_PictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            POS_PictureBox.Image = Properties.Resources.barcode_redline48x36;
            POS_PictureBox.Location = new Point(0, 0);
            POS_PictureBox.Margin = new Padding(0);
            POS_PictureBox.Name = "POS_PictureBox";
            POS_PictureBox.Size = new Size(52, 36);
            POS_PictureBox.TabIndex = 17;
            POS_PictureBox.TabStop = false;
            // 
            // POS_StatusStrip
            // 
            POS_StatusStrip.ImageScalingSize = new Size(20, 20);
            POS_StatusStrip.Items.AddRange(new ToolStripItem[] { POS_ToolStripStatusLabel });
            POS_StatusStrip.Location = new Point(0, 1187);
            POS_StatusStrip.Name = "POS_StatusStrip";
            POS_StatusStrip.Size = new Size(1162, 22);
            POS_StatusStrip.TabIndex = 4;
            POS_StatusStrip.Text = "statusStrip1";
            // 
            // POS_ToolStripStatusLabel
            // 
            POS_ToolStripStatusLabel.Name = "POS_ToolStripStatusLabel";
            POS_ToolStripStatusLabel.Size = new Size(39, 17);
            POS_ToolStripStatusLabel.Text = "Status";
            // 
            // POS_Panel1
            // 
            POS_Panel1.BackColor = Color.Wheat;
            POS_Panel1.Controls.Add(POS_HeadingLabel);
            POS_Panel1.Dock = DockStyle.Top;
            POS_Panel1.Location = new Point(0, 0);
            POS_Panel1.Margin = new Padding(2, 3, 2, 3);
            POS_Panel1.Name = "POS_Panel1";
            POS_Panel1.Size = new Size(1162, 60);
            POS_Panel1.TabIndex = 3;
            // 
            // POS_HeadingLabel
            // 
            POS_HeadingLabel.AutoSize = true;
            POS_HeadingLabel.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            POS_HeadingLabel.Location = new Point(8, 8);
            POS_HeadingLabel.Margin = new Padding(0);
            POS_HeadingLabel.Name = "POS_HeadingLabel";
            POS_HeadingLabel.Size = new Size(147, 39);
            POS_HeadingLabel.TabIndex = 0;
            POS_HeadingLabel.Text = "ขายสินค้า";
            // 
            // PointOfSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 1211);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PointOfSaleForm";
            Text = "Point Of Sale";
            Load += PointOfSaleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            POS_Panel2.ResumeLayout(false);
            POS_CalculatePriceGroupBox.ResumeLayout(false);
            POS_CalculatePriceGroupBox.PerformLayout();
            POS_ProductDetailGroupBox.ResumeLayout(false);
            POS_TableLayoutPanel3.ResumeLayout(false);
            POS_TableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)POS_SellingUnitNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)POS_DataGridView).EndInit();
            POS_TransactionGroupBox.ResumeLayout(false);
            POS_TableLayoutPanel2.ResumeLayout(false);
            POS_TableLayoutPanel2.PerformLayout();
            POS_TableLayoutPanel1.ResumeLayout(false);
            POS_TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)POS_PictureBox).EndInit();
            POS_StatusStrip.ResumeLayout(false);
            POS_StatusStrip.PerformLayout();
            POS_Panel1.ResumeLayout(false);
            POS_Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel POS_Panel2;
        private GroupBox POS_ProductDetailGroupBox;
        private TableLayoutPanel POS_TableLayoutPanel3;
        private Label POS_ProductIDLabel;
        private NumericUpDown POS_SellingUnitNumericUpDown;
        private TextBox POS_ProductIDTextBox;
        private Label POS_SellingUnitLabel;
        private Label POS_ProductNameLabel;
        private TextBox POS_UnitInStockTextBox;
        private TextBox POS_ProductNameTextBox;
        private Label POS_SellingPriceLabel;
        private Label POS_UnitInStockLabel;
        private TextBox POS_SellingPriceTextBox;
        private DataGridView POS_DataGridView;
        private GroupBox POS_TransactionGroupBox;
        private TableLayoutPanel POS_TableLayoutPanel2;
        private Label POS_TransactionHistoryLabel;
        private ComboBox POS_TransactionHistoryComboBox;
        private Label POS_DateTimeLabel;
        private TextBox POS_DateTimeTextBox;
        private Label POS_TransactionIDLabel;
        private TextBox POS_TransactionIDTextBox;
        private Button POS_AddNewSubjectButton;
        private TableLayoutPanel POS_TableLayoutPanel1;
        private TextBox POS_BarcodeTextBox;
        private PictureBox POS_PictureBox;
        private StatusStrip POS_StatusStrip;
        private ToolStripStatusLabel POS_ToolStripStatusLabel;
        private Panel POS_Panel1;
        private Label POS_HeadingLabel;
        private GroupBox POS_CalculatePriceGroupBox;
        private Button POS_SaveButton;
        private Button SaveButton;
        private TextBox POS_ChangeMoneyTextBox;
        private Label POS_ChangeMoneyLabel;
        private TextBox POS_ReceiveMoneyTextBox;
        private Label POS_ReceiveMoneyLabel;
        private TextBox POS_TotalAmountTextBox;
        private Label POS_TotalAmountLabel;
        private Label POS_CostPriceLabel;
        private TextBox POS_CostPriceTextBox;
        private DataGridViewTextBoxColumn POS_DataGridViewIdColumn;
        private DataGridViewTextBoxColumn POS_DataGridViewProductNumberColumn;
        private DataGridViewTextBoxColumn POS_DataGridViewProductNameColumn;
        private DataGridViewTextBoxColumn POS_DataGridViewSellingPriceColumn;
        private DataGridViewTextBoxColumn POS_DataGridViewQuantityColumn;
        private DataGridViewTextBoxColumn POS_DataGridViewSubTotalColumn;
    }
}