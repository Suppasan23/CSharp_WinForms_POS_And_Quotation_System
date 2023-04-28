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
            panel1 = new Panel();
            panel2 = new Panel();
            CalculatePriceGroupBox = new GroupBox();
            button1 = new Button();
            SaveButton = new Button();
            ChangeMoneyTextBox = new TextBox();
            ChangeMoneyLabel = new Label();
            ReceiveMoneyTextBox = new TextBox();
            ReceiveMoneyLabel = new Label();
            TotalAmountTextBox = new TextBox();
            TotalAmountLabel = new Label();
            ProductDetailGroupBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            ProductIDLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            ProductNumberTextBox = new TextBox();
            SellingUnitLabel = new Label();
            ProductNameLabel = new Label();
            UnitInStockTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            SellingPriceLabel = new Label();
            UnitInStockLabel = new Label();
            SellingPriceTextBox = new TextBox();
            BarcodeTextBox2 = new TextBox();
            BarcodeLabel2 = new Label();
            dataGridView1 = new DataGridView();
            TransactionGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            CurrentDateTextBox = new TextBox();
            TransactionIDLabel = new Label();
            TransactionIDTextBox = new TextBox();
            AddNewSubjectButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            BarcodeTextBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            CalculatePriceGroupBox.SuspendLayout();
            ProductDetailGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TransactionGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 1261);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(CalculatePriceGroupBox);
            panel2.Controls.Add(ProductDetailGroupBox);
            panel2.Controls.Add(TransactionGroupBox);
            panel2.Controls.Add(AddNewSubjectButton);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 1177);
            panel2.TabIndex = 5;
            // 
            // CalculatePriceGroupBox
            // 
            CalculatePriceGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CalculatePriceGroupBox.Controls.Add(button1);
            CalculatePriceGroupBox.Controls.Add(SaveButton);
            CalculatePriceGroupBox.Controls.Add(ChangeMoneyTextBox);
            CalculatePriceGroupBox.Controls.Add(ChangeMoneyLabel);
            CalculatePriceGroupBox.Controls.Add(ReceiveMoneyTextBox);
            CalculatePriceGroupBox.Controls.Add(ReceiveMoneyLabel);
            CalculatePriceGroupBox.Controls.Add(TotalAmountTextBox);
            CalculatePriceGroupBox.Controls.Add(TotalAmountLabel);
            CalculatePriceGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CalculatePriceGroupBox.ForeColor = Color.LimeGreen;
            CalculatePriceGroupBox.Location = new Point(1027, 45);
            CalculatePriceGroupBox.Name = "CalculatePriceGroupBox";
            CalculatePriceGroupBox.Size = new Size(150, 1129);
            CalculatePriceGroupBox.TabIndex = 20;
            CalculatePriceGroupBox.TabStop = false;
            CalculatePriceGroupBox.Text = "คำนวณราคา";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.save_24;
            button1.Location = new Point(6, 1068);
            button1.Name = "button1";
            button1.Size = new Size(138, 55);
            button1.TabIndex = 20;
            button1.Text = "บันทึก";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.BackColor = Color.LightGreen;
            SaveButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(-19, 1678);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(138, 55);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "บันทึก";
            SaveButton.TextAlign = ContentAlignment.MiddleRight;
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // ChangeMoneyTextBox
            // 
            ChangeMoneyTextBox.BackColor = Color.MistyRose;
            ChangeMoneyTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeMoneyTextBox.Location = new Point(6, 228);
            ChangeMoneyTextBox.Name = "ChangeMoneyTextBox";
            ChangeMoneyTextBox.ReadOnly = true;
            ChangeMoneyTextBox.Size = new Size(138, 36);
            ChangeMoneyTextBox.TabIndex = 18;
            // 
            // ChangeMoneyLabel
            // 
            ChangeMoneyLabel.AutoSize = true;
            ChangeMoneyLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeMoneyLabel.ForeColor = Color.Black;
            ChangeMoneyLabel.Location = new Point(39, 202);
            ChangeMoneyLabel.Name = "ChangeMoneyLabel";
            ChangeMoneyLabel.Size = new Size(74, 23);
            ChangeMoneyLabel.TabIndex = 17;
            ChangeMoneyLabel.Text = "ทอนเงิน";
            // 
            // ReceiveMoneyTextBox
            // 
            ReceiveMoneyTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiveMoneyTextBox.Location = new Point(6, 141);
            ReceiveMoneyTextBox.Name = "ReceiveMoneyTextBox";
            ReceiveMoneyTextBox.Size = new Size(138, 36);
            ReceiveMoneyTextBox.TabIndex = 16;
            // 
            // ReceiveMoneyLabel
            // 
            ReceiveMoneyLabel.AutoSize = true;
            ReceiveMoneyLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiveMoneyLabel.ForeColor = Color.Black;
            ReceiveMoneyLabel.Location = new Point(46, 116);
            ReceiveMoneyLabel.Name = "ReceiveMoneyLabel";
            ReceiveMoneyLabel.Size = new Size(57, 23);
            ReceiveMoneyLabel.TabIndex = 15;
            ReceiveMoneyLabel.Text = "รับเงิน";
            // 
            // TotalAmountTextBox
            // 
            TotalAmountTextBox.BackColor = Color.Honeydew;
            TotalAmountTextBox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmountTextBox.Location = new Point(6, 55);
            TotalAmountTextBox.Name = "TotalAmountTextBox";
            TotalAmountTextBox.ReadOnly = true;
            TotalAmountTextBox.Size = new Size(138, 36);
            TotalAmountTextBox.TabIndex = 14;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmountLabel.ForeColor = Color.Black;
            TotalAmountLabel.Location = new Point(25, 30);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(103, 23);
            TotalAmountLabel.TabIndex = 13;
            TotalAmountLabel.Text = "ยอดทั้งหมด";
            // 
            // ProductDetailGroupBox
            // 
            ProductDetailGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductDetailGroupBox.Controls.Add(tableLayoutPanel3);
            ProductDetailGroupBox.Controls.Add(dataGridView1);
            ProductDetailGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ProductDetailGroupBox.ForeColor = Color.DodgerBlue;
            ProductDetailGroupBox.Location = new Point(5, 121);
            ProductDetailGroupBox.Name = "ProductDetailGroupBox";
            ProductDetailGroupBox.Size = new Size(1016, 1053);
            ProductDetailGroupBox.TabIndex = 19;
            ProductDetailGroupBox.TabStop = false;
            ProductDetailGroupBox.Text = "รายละเอียดสินค้า:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(ProductIDLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown1, 5, 2);
            tableLayoutPanel3.Controls.Add(ProductNumberTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(SellingUnitLabel, 4, 2);
            tableLayoutPanel3.Controls.Add(ProductNameLabel, 2, 0);
            tableLayoutPanel3.Controls.Add(UnitInStockTextBox, 3, 2);
            tableLayoutPanel3.Controls.Add(ProductNameTextBox, 3, 0);
            tableLayoutPanel3.Controls.Add(SellingPriceLabel, 4, 0);
            tableLayoutPanel3.Controls.Add(UnitInStockLabel, 2, 2);
            tableLayoutPanel3.Controls.Add(SellingPriceTextBox, 5, 0);
            tableLayoutPanel3.Controls.Add(BarcodeTextBox2, 1, 2);
            tableLayoutPanel3.Controls.Add(BarcodeLabel2, 0, 2);
            tableLayoutPanel3.Location = new Point(6, 29);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1004, 70);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // ProductIDLabel
            // 
            ProductIDLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductIDLabel.AutoSize = true;
            ProductIDLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductIDLabel.ForeColor = Color.Black;
            ProductIDLabel.Location = new Point(0, 4);
            ProductIDLabel.Margin = new Padding(0);
            ProductIDLabel.Name = "ProductIDLabel";
            ProductIDLabel.Size = new Size(90, 18);
            ProductIDLabel.TabIndex = 0;
            ProductIDLabel.Text = "เลขที่สินค้า:";
            ProductIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(872, 34);
            numericUpDown1.Margin = new Padding(0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(132, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // ProductNumberTextBox
            // 
            ProductNumberTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductNumberTextBox.Location = new Point(90, 0);
            ProductNumberTextBox.Margin = new Padding(0);
            ProductNumberTextBox.Name = "ProductNumberTextBox";
            ProductNumberTextBox.ReadOnly = true;
            ProductNumberTextBox.Size = new Size(261, 26);
            ProductNumberTextBox.TabIndex = 1;
            // 
            // SellingUnitLabel
            // 
            SellingUnitLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SellingUnitLabel.AutoSize = true;
            SellingUnitLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SellingUnitLabel.ForeColor = Color.Black;
            SellingUnitLabel.Location = new Point(742, 38);
            SellingUnitLabel.Margin = new Padding(0);
            SellingUnitLabel.Name = "SellingUnitLabel";
            SellingUnitLabel.Size = new Size(130, 18);
            SellingUnitLabel.TabIndex = 13;
            SellingUnitLabel.Text = "จำนวนที่ขาย:";
            SellingUnitLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameLabel.ForeColor = Color.Black;
            ProductNameLabel.Location = new Point(351, 4);
            ProductNameLabel.Margin = new Padding(0);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(130, 18);
            ProductNameLabel.TabIndex = 7;
            ProductNameLabel.Text = "ชื่อสินค้า:";
            ProductNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UnitInStockTextBox
            // 
            UnitInStockTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UnitInStockTextBox.Location = new Point(481, 34);
            UnitInStockTextBox.Margin = new Padding(0);
            UnitInStockTextBox.Name = "UnitInStockTextBox";
            UnitInStockTextBox.ReadOnly = true;
            UnitInStockTextBox.Size = new Size(261, 26);
            UnitInStockTextBox.TabIndex = 12;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ProductNameTextBox.Location = new Point(481, 0);
            ProductNameTextBox.Margin = new Padding(0);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.ReadOnly = true;
            ProductNameTextBox.Size = new Size(261, 26);
            ProductNameTextBox.TabIndex = 8;
            // 
            // SellingPriceLabel
            // 
            SellingPriceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SellingPriceLabel.AutoSize = true;
            SellingPriceLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SellingPriceLabel.ForeColor = Color.Black;
            SellingPriceLabel.Location = new Point(742, 4);
            SellingPriceLabel.Margin = new Padding(0);
            SellingPriceLabel.Name = "SellingPriceLabel";
            SellingPriceLabel.Size = new Size(130, 18);
            SellingPriceLabel.TabIndex = 9;
            SellingPriceLabel.Text = "ราคาขาย:";
            SellingPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UnitInStockLabel
            // 
            UnitInStockLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UnitInStockLabel.AutoSize = true;
            UnitInStockLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UnitInStockLabel.ForeColor = Color.Black;
            UnitInStockLabel.Location = new Point(351, 38);
            UnitInStockLabel.Margin = new Padding(0);
            UnitInStockLabel.Name = "UnitInStockLabel";
            UnitInStockLabel.Size = new Size(130, 18);
            UnitInStockLabel.TabIndex = 11;
            UnitInStockLabel.Text = "จำนวนในสต๊อก:";
            UnitInStockLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SellingPriceTextBox
            // 
            SellingPriceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SellingPriceTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SellingPriceTextBox.Location = new Point(872, 0);
            SellingPriceTextBox.Margin = new Padding(0);
            SellingPriceTextBox.Name = "SellingPriceTextBox";
            SellingPriceTextBox.ReadOnly = true;
            SellingPriceTextBox.Size = new Size(132, 26);
            SellingPriceTextBox.TabIndex = 10;
            // 
            // BarcodeTextBox2
            // 
            BarcodeTextBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BarcodeTextBox2.Location = new Point(90, 34);
            BarcodeTextBox2.Margin = new Padding(0);
            BarcodeTextBox2.Name = "BarcodeTextBox2";
            BarcodeTextBox2.ReadOnly = true;
            BarcodeTextBox2.Size = new Size(261, 26);
            BarcodeTextBox2.TabIndex = 6;
            // 
            // BarcodeLabel2
            // 
            BarcodeLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BarcodeLabel2.AutoSize = true;
            BarcodeLabel2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BarcodeLabel2.ForeColor = Color.Black;
            BarcodeLabel2.Location = new Point(0, 38);
            BarcodeLabel2.Margin = new Padding(0);
            BarcodeLabel2.Name = "BarcodeLabel2";
            BarcodeLabel2.Size = new Size(90, 18);
            BarcodeLabel2.TabIndex = 5;
            BarcodeLabel2.Text = "บาร์โค้ด:";
            BarcodeLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1004, 947);
            dataGridView1.TabIndex = 10;
            // 
            // TransactionGroupBox
            // 
            TransactionGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TransactionGroupBox.BackColor = Color.FloralWhite;
            TransactionGroupBox.Controls.Add(tableLayoutPanel1);
            TransactionGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TransactionGroupBox.ForeColor = Color.OrangeRed;
            TransactionGroupBox.Location = new Point(5, 45);
            TransactionGroupBox.Name = "TransactionGroupBox";
            TransactionGroupBox.Size = new Size(1016, 74);
            TransactionGroupBox.TabIndex = 18;
            TransactionGroupBox.TabStop = false;
            TransactionGroupBox.Text = "ธุรกรรม:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label2, 4, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 5, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(CurrentDateTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(TransactionIDLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(TransactionIDTextBox, 3, 0);
            tableLayoutPanel1.Location = new Point(6, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1004, 26);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(652, 4);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 8;
            label2.Text = "ดูใบเสร็จล่าสุด:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(772, 1);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 26);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 4);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 1;
            label3.Text = "วันที่เวลา:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CurrentDateTextBox
            // 
            CurrentDateTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CurrentDateTextBox.Location = new Point(70, 0);
            CurrentDateTextBox.Margin = new Padding(0);
            CurrentDateTextBox.Name = "CurrentDateTextBox";
            CurrentDateTextBox.ReadOnly = true;
            CurrentDateTextBox.Size = new Size(231, 26);
            CurrentDateTextBox.TabIndex = 1;
            // 
            // TransactionIDLabel
            // 
            TransactionIDLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TransactionIDLabel.AutoSize = true;
            TransactionIDLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TransactionIDLabel.ForeColor = Color.Black;
            TransactionIDLabel.Location = new Point(301, 4);
            TransactionIDLabel.Margin = new Padding(0);
            TransactionIDLabel.Name = "TransactionIDLabel";
            TransactionIDLabel.Size = new Size(120, 18);
            TransactionIDLabel.TabIndex = 5;
            TransactionIDLabel.Text = "เลขที่ใบเสร็จ:";
            TransactionIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionIDTextBox
            // 
            TransactionIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TransactionIDTextBox.Location = new Point(421, 0);
            TransactionIDTextBox.Margin = new Padding(0);
            TransactionIDTextBox.Name = "TransactionIDTextBox";
            TransactionIDTextBox.ReadOnly = true;
            TransactionIDTextBox.Size = new Size(231, 26);
            TransactionIDTextBox.TabIndex = 6;
            // 
            // AddNewSubjectButton
            // 
            AddNewSubjectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddNewSubjectButton.BackColor = Color.LightCyan;
            AddNewSubjectButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewSubjectButton.Location = new Point(1027, 3);
            AddNewSubjectButton.Margin = new Padding(0);
            AddNewSubjectButton.Name = "AddNewSubjectButton";
            AddNewSubjectButton.Size = new Size(150, 42);
            AddNewSubjectButton.TabIndex = 17;
            AddNewSubjectButton.Text = "รายการใหม่...";
            AddNewSubjectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddNewSubjectButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(BarcodeTextBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Location = new Point(5, 6);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1016, 36);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // BarcodeTextBox1
            // 
            BarcodeTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BarcodeTextBox1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BarcodeTextBox1.Location = new Point(52, 0);
            BarcodeTextBox1.Margin = new Padding(0);
            BarcodeTextBox1.Name = "BarcodeTextBox1";
            BarcodeTextBox1.RightToLeft = RightToLeft.Yes;
            BarcodeTextBox1.Size = new Size(964, 36);
            BarcodeTextBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.barcode_redline48x36;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 36);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 1237);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1182, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 60);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 8);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(147, 39);
            label1.TabIndex = 0;
            label1.Text = "ขายสินค้า";
            // 
            // PointOfSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 1261);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PointOfSaleForm";
            Text = "Point Of Sale";
            Load += PointOfSaleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            CalculatePriceGroupBox.ResumeLayout(false);
            CalculatePriceGroupBox.PerformLayout();
            ProductDetailGroupBox.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TransactionGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox ProductDetailGroupBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label ProductIDLabel;
        private NumericUpDown numericUpDown1;
        private TextBox ProductNumberTextBox;
        private Label SellingUnitLabel;
        private Label ProductNameLabel;
        private TextBox UnitInStockTextBox;
        private TextBox ProductNameTextBox;
        private Label SellingPriceLabel;
        private Label UnitInStockLabel;
        private TextBox SellingPriceTextBox;
        private TextBox BarcodeTextBox2;
        private Label BarcodeLabel2;
        private DataGridView dataGridView1;
        private GroupBox TransactionGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox CurrentDateTextBox;
        private Label TransactionIDLabel;
        private TextBox TransactionIDTextBox;
        private Button AddNewSubjectButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox BarcodeTextBox1;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel3;
        private Label label1;
        private GroupBox CalculatePriceGroupBox;
        private Button button1;
        private Button SaveButton;
        private TextBox ChangeMoneyTextBox;
        private Label ChangeMoneyLabel;
        private TextBox ReceiveMoneyTextBox;
        private Label ReceiveMoneyLabel;
        private TextBox TotalAmountTextBox;
        private Label TotalAmountLabel;
    }
}