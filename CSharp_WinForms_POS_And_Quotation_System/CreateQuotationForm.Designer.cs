using System.Windows.Forms;

namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class CreateQuotationForm
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            CQ_Panel2 = new Panel();
            tableLayoutPanel10 = new TableLayoutPanel();
            CQ_QuotaionNoGroupBox = new GroupBox();
            CQ_QuotaionNumberTextBox = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            CQ_ShippingItemDateTimeCheckBox = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CQ_QuotaionIssueDateTimeCheckBox = new CheckBox();
            CQ_QuotaionDateIssueDateTimePicker = new DateTimePicker();
            flowLayoutPanel2 = new FlowLayoutPanel();
            CQ_ConfirmDealDateTimeCheckBox = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            CQ_CompanyDetailsGroupBox = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            CQ_CompanyDetailsEditButton = new Button();
            CQ_SignatureGroupBox = new GroupBox();
            CQ_SignatureUploadButton = new Button();
            CQ_SignaturePictureBox = new PictureBox();
            CQ_CustomerDetailsGroupBox = new GroupBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            CQ_CustomerDetailsAddButton = new Button();
            CQ_CancelButton = new Button();
            CQ_ConfirmButton = new Button();
            CQ_ProductDetailsGroupBox = new GroupBox();
            CQ_TableLayoutPanel9 = new TableLayoutPanel();
            CQ_AmountAfterDiscountLabel = new Label();
            CQ_SubTotalTextBox = new TextBox();
            CQ_DiscountTextBox = new TextBox();
            CQ_AmountAfterDiscountTextBox = new TextBox();
            CQ_SubTotalLabel = new Label();
            CQ_TableLayoutPanel11 = new TableLayoutPanel();
            CQ_DiscountCheckBox = new CheckBox();
            CQ_DiscountNumericUpDown = new NumericUpDown();
            CQ_DiscountLabel = new Label();
            CQ_VatLabel = new Label();
            CQ_TotalLabel = new Label();
            CQ_TotalTextBox = new TextBox();
            CQ_TableLayoutPanel10 = new TableLayoutPanel();
            CQ_TotalLetterLabel = new Label();
            CQ_VatTextBox = new TextBox();
            CQ_ProductDetailsDataGridView = new DataGridView();
            CQ_DataGridViewIdColumn = new DataGridViewTextBoxColumn();
            CQ_DataGridViewDetailColumn = new DataGridViewTextBoxColumn();
            CQ_DataGridViewQuantityColumn = new DataGridViewTextBoxColumn();
            CQ_DataGridViewUnitColumn = new DataGridViewTextBoxColumn();
            CQ_DataGridViewPricePerUnitColumn = new DataGridViewTextBoxColumn();
            CQ_DataGridViewAmountPriceColumn = new DataGridViewTextBoxColumn();
            CQ_Panel1 = new Panel();
            CQ_HeadingLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox6 = new TextBox();
            label7 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1.SuspendLayout();
            CQ_Panel2.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            CQ_QuotaionNoGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            CQ_CompanyDetailsGroupBox.SuspendLayout();
            CQ_SignatureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CQ_SignaturePictureBox).BeginInit();
            CQ_CustomerDetailsGroupBox.SuspendLayout();
            CQ_ProductDetailsGroupBox.SuspendLayout();
            CQ_TableLayoutPanel9.SuspendLayout();
            CQ_TableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CQ_DiscountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CQ_ProductDetailsDataGridView).BeginInit();
            CQ_Panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CQ_Panel2);
            panel1.Controls.Add(CQ_Panel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1484, 861);
            panel1.TabIndex = 0;
            // 
            // CQ_Panel2
            // 
            CQ_Panel2.BackColor = SystemColors.Control;
            CQ_Panel2.Controls.Add(tableLayoutPanel10);
            CQ_Panel2.Controls.Add(CQ_CancelButton);
            CQ_Panel2.Controls.Add(CQ_ConfirmButton);
            CQ_Panel2.Controls.Add(CQ_ProductDetailsGroupBox);
            CQ_Panel2.Dock = DockStyle.Fill;
            CQ_Panel2.Location = new Point(0, 60);
            CQ_Panel2.Name = "CQ_Panel2";
            CQ_Panel2.Size = new Size(1482, 799);
            CQ_Panel2.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(CQ_QuotaionNoGroupBox, 0, 0);
            tableLayoutPanel10.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel10.Controls.Add(CQ_CompanyDetailsGroupBox, 0, 2);
            tableLayoutPanel10.Controls.Add(CQ_SignatureGroupBox, 0, 4);
            tableLayoutPanel10.Controls.Add(CQ_CustomerDetailsGroupBox, 0, 3);
            tableLayoutPanel10.Location = new Point(6, 6);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 5;
            tableLayoutPanel10.RowStyles.Add(new RowStyle());
            tableLayoutPanel10.RowStyles.Add(new RowStyle());
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle());
            tableLayoutPanel10.Size = new Size(331, 750);
            tableLayoutPanel10.TabIndex = 11;
            // 
            // CQ_QuotaionNoGroupBox
            // 
            CQ_QuotaionNoGroupBox.Controls.Add(CQ_QuotaionNumberTextBox);
            CQ_QuotaionNoGroupBox.Dock = DockStyle.Fill;
            CQ_QuotaionNoGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_QuotaionNoGroupBox.ForeColor = Color.Maroon;
            CQ_QuotaionNoGroupBox.Location = new Point(0, 0);
            CQ_QuotaionNoGroupBox.Margin = new Padding(0, 0, 0, 3);
            CQ_QuotaionNoGroupBox.Name = "CQ_QuotaionNoGroupBox";
            CQ_QuotaionNoGroupBox.Size = new Size(331, 56);
            CQ_QuotaionNoGroupBox.TabIndex = 5;
            CQ_QuotaionNoGroupBox.TabStop = false;
            CQ_QuotaionNoGroupBox.Text = "เลขที่ใบเสนอราคา";
            // 
            // CQ_QuotaionNumberTextBox
            // 
            CQ_QuotaionNumberTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_QuotaionNumberTextBox.ForeColor = Color.Maroon;
            CQ_QuotaionNumberTextBox.Location = new Point(6, 25);
            CQ_QuotaionNumberTextBox.Name = "CQ_QuotaionNumberTextBox";
            CQ_QuotaionNumberTextBox.ReadOnly = true;
            CQ_QuotaionNumberTextBox.Size = new Size(319, 24);
            CQ_QuotaionNumberTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.OrangeRed;
            groupBox2.Location = new Point(0, 62);
            groupBox2.Margin = new Padding(0, 3, 0, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 213);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "วันที่และเวลา";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(325, 188);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(CQ_ShippingItemDateTimeCheckBox);
            flowLayoutPanel3.Controls.Add(dateTimePicker2);
            flowLayoutPanel3.Location = new Point(4, 128);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(317, 55);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // CQ_ShippingItemDateTimeCheckBox
            // 
            CQ_ShippingItemDateTimeCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CQ_ShippingItemDateTimeCheckBox.AutoSize = true;
            CQ_ShippingItemDateTimeCheckBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_ShippingItemDateTimeCheckBox.ForeColor = Color.Black;
            CQ_ShippingItemDateTimeCheckBox.Location = new Point(3, 3);
            CQ_ShippingItemDateTimeCheckBox.Margin = new Padding(3, 3, 3, 0);
            CQ_ShippingItemDateTimeCheckBox.Name = "CQ_ShippingItemDateTimeCheckBox";
            CQ_ShippingItemDateTimeCheckBox.Size = new Size(180, 22);
            CQ_ShippingItemDateTimeCheckBox.TabIndex = 0;
            CQ_ShippingItemDateTimeCheckBox.Text = "กำหนดส่งของภายในวันที่";
            CQ_ShippingItemDateTimeCheckBox.TextAlign = ContentAlignment.BottomLeft;
            CQ_ShippingItemDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(3, 25);
            dateTimePicker2.Margin = new Padding(3, 0, 3, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(314, 26);
            dateTimePicker2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Controls.Add(CQ_QuotaionIssueDateTimeCheckBox);
            flowLayoutPanel1.Controls.Add(CQ_QuotaionDateIssueDateTimePicker);
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 55);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // CQ_QuotaionIssueDateTimeCheckBox
            // 
            CQ_QuotaionIssueDateTimeCheckBox.AutoSize = true;
            CQ_QuotaionIssueDateTimeCheckBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_QuotaionIssueDateTimeCheckBox.ForeColor = Color.Black;
            CQ_QuotaionIssueDateTimeCheckBox.Location = new Point(3, 3);
            CQ_QuotaionIssueDateTimeCheckBox.Margin = new Padding(3, 3, 3, 0);
            CQ_QuotaionIssueDateTimeCheckBox.Name = "CQ_QuotaionIssueDateTimeCheckBox";
            CQ_QuotaionIssueDateTimeCheckBox.Size = new Size(158, 22);
            CQ_QuotaionIssueDateTimeCheckBox.TabIndex = 11;
            CQ_QuotaionIssueDateTimeCheckBox.Text = "วันที่ออกใบเสนอราคา";
            CQ_QuotaionIssueDateTimeCheckBox.TextAlign = ContentAlignment.BottomLeft;
            CQ_QuotaionIssueDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // CQ_QuotaionDateIssueDateTimePicker
            // 
            CQ_QuotaionDateIssueDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CQ_QuotaionDateIssueDateTimePicker.CalendarForeColor = Color.Maroon;
            CQ_QuotaionDateIssueDateTimePicker.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_QuotaionDateIssueDateTimePicker.Location = new Point(3, 25);
            CQ_QuotaionDateIssueDateTimePicker.Margin = new Padding(3, 0, 3, 3);
            CQ_QuotaionDateIssueDateTimePicker.Name = "CQ_QuotaionDateIssueDateTimePicker";
            CQ_QuotaionDateIssueDateTimePicker.Size = new Size(314, 26);
            CQ_QuotaionDateIssueDateTimePicker.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(CQ_ConfirmDealDateTimeCheckBox);
            flowLayoutPanel2.Controls.Add(dateTimePicker1);
            flowLayoutPanel2.Location = new Point(4, 66);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(317, 55);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // CQ_ConfirmDealDateTimeCheckBox
            // 
            CQ_ConfirmDealDateTimeCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CQ_ConfirmDealDateTimeCheckBox.AutoSize = true;
            CQ_ConfirmDealDateTimeCheckBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_ConfirmDealDateTimeCheckBox.ForeColor = Color.Black;
            CQ_ConfirmDealDateTimeCheckBox.Location = new Point(3, 3);
            CQ_ConfirmDealDateTimeCheckBox.Margin = new Padding(3, 3, 3, 0);
            CQ_ConfirmDealDateTimeCheckBox.Name = "CQ_ConfirmDealDateTimeCheckBox";
            CQ_ConfirmDealDateTimeCheckBox.Size = new Size(186, 22);
            CQ_ConfirmDealDateTimeCheckBox.TabIndex = 0;
            CQ_ConfirmDealDateTimeCheckBox.Text = "กำหนดยืนราคาภายในวันที่";
            CQ_ConfirmDealDateTimeCheckBox.TextAlign = ContentAlignment.BottomLeft;
            CQ_ConfirmDealDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(3, 25);
            dateTimePicker1.Margin = new Padding(3, 0, 3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 26);
            dateTimePicker1.TabIndex = 1;
            // 
            // CQ_CompanyDetailsGroupBox
            // 
            CQ_CompanyDetailsGroupBox.BackColor = SystemColors.Control;
            CQ_CompanyDetailsGroupBox.Controls.Add(textBox1);
            CQ_CompanyDetailsGroupBox.Controls.Add(comboBox1);
            CQ_CompanyDetailsGroupBox.Controls.Add(CQ_CompanyDetailsEditButton);
            CQ_CompanyDetailsGroupBox.Dock = DockStyle.Fill;
            CQ_CompanyDetailsGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_CompanyDetailsGroupBox.ForeColor = Color.Blue;
            CQ_CompanyDetailsGroupBox.Location = new Point(0, 281);
            CQ_CompanyDetailsGroupBox.Margin = new Padding(0, 3, 0, 3);
            CQ_CompanyDetailsGroupBox.Name = "CQ_CompanyDetailsGroupBox";
            CQ_CompanyDetailsGroupBox.Size = new Size(331, 174);
            CQ_CompanyDetailsGroupBox.TabIndex = 3;
            CQ_CompanyDetailsGroupBox.TabStop = false;
            CQ_CompanyDetailsGroupBox.Text = "ชื่อ/ที่อยู่บริษัท";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Location = new Point(6, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(319, 77);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 26);
            comboBox1.TabIndex = 16;
            // 
            // CQ_CompanyDetailsEditButton
            // 
            CQ_CompanyDetailsEditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CQ_CompanyDetailsEditButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_CompanyDetailsEditButton.ForeColor = SystemColors.WindowText;
            CQ_CompanyDetailsEditButton.Image = Properties.Resources.edit_16;
            CQ_CompanyDetailsEditButton.ImageAlign = ContentAlignment.MiddleRight;
            CQ_CompanyDetailsEditButton.Location = new Point(179, 138);
            CQ_CompanyDetailsEditButton.Name = "CQ_CompanyDetailsEditButton";
            CQ_CompanyDetailsEditButton.Size = new Size(146, 30);
            CQ_CompanyDetailsEditButton.TabIndex = 2;
            CQ_CompanyDetailsEditButton.Text = "จัดการข้อมูลบริษัท";
            CQ_CompanyDetailsEditButton.TextAlign = ContentAlignment.MiddleRight;
            CQ_CompanyDetailsEditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CQ_CompanyDetailsEditButton.UseVisualStyleBackColor = true;
            // 
            // CQ_SignatureGroupBox
            // 
            CQ_SignatureGroupBox.Controls.Add(CQ_SignatureUploadButton);
            CQ_SignatureGroupBox.Controls.Add(CQ_SignaturePictureBox);
            CQ_SignatureGroupBox.Dock = DockStyle.Fill;
            CQ_SignatureGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_SignatureGroupBox.ForeColor = Color.DarkGreen;
            CQ_SignatureGroupBox.Location = new Point(0, 641);
            CQ_SignatureGroupBox.Margin = new Padding(0, 3, 0, 0);
            CQ_SignatureGroupBox.Name = "CQ_SignatureGroupBox";
            CQ_SignatureGroupBox.Size = new Size(331, 109);
            CQ_SignatureGroupBox.TabIndex = 7;
            CQ_SignatureGroupBox.TabStop = false;
            CQ_SignatureGroupBox.Text = "ลายเซ็น";
            // 
            // CQ_SignatureUploadButton
            // 
            CQ_SignatureUploadButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_SignatureUploadButton.ForeColor = SystemColors.WindowText;
            CQ_SignatureUploadButton.Image = Properties.Resources.picture_attachment_21;
            CQ_SignatureUploadButton.Location = new Point(250, 30);
            CQ_SignatureUploadButton.Name = "CQ_SignatureUploadButton";
            CQ_SignatureUploadButton.Size = new Size(75, 70);
            CQ_SignatureUploadButton.TabIndex = 1;
            CQ_SignatureUploadButton.Text = "อัพโหลด\r\nลายเซ็น";
            CQ_SignatureUploadButton.TextImageRelation = TextImageRelation.ImageAboveText;
            CQ_SignatureUploadButton.UseVisualStyleBackColor = true;
            // 
            // CQ_SignaturePictureBox
            // 
            CQ_SignaturePictureBox.BackColor = Color.White;
            CQ_SignaturePictureBox.BorderStyle = BorderStyle.FixedSingle;
            CQ_SignaturePictureBox.Location = new Point(6, 19);
            CQ_SignaturePictureBox.Name = "CQ_SignaturePictureBox";
            CQ_SignaturePictureBox.Size = new Size(238, 81);
            CQ_SignaturePictureBox.TabIndex = 0;
            CQ_SignaturePictureBox.TabStop = false;
            // 
            // CQ_CustomerDetailsGroupBox
            // 
            CQ_CustomerDetailsGroupBox.Controls.Add(comboBox2);
            CQ_CustomerDetailsGroupBox.Controls.Add(textBox2);
            CQ_CustomerDetailsGroupBox.Controls.Add(CQ_CustomerDetailsAddButton);
            CQ_CustomerDetailsGroupBox.Dock = DockStyle.Fill;
            CQ_CustomerDetailsGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_CustomerDetailsGroupBox.ForeColor = Color.Purple;
            CQ_CustomerDetailsGroupBox.Location = new Point(0, 461);
            CQ_CustomerDetailsGroupBox.Margin = new Padding(0, 3, 0, 3);
            CQ_CustomerDetailsGroupBox.Name = "CQ_CustomerDetailsGroupBox";
            CQ_CustomerDetailsGroupBox.Size = new Size(331, 174);
            CQ_CustomerDetailsGroupBox.TabIndex = 4;
            CQ_CustomerDetailsGroupBox.TabStop = false;
            CQ_CustomerDetailsGroupBox.Text = "ชื่อ/ที่อยู่ลูกค้า";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 23);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(318, 26);
            comboBox2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Location = new Point(6, 53);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(319, 79);
            textBox2.TabIndex = 7;
            // 
            // CQ_CustomerDetailsAddButton
            // 
            CQ_CustomerDetailsAddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CQ_CustomerDetailsAddButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_CustomerDetailsAddButton.ForeColor = SystemColors.WindowText;
            CQ_CustomerDetailsAddButton.Image = Properties.Resources.edit_16;
            CQ_CustomerDetailsAddButton.ImageAlign = ContentAlignment.MiddleRight;
            CQ_CustomerDetailsAddButton.Location = new Point(179, 138);
            CQ_CustomerDetailsAddButton.Name = "CQ_CustomerDetailsAddButton";
            CQ_CustomerDetailsAddButton.Size = new Size(146, 30);
            CQ_CustomerDetailsAddButton.TabIndex = 6;
            CQ_CustomerDetailsAddButton.Text = "จัดการข้อมูลลูกค้า";
            CQ_CustomerDetailsAddButton.TextAlign = ContentAlignment.MiddleRight;
            CQ_CustomerDetailsAddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CQ_CustomerDetailsAddButton.UseVisualStyleBackColor = true;
            // 
            // CQ_CancelButton
            // 
            CQ_CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CQ_CancelButton.BackColor = Color.Red;
            CQ_CancelButton.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_CancelButton.ForeColor = Color.LightGray;
            CQ_CancelButton.Location = new Point(1356, 759);
            CQ_CancelButton.Name = "CQ_CancelButton";
            CQ_CancelButton.Size = new Size(120, 35);
            CQ_CancelButton.TabIndex = 9;
            CQ_CancelButton.Text = "ยกเลิก";
            CQ_CancelButton.UseVisualStyleBackColor = false;
            CQ_CancelButton.Click += CreateQuotationCancelButton_Click;
            // 
            // CQ_ConfirmButton
            // 
            CQ_ConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CQ_ConfirmButton.BackColor = Color.ForestGreen;
            CQ_ConfirmButton.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_ConfirmButton.ForeColor = Color.LightGray;
            CQ_ConfirmButton.Location = new Point(1230, 759);
            CQ_ConfirmButton.Name = "CQ_ConfirmButton";
            CQ_ConfirmButton.Size = new Size(120, 35);
            CQ_ConfirmButton.TabIndex = 8;
            CQ_ConfirmButton.Text = "ยืนยัน";
            CQ_ConfirmButton.UseVisualStyleBackColor = false;
            // 
            // CQ_ProductDetailsGroupBox
            // 
            CQ_ProductDetailsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CQ_ProductDetailsGroupBox.Controls.Add(CQ_TableLayoutPanel9);
            CQ_ProductDetailsGroupBox.Controls.Add(CQ_ProductDetailsDataGridView);
            CQ_ProductDetailsGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_ProductDetailsGroupBox.ForeColor = Color.Black;
            CQ_ProductDetailsGroupBox.Location = new Point(343, 6);
            CQ_ProductDetailsGroupBox.Name = "CQ_ProductDetailsGroupBox";
            CQ_ProductDetailsGroupBox.Size = new Size(1133, 750);
            CQ_ProductDetailsGroupBox.TabIndex = 6;
            CQ_ProductDetailsGroupBox.TabStop = false;
            CQ_ProductDetailsGroupBox.Text = "รายการสินค้า";
            // 
            // CQ_TableLayoutPanel9
            // 
            CQ_TableLayoutPanel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CQ_TableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            CQ_TableLayoutPanel9.ColumnCount = 3;
            CQ_TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CQ_TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            CQ_TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            CQ_TableLayoutPanel9.Controls.Add(CQ_AmountAfterDiscountLabel, 1, 2);
            CQ_TableLayoutPanel9.Controls.Add(CQ_SubTotalTextBox, 2, 0);
            CQ_TableLayoutPanel9.Controls.Add(CQ_DiscountTextBox, 2, 1);
            CQ_TableLayoutPanel9.Controls.Add(CQ_AmountAfterDiscountTextBox, 2, 2);
            CQ_TableLayoutPanel9.Controls.Add(CQ_SubTotalLabel, 1, 0);
            CQ_TableLayoutPanel9.Controls.Add(CQ_TableLayoutPanel11, 1, 1);
            CQ_TableLayoutPanel9.Controls.Add(CQ_VatLabel, 1, 3);
            CQ_TableLayoutPanel9.Controls.Add(CQ_TotalLabel, 1, 4);
            CQ_TableLayoutPanel9.Controls.Add(CQ_TotalTextBox, 2, 4);
            CQ_TableLayoutPanel9.Controls.Add(CQ_TableLayoutPanel10, 0, 0);
            CQ_TableLayoutPanel9.Controls.Add(CQ_TotalLetterLabel, 0, 4);
            CQ_TableLayoutPanel9.Controls.Add(CQ_VatTextBox, 2, 3);
            CQ_TableLayoutPanel9.Location = new Point(6, 595);
            CQ_TableLayoutPanel9.Name = "CQ_TableLayoutPanel9";
            CQ_TableLayoutPanel9.RowCount = 5;
            CQ_TableLayoutPanel9.RowStyles.Add(new RowStyle());
            CQ_TableLayoutPanel9.RowStyles.Add(new RowStyle());
            CQ_TableLayoutPanel9.RowStyles.Add(new RowStyle());
            CQ_TableLayoutPanel9.RowStyles.Add(new RowStyle());
            CQ_TableLayoutPanel9.RowStyles.Add(new RowStyle());
            CQ_TableLayoutPanel9.Size = new Size(1121, 149);
            CQ_TableLayoutPanel9.TabIndex = 3;
            // 
            // CQ_AmountAfterDiscountLabel
            // 
            CQ_AmountAfterDiscountLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_AmountAfterDiscountLabel.AutoSize = true;
            CQ_AmountAfterDiscountLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_AmountAfterDiscountLabel.ForeColor = SystemColors.WindowText;
            CQ_AmountAfterDiscountLabel.Location = new Point(829, 61);
            CQ_AmountAfterDiscountLabel.Margin = new Padding(0);
            CQ_AmountAfterDiscountLabel.Name = "CQ_AmountAfterDiscountLabel";
            CQ_AmountAfterDiscountLabel.Size = new Size(170, 18);
            CQ_AmountAfterDiscountLabel.TabIndex = 8;
            CQ_AmountAfterDiscountLabel.Text = "จำนวนเงินหลังหักส่วนลด";
            CQ_AmountAfterDiscountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CQ_SubTotalTextBox
            // 
            CQ_SubTotalTextBox.Dock = DockStyle.Fill;
            CQ_SubTotalTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_SubTotalTextBox.ForeColor = Color.Green;
            CQ_SubTotalTextBox.Location = new Point(1000, 1);
            CQ_SubTotalTextBox.Margin = new Padding(0);
            CQ_SubTotalTextBox.Name = "CQ_SubTotalTextBox";
            CQ_SubTotalTextBox.ReadOnly = true;
            CQ_SubTotalTextBox.Size = new Size(120, 26);
            CQ_SubTotalTextBox.TabIndex = 0;
            // 
            // CQ_DiscountTextBox
            // 
            CQ_DiscountTextBox.Dock = DockStyle.Fill;
            CQ_DiscountTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_DiscountTextBox.ForeColor = Color.Green;
            CQ_DiscountTextBox.Location = new Point(1000, 28);
            CQ_DiscountTextBox.Margin = new Padding(0);
            CQ_DiscountTextBox.Multiline = true;
            CQ_DiscountTextBox.Name = "CQ_DiscountTextBox";
            CQ_DiscountTextBox.ReadOnly = true;
            CQ_DiscountTextBox.Size = new Size(120, 28);
            CQ_DiscountTextBox.TabIndex = 1;
            // 
            // CQ_AmountAfterDiscountTextBox
            // 
            CQ_AmountAfterDiscountTextBox.Dock = DockStyle.Fill;
            CQ_AmountAfterDiscountTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_AmountAfterDiscountTextBox.ForeColor = Color.Green;
            CQ_AmountAfterDiscountTextBox.Location = new Point(1000, 57);
            CQ_AmountAfterDiscountTextBox.Margin = new Padding(0);
            CQ_AmountAfterDiscountTextBox.Name = "CQ_AmountAfterDiscountTextBox";
            CQ_AmountAfterDiscountTextBox.ReadOnly = true;
            CQ_AmountAfterDiscountTextBox.Size = new Size(120, 26);
            CQ_AmountAfterDiscountTextBox.TabIndex = 2;
            // 
            // CQ_SubTotalLabel
            // 
            CQ_SubTotalLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_SubTotalLabel.AutoSize = true;
            CQ_SubTotalLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_SubTotalLabel.ForeColor = SystemColors.WindowText;
            CQ_SubTotalLabel.Location = new Point(829, 5);
            CQ_SubTotalLabel.Margin = new Padding(0);
            CQ_SubTotalLabel.Name = "CQ_SubTotalLabel";
            CQ_SubTotalLabel.Size = new Size(170, 18);
            CQ_SubTotalLabel.TabIndex = 4;
            CQ_SubTotalLabel.Text = "รวมเป็นเงิน";
            CQ_SubTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CQ_TableLayoutPanel11
            // 
            CQ_TableLayoutPanel11.ColumnCount = 3;
            CQ_TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CQ_TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            CQ_TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            CQ_TableLayoutPanel11.Controls.Add(CQ_DiscountCheckBox, 0, 0);
            CQ_TableLayoutPanel11.Controls.Add(CQ_DiscountNumericUpDown, 1, 0);
            CQ_TableLayoutPanel11.Controls.Add(CQ_DiscountLabel, 2, 0);
            CQ_TableLayoutPanel11.Dock = DockStyle.Fill;
            CQ_TableLayoutPanel11.Location = new Point(829, 28);
            CQ_TableLayoutPanel11.Margin = new Padding(0);
            CQ_TableLayoutPanel11.Name = "CQ_TableLayoutPanel11";
            CQ_TableLayoutPanel11.RowCount = 1;
            CQ_TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CQ_TableLayoutPanel11.Size = new Size(170, 28);
            CQ_TableLayoutPanel11.TabIndex = 5;
            // 
            // CQ_DiscountCheckBox
            // 
            CQ_DiscountCheckBox.Anchor = AnchorStyles.Right;
            CQ_DiscountCheckBox.AutoSize = true;
            CQ_DiscountCheckBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_DiscountCheckBox.ForeColor = SystemColors.WindowText;
            CQ_DiscountCheckBox.Location = new Point(15, 3);
            CQ_DiscountCheckBox.Margin = new Padding(0);
            CQ_DiscountCheckBox.Name = "CQ_DiscountCheckBox";
            CQ_DiscountCheckBox.Size = new Size(70, 22);
            CQ_DiscountCheckBox.TabIndex = 0;
            CQ_DiscountCheckBox.Text = "ส่วนลด";
            CQ_DiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // CQ_DiscountNumericUpDown
            // 
            CQ_DiscountNumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_DiscountNumericUpDown.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_DiscountNumericUpDown.Location = new Point(85, 1);
            CQ_DiscountNumericUpDown.Margin = new Padding(0);
            CQ_DiscountNumericUpDown.Name = "CQ_DiscountNumericUpDown";
            CQ_DiscountNumericUpDown.Size = new Size(51, 26);
            CQ_DiscountNumericUpDown.TabIndex = 1;
            CQ_DiscountNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // CQ_DiscountLabel
            // 
            CQ_DiscountLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_DiscountLabel.AutoSize = true;
            CQ_DiscountLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_DiscountLabel.ForeColor = SystemColors.WindowText;
            CQ_DiscountLabel.Location = new Point(136, 5);
            CQ_DiscountLabel.Margin = new Padding(0);
            CQ_DiscountLabel.Name = "CQ_DiscountLabel";
            CQ_DiscountLabel.Size = new Size(34, 18);
            CQ_DiscountLabel.TabIndex = 2;
            CQ_DiscountLabel.Text = "%";
            CQ_DiscountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CQ_VatLabel
            // 
            CQ_VatLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_VatLabel.AutoSize = true;
            CQ_VatLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_VatLabel.ForeColor = SystemColors.WindowText;
            CQ_VatLabel.Location = new Point(829, 88);
            CQ_VatLabel.Margin = new Padding(0);
            CQ_VatLabel.Name = "CQ_VatLabel";
            CQ_VatLabel.Size = new Size(170, 18);
            CQ_VatLabel.TabIndex = 7;
            CQ_VatLabel.Text = "ภาษีมูลค่าเพิ่ม 7 %";
            CQ_VatLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CQ_TotalLabel
            // 
            CQ_TotalLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_TotalLabel.AutoSize = true;
            CQ_TotalLabel.ForeColor = SystemColors.WindowText;
            CQ_TotalLabel.Location = new Point(829, 120);
            CQ_TotalLabel.Margin = new Padding(0);
            CQ_TotalLabel.Name = "CQ_TotalLabel";
            CQ_TotalLabel.Size = new Size(170, 18);
            CQ_TotalLabel.TabIndex = 9;
            CQ_TotalLabel.Text = "จำนวนเงินทั้งสิน";
            CQ_TotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CQ_TotalTextBox
            // 
            CQ_TotalTextBox.Dock = DockStyle.Fill;
            CQ_TotalTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CQ_TotalTextBox.ForeColor = Color.Green;
            CQ_TotalTextBox.Location = new Point(1000, 111);
            CQ_TotalTextBox.Margin = new Padding(0);
            CQ_TotalTextBox.Multiline = true;
            CQ_TotalTextBox.Name = "CQ_TotalTextBox";
            CQ_TotalTextBox.ReadOnly = true;
            CQ_TotalTextBox.Size = new Size(120, 37);
            CQ_TotalTextBox.TabIndex = 3;
            // 
            // CQ_TableLayoutPanel10
            // 
            CQ_TableLayoutPanel10.ColumnCount = 1;
            CQ_TableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CQ_TableLayoutPanel10.Dock = DockStyle.Fill;
            CQ_TableLayoutPanel10.Location = new Point(1, 1);
            CQ_TableLayoutPanel10.Margin = new Padding(0);
            CQ_TableLayoutPanel10.Name = "CQ_TableLayoutPanel10";
            CQ_TableLayoutPanel10.RowCount = 1;
            CQ_TableLayoutPanel9.SetRowSpan(CQ_TableLayoutPanel10, 4);
            CQ_TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CQ_TableLayoutPanel10.Size = new Size(827, 109);
            CQ_TableLayoutPanel10.TabIndex = 10;
            // 
            // CQ_TotalLetterLabel
            // 
            CQ_TotalLetterLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CQ_TotalLetterLabel.AutoSize = true;
            CQ_TotalLetterLabel.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_TotalLetterLabel.ForeColor = SystemColors.WindowText;
            CQ_TotalLetterLabel.Location = new Point(4, 120);
            CQ_TotalLetterLabel.Name = "CQ_TotalLetterLabel";
            CQ_TotalLetterLabel.Size = new Size(821, 18);
            CQ_TotalLetterLabel.TabIndex = 11;
            CQ_TotalLetterLabel.Text = "(ตัวหนังสือ)";
            CQ_TotalLetterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CQ_VatTextBox
            // 
            CQ_VatTextBox.Dock = DockStyle.Fill;
            CQ_VatTextBox.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_VatTextBox.ForeColor = Color.Green;
            CQ_VatTextBox.Location = new Point(1000, 84);
            CQ_VatTextBox.Margin = new Padding(0);
            CQ_VatTextBox.Name = "CQ_VatTextBox";
            CQ_VatTextBox.ReadOnly = true;
            CQ_VatTextBox.Size = new Size(120, 26);
            CQ_VatTextBox.TabIndex = 3;
            // 
            // CQ_ProductDetailsDataGridView
            // 
            CQ_ProductDetailsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CQ_ProductDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CQ_ProductDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CQ_ProductDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { CQ_DataGridViewIdColumn, CQ_DataGridViewDetailColumn, CQ_DataGridViewQuantityColumn, CQ_DataGridViewUnitColumn, CQ_DataGridViewPricePerUnitColumn, CQ_DataGridViewAmountPriceColumn });
            CQ_ProductDetailsDataGridView.Location = new Point(6, 25);
            CQ_ProductDetailsDataGridView.Margin = new Padding(3, 0, 3, 3);
            CQ_ProductDetailsDataGridView.MultiSelect = false;
            CQ_ProductDetailsDataGridView.Name = "CQ_ProductDetailsDataGridView";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            CQ_ProductDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            CQ_ProductDetailsDataGridView.RowTemplate.Height = 25;
            CQ_ProductDetailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CQ_ProductDetailsDataGridView.Size = new Size(1121, 564);
            CQ_ProductDetailsDataGridView.TabIndex = 2;
            // 
            // CQ_DataGridViewIdColumn
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            CQ_DataGridViewIdColumn.DefaultCellStyle = dataGridViewCellStyle2;
            CQ_DataGridViewIdColumn.FillWeight = 50F;
            CQ_DataGridViewIdColumn.HeaderText = "ที่";
            CQ_DataGridViewIdColumn.Name = "CQ_DataGridViewIdColumn";
            CQ_DataGridViewIdColumn.ReadOnly = true;
            CQ_DataGridViewIdColumn.Width = 30;
            // 
            // CQ_DataGridViewDetailColumn
            // 
            dataGridViewCellStyle3.ForeColor = Color.ForestGreen;
            CQ_DataGridViewDetailColumn.DefaultCellStyle = dataGridViewCellStyle3;
            CQ_DataGridViewDetailColumn.FillWeight = 650F;
            CQ_DataGridViewDetailColumn.HeaderText = "รายละเอียด";
            CQ_DataGridViewDetailColumn.Name = "CQ_DataGridViewDetailColumn";
            CQ_DataGridViewDetailColumn.Width = 650;
            // 
            // CQ_DataGridViewQuantityColumn
            // 
            dataGridViewCellStyle4.ForeColor = Color.ForestGreen;
            CQ_DataGridViewQuantityColumn.DefaultCellStyle = dataGridViewCellStyle4;
            CQ_DataGridViewQuantityColumn.HeaderText = "จำนวน";
            CQ_DataGridViewQuantityColumn.Name = "CQ_DataGridViewQuantityColumn";
            // 
            // CQ_DataGridViewUnitColumn
            // 
            dataGridViewCellStyle5.ForeColor = Color.ForestGreen;
            CQ_DataGridViewUnitColumn.DefaultCellStyle = dataGridViewCellStyle5;
            CQ_DataGridViewUnitColumn.HeaderText = "หน่วย";
            CQ_DataGridViewUnitColumn.Name = "CQ_DataGridViewUnitColumn";
            // 
            // CQ_DataGridViewPricePerUnitColumn
            // 
            dataGridViewCellStyle6.ForeColor = Color.ForestGreen;
            CQ_DataGridViewPricePerUnitColumn.DefaultCellStyle = dataGridViewCellStyle6;
            CQ_DataGridViewPricePerUnitColumn.HeaderText = "ราคา/หน่วย";
            CQ_DataGridViewPricePerUnitColumn.Name = "CQ_DataGridViewPricePerUnitColumn";
            // 
            // CQ_DataGridViewAmountPriceColumn
            // 
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = Color.ForestGreen;
            CQ_DataGridViewAmountPriceColumn.DefaultCellStyle = dataGridViewCellStyle7;
            CQ_DataGridViewAmountPriceColumn.HeaderText = "จำนวนเงิน";
            CQ_DataGridViewAmountPriceColumn.Name = "CQ_DataGridViewAmountPriceColumn";
            CQ_DataGridViewAmountPriceColumn.ReadOnly = true;
            // 
            // CQ_Panel1
            // 
            CQ_Panel1.BackColor = Color.FromArgb(135, 214, 135);
            CQ_Panel1.Controls.Add(CQ_HeadingLabel);
            CQ_Panel1.Dock = DockStyle.Top;
            CQ_Panel1.Location = new Point(0, 0);
            CQ_Panel1.Name = "CQ_Panel1";
            CQ_Panel1.Size = new Size(1482, 60);
            CQ_Panel1.TabIndex = 1;
            // 
            // CQ_HeadingLabel
            // 
            CQ_HeadingLabel.AutoSize = true;
            CQ_HeadingLabel.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CQ_HeadingLabel.Location = new Point(8, 8);
            CQ_HeadingLabel.Margin = new Padding(0);
            CQ_HeadingLabel.Name = "CQ_HeadingLabel";
            CQ_HeadingLabel.Size = new Size(251, 39);
            CQ_HeadingLabel.TabIndex = 0;
            CQ_HeadingLabel.Text = "สร้างใบเสนอราคา";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(157, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(6, 26);
            textBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 2);
            label6.Name = "label6";
            label6.Size = new Size(144, 18);
            label6.TabIndex = 5;
            label6.Text = "ชื่อบริษัท:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(1119, 272);
            button1.Name = "button1";
            button1.Size = new Size(103, 30);
            button1.TabIndex = 2;
            button1.Text = "แก้ไข";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(textBox6, 1, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.Blue;
            textBox6.Location = new Point(167, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(28, 26);
            textBox6.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(5, 2);
            label7.Name = "label7";
            label7.Size = new Size(154, 18);
            label7.TabIndex = 5;
            label7.Text = "ชื่อบริษัท:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // CreateQuotationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 861);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateQuotationForm";
            Text = "Create Quotation";
            Load += CreateQuotationForm_Load;
            panel1.ResumeLayout(false);
            CQ_Panel2.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            CQ_QuotaionNoGroupBox.ResumeLayout(false);
            CQ_QuotaionNoGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            CQ_CompanyDetailsGroupBox.ResumeLayout(false);
            CQ_CompanyDetailsGroupBox.PerformLayout();
            CQ_SignatureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CQ_SignaturePictureBox).EndInit();
            CQ_CustomerDetailsGroupBox.ResumeLayout(false);
            CQ_CustomerDetailsGroupBox.PerformLayout();
            CQ_ProductDetailsGroupBox.ResumeLayout(false);
            CQ_TableLayoutPanel9.ResumeLayout(false);
            CQ_TableLayoutPanel9.PerformLayout();
            CQ_TableLayoutPanel11.ResumeLayout(false);
            CQ_TableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CQ_DiscountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CQ_ProductDetailsDataGridView).EndInit();
            CQ_Panel1.ResumeLayout(false);
            CQ_Panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel CQ_Panel2;
        private Panel CQ_Panel1;
        private Label CQ_HeadingLabel;
        private Button CQ_CompanyDetailsEditButton;
        private GroupBox CQ_CompanyDetailsGroupBox;
        private Label CQ_CompanyNameLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox6;
        private Label label7;
        private GroupBox CQ_QuotaionNoGroupBox;
        private GroupBox CQ_CustomerDetailsGroupBox;
        private Button CQ_CustomerDetailsAddButton;
        private Label CQ_CustomerNameLabel;
        private TableLayoutPanel CQ_TableLayoutPanel7;
        private Label CQ_QuotaionNumberLabel;
        private TextBox CQ_QuotaionNumberTextBox;
        private DateTimePicker CQ_QuotaionDateIssueDateTimePicker;
        private GroupBox CQ_SignatureGroupBox;
        private GroupBox CQ_ProductDetailsGroupBox;
        private Button CQ_CancelButton;
        private Button CQ_ConfirmButton;
        private Button CQ_SignatureUploadButton;
        private PictureBox CQ_SignaturePictureBox;
        private DataGridView CQ_ProductDetailsDataGridView;
        private TableLayoutPanel CQ_TableLayoutPanel9;
        private TextBox CQ_SubTotalTextBox;
        private TextBox CQ_DiscountTextBox;
        private TextBox CQ_AmountAfterDiscountTextBox;
        private TextBox CQ_VatTextBox;
        private Label CQ_SubTotalLabel;
        private TableLayoutPanel CQ_TableLayoutPanel11;
        private CheckBox CQ_DiscountCheckBox;
        private NumericUpDown CQ_DiscountNumericUpDown;
        private Label CQ_DiscountLabel;
        private Label CQ_VatLabel;
        private Label CQ_AmountAfterDiscountLabel;
        private Label CQ_TotalLabel;
        private TextBox CQ_TotalTextBox;
        private Label CQ_TotalLetterLabel;
        private DataGridViewTextBoxColumn CQ_DataGridViewIdColumn;
        private DataGridViewTextBoxColumn CQ_DataGridViewDetailColumn;
        private DataGridViewTextBoxColumn CQ_DataGridViewQuantityColumn;
        private DataGridViewTextBoxColumn CQ_DataGridViewUnitColumn;
        private DataGridViewTextBoxColumn CQ_DataGridViewPricePerUnitColumn;
        private DataGridViewTextBoxColumn CQ_DataGridViewAmountPriceColumn;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private CheckBox CQ_QuotaionIssueDateTimeCheckBox;
        private CheckBox CQ_ShippingItemDateTimeCheckBox;
        private CheckBox CQ_ConfirmDealDateTimeCheckBox;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel10;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel CQ_TableLayoutPanel10;
    }
}