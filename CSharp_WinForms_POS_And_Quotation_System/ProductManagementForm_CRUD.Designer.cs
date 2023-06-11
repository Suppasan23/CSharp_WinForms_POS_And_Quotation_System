namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class ProductManagementForm_CRUD
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
            PM_CRUD_Panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            PM_CRUD_HeadingLabel = new Label();
            PM_CRUD_ProductIdLabel = new Label();
            PM_CRUD_ProductBarcodeLabel = new Label();
            PM_CRUD_ProductNameLabel = new Label();
            PM_CRUD_ProductCostPriceLabel = new Label();
            PM_CRUD_ProductTextBox = new TextBox();
            PM_CRUD_ProductBarcodeTextBox = new TextBox();
            PM_CRUD_ProductNameTextBox = new TextBox();
            PM_CRUD_ProductCostPriceTextBox = new TextBox();
            PM_CRUD_ProductSellingPriceLabel = new Label();
            PM_CRUD_ProductUnitNameLabel = new Label();
            PM_CRUD_ProductCategoryLabel = new Label();
            PM_CRUD_ProductQuantityLabel = new Label();
            PM_CRUD_ProductSellingPriceTextBox = new TextBox();
            PM_CRUD_ProductUnitNameTextBox = new TextBox();
            PM_CRUD_ProductCategoryTextBox = new TextBox();
            PM_CRUD_ProductQuantityTextBox = new TextBox();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PM_CRUD_PictureBox1 = new PictureBox();
            PM_CRUD_GroupBox1 = new GroupBox();
            PM_CRUD_Panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PM_CRUD_PictureBox1).BeginInit();
            PM_CRUD_GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PM_CRUD_Panel1
            // 
            PM_CRUD_Panel1.BorderStyle = BorderStyle.FixedSingle;
            PM_CRUD_Panel1.Controls.Add(tableLayoutPanel1);
            PM_CRUD_Panel1.Dock = DockStyle.Fill;
            PM_CRUD_Panel1.Location = new Point(0, 0);
            PM_CRUD_Panel1.Name = "PM_CRUD_Panel1";
            PM_CRUD_Panel1.Size = new Size(808, 759);
            PM_CRUD_Panel1.TabIndex = 0;
            PM_CRUD_Panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PM_CRUD_HeadingLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Location = new Point(395, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(385, 722);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PM_CRUD_HeadingLabel
            // 
            PM_CRUD_HeadingLabel.AutoSize = true;
            PM_CRUD_HeadingLabel.BackColor = SystemColors.InactiveCaption;
            PM_CRUD_HeadingLabel.Dock = DockStyle.Fill;
            PM_CRUD_HeadingLabel.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PM_CRUD_HeadingLabel.Location = new Point(1, 1);
            PM_CRUD_HeadingLabel.Margin = new Padding(0);
            PM_CRUD_HeadingLabel.Name = "PM_CRUD_HeadingLabel";
            PM_CRUD_HeadingLabel.Size = new Size(383, 40);
            PM_CRUD_HeadingLabel.TabIndex = 1;
            PM_CRUD_HeadingLabel.Text = "...สินค้า";
            PM_CRUD_HeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PM_CRUD_ProductIdLabel
            // 
            PM_CRUD_ProductIdLabel.AutoSize = true;
            PM_CRUD_ProductIdLabel.Location = new Point(70, 53);
            PM_CRUD_ProductIdLabel.Name = "PM_CRUD_ProductIdLabel";
            PM_CRUD_ProductIdLabel.Size = new Size(18, 15);
            PM_CRUD_ProductIdLabel.TabIndex = 1;
            PM_CRUD_ProductIdLabel.Text = "ID";
            // 
            // PM_CRUD_ProductBarcodeLabel
            // 
            PM_CRUD_ProductBarcodeLabel.AutoSize = true;
            PM_CRUD_ProductBarcodeLabel.Location = new Point(49, 82);
            PM_CRUD_ProductBarcodeLabel.Name = "PM_CRUD_ProductBarcodeLabel";
            PM_CRUD_ProductBarcodeLabel.Size = new Size(73, 15);
            PM_CRUD_ProductBarcodeLabel.TabIndex = 1;
            PM_CRUD_ProductBarcodeLabel.Text = "หมายเลขสินค้า";
            // 
            // PM_CRUD_ProductNameLabel
            // 
            PM_CRUD_ProductNameLabel.AutoSize = true;
            PM_CRUD_ProductNameLabel.Location = new Point(70, 111);
            PM_CRUD_ProductNameLabel.Name = "PM_CRUD_ProductNameLabel";
            PM_CRUD_ProductNameLabel.Size = new Size(45, 15);
            PM_CRUD_ProductNameLabel.TabIndex = 1;
            PM_CRUD_ProductNameLabel.Text = "ชื่อสินค้า";
            // 
            // PM_CRUD_ProductCostPriceLabel
            // 
            PM_CRUD_ProductCostPriceLabel.AutoSize = true;
            PM_CRUD_ProductCostPriceLabel.Location = new Point(70, 169);
            PM_CRUD_ProductCostPriceLabel.Name = "PM_CRUD_ProductCostPriceLabel";
            PM_CRUD_ProductCostPriceLabel.Size = new Size(43, 15);
            PM_CRUD_ProductCostPriceLabel.TabIndex = 1;
            PM_CRUD_ProductCostPriceLabel.Text = "ราคาทุน";
            // 
            // PM_CRUD_ProductTextBox
            // 
            PM_CRUD_ProductTextBox.Location = new Point(178, 45);
            PM_CRUD_ProductTextBox.Name = "PM_CRUD_ProductTextBox";
            PM_CRUD_ProductTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductBarcodeTextBox
            // 
            PM_CRUD_ProductBarcodeTextBox.Location = new Point(178, 74);
            PM_CRUD_ProductBarcodeTextBox.Name = "PM_CRUD_ProductBarcodeTextBox";
            PM_CRUD_ProductBarcodeTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductBarcodeTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductNameTextBox
            // 
            PM_CRUD_ProductNameTextBox.Location = new Point(178, 103);
            PM_CRUD_ProductNameTextBox.Name = "PM_CRUD_ProductNameTextBox";
            PM_CRUD_ProductNameTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductNameTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductCostPriceTextBox
            // 
            PM_CRUD_ProductCostPriceTextBox.Location = new Point(178, 161);
            PM_CRUD_ProductCostPriceTextBox.Name = "PM_CRUD_ProductCostPriceTextBox";
            PM_CRUD_ProductCostPriceTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductCostPriceTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductSellingPriceLabel
            // 
            PM_CRUD_ProductSellingPriceLabel.AutoSize = true;
            PM_CRUD_ProductSellingPriceLabel.Location = new Point(70, 202);
            PM_CRUD_ProductSellingPriceLabel.Name = "PM_CRUD_ProductSellingPriceLabel";
            PM_CRUD_ProductSellingPriceLabel.Size = new Size(47, 15);
            PM_CRUD_ProductSellingPriceLabel.TabIndex = 1;
            PM_CRUD_ProductSellingPriceLabel.Text = "ราคาขาย";
            // 
            // PM_CRUD_ProductUnitNameLabel
            // 
            PM_CRUD_ProductUnitNameLabel.AutoSize = true;
            PM_CRUD_ProductUnitNameLabel.Location = new Point(70, 231);
            PM_CRUD_ProductUnitNameLabel.Name = "PM_CRUD_ProductUnitNameLabel";
            PM_CRUD_ProductUnitNameLabel.Size = new Size(46, 15);
            PM_CRUD_ProductUnitNameLabel.TabIndex = 1;
            PM_CRUD_ProductUnitNameLabel.Text = "หน่วยนับ";
            // 
            // PM_CRUD_ProductCategoryLabel
            // 
            PM_CRUD_ProductCategoryLabel.AutoSize = true;
            PM_CRUD_ProductCategoryLabel.Location = new Point(70, 260);
            PM_CRUD_ProductCategoryLabel.Name = "PM_CRUD_ProductCategoryLabel";
            PM_CRUD_ProductCategoryLabel.Size = new Size(65, 15);
            PM_CRUD_ProductCategoryLabel.TabIndex = 1;
            PM_CRUD_ProductCategoryLabel.Text = "ประเภทสินค้า";
            // 
            // PM_CRUD_ProductQuantityLabel
            // 
            PM_CRUD_ProductQuantityLabel.AutoSize = true;
            PM_CRUD_ProductQuantityLabel.Location = new Point(70, 140);
            PM_CRUD_ProductQuantityLabel.Name = "PM_CRUD_ProductQuantityLabel";
            PM_CRUD_ProductQuantityLabel.Size = new Size(37, 15);
            PM_CRUD_ProductQuantityLabel.TabIndex = 1;
            PM_CRUD_ProductQuantityLabel.Text = "จำนวน";
            // 
            // PM_CRUD_ProductSellingPriceTextBox
            // 
            PM_CRUD_ProductSellingPriceTextBox.Location = new Point(178, 194);
            PM_CRUD_ProductSellingPriceTextBox.Name = "PM_CRUD_ProductSellingPriceTextBox";
            PM_CRUD_ProductSellingPriceTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductSellingPriceTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductUnitNameTextBox
            // 
            PM_CRUD_ProductUnitNameTextBox.Location = new Point(178, 223);
            PM_CRUD_ProductUnitNameTextBox.Name = "PM_CRUD_ProductUnitNameTextBox";
            PM_CRUD_ProductUnitNameTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductUnitNameTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductCategoryTextBox
            // 
            PM_CRUD_ProductCategoryTextBox.Location = new Point(178, 252);
            PM_CRUD_ProductCategoryTextBox.Name = "PM_CRUD_ProductCategoryTextBox";
            PM_CRUD_ProductCategoryTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductCategoryTextBox.TabIndex = 2;
            // 
            // PM_CRUD_ProductQuantityTextBox
            // 
            PM_CRUD_ProductQuantityTextBox.Location = new Point(178, 132);
            PM_CRUD_ProductQuantityTextBox.Name = "PM_CRUD_ProductQuantityTextBox";
            PM_CRUD_ProductQuantityTextBox.Size = new Size(183, 23);
            PM_CRUD_ProductQuantityTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(PM_CRUD_ProductQuantityLabel);
            panel2.Controls.Add(PM_CRUD_ProductQuantityTextBox);
            panel2.Controls.Add(PM_CRUD_ProductCategoryLabel);
            panel2.Controls.Add(PM_CRUD_ProductCostPriceLabel);
            panel2.Controls.Add(PM_CRUD_ProductCategoryTextBox);
            panel2.Controls.Add(PM_CRUD_ProductUnitNameLabel);
            panel2.Controls.Add(PM_CRUD_ProductTextBox);
            panel2.Controls.Add(PM_CRUD_ProductNameLabel);
            panel2.Controls.Add(PM_CRUD_ProductCostPriceTextBox);
            panel2.Controls.Add(PM_CRUD_ProductSellingPriceLabel);
            panel2.Controls.Add(PM_CRUD_ProductBarcodeTextBox);
            panel2.Controls.Add(PM_CRUD_ProductBarcodeLabel);
            panel2.Controls.Add(PM_CRUD_ProductUnitNameTextBox);
            panel2.Controls.Add(PM_CRUD_ProductIdLabel);
            panel2.Controls.Add(PM_CRUD_ProductSellingPriceTextBox);
            panel2.Controls.Add(PM_CRUD_ProductNameTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 333);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(PM_CRUD_GroupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 385);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(377, 333);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // PM_CRUD_PictureBox1
            // 
            PM_CRUD_PictureBox1.Dock = DockStyle.Fill;
            PM_CRUD_PictureBox1.Location = new Point(3, 19);
            PM_CRUD_PictureBox1.Name = "PM_CRUD_PictureBox1";
            PM_CRUD_PictureBox1.Size = new Size(176, 305);
            PM_CRUD_PictureBox1.TabIndex = 0;
            PM_CRUD_PictureBox1.TabStop = false;
            // 
            // PM_CRUD_GroupBox1
            // 
            PM_CRUD_GroupBox1.Controls.Add(PM_CRUD_PictureBox1);
            PM_CRUD_GroupBox1.Dock = DockStyle.Fill;
            PM_CRUD_GroupBox1.Location = new Point(3, 3);
            PM_CRUD_GroupBox1.Name = "PM_CRUD_GroupBox1";
            PM_CRUD_GroupBox1.Size = new Size(182, 327);
            PM_CRUD_GroupBox1.TabIndex = 0;
            PM_CRUD_GroupBox1.TabStop = false;
            PM_CRUD_GroupBox1.Text = "groupBox1";
            // 
            // ProductManagementForm_CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 759);
            Controls.Add(PM_CRUD_Panel1);
            Name = "ProductManagementForm_CRUD";
            Text = "ProductManagementForm_CRUD";
            PM_CRUD_Panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PM_CRUD_PictureBox1).EndInit();
            PM_CRUD_GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PM_CRUD_Panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label PM_CRUD_HeadingLabel;
        private TextBox PM_CRUD_ProductCostPriceTextBox;
        private TextBox PM_CRUD_ProductNameTextBox;
        private TextBox PM_CRUD_ProductBarcodeTextBox;
        private TextBox PM_CRUD_ProductTextBox;
        private Label PM_CRUD_ProductCostPriceLabel;
        private Label PM_CRUD_ProductNameLabel;
        private Label PM_CRUD_ProductBarcodeLabel;
        private Label PM_CRUD_ProductIdLabel;
        private TextBox PM_CRUD_ProductQuantityTextBox;
        private TextBox PM_CRUD_ProductCategoryTextBox;
        private TextBox PM_CRUD_ProductUnitNameTextBox;
        private TextBox PM_CRUD_ProductSellingPriceTextBox;
        private Label PM_CRUD_ProductQuantityLabel;
        private Label PM_CRUD_ProductCategoryLabel;
        private Label PM_CRUD_ProductUnitNameLabel;
        private Label PM_CRUD_ProductSellingPriceLabel;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox PM_CRUD_GroupBox1;
        private PictureBox PM_CRUD_PictureBox1;
    }
}