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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            CreateQuotationCancelButton = new Button();
            button5 = new Button();
            groupBox5 = new GroupBox();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label15 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label16 = new Label();
            label18 = new Label();
            label17 = new Label();
            label19 = new Label();
            textBox15 = new TextBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            label20 = new Label();
            dataGridView1 = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            detail = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit = new DataGridViewTextBoxColumn();
            PricePerUnit = new DataGridViewTextBoxColumn();
            AmountPrice = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            dateTimePicker2 = new DateTimePicker();
            label14 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label12 = new Label();
            textBox7 = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label13 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            CompanyDetailGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            CompanyNameEditButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox6 = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            CompanyDetailGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 1261);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(250, 253, 236);
            panel3.Controls.Add(CreateQuotationCancelButton);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(groupBox5);
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(CompanyDetailGroupBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 1199);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint_1;
            // 
            // CreateQuotationCancelButton
            // 
            CreateQuotationCancelButton.Location = new Point(1053, 1159);
            CreateQuotationCancelButton.Name = "CreateQuotationCancelButton";
            CreateQuotationCancelButton.Size = new Size(120, 35);
            CreateQuotationCancelButton.TabIndex = 9;
            CreateQuotationCancelButton.Text = "ยกเลิก";
            CreateQuotationCancelButton.UseVisualStyleBackColor = true;
            CreateQuotationCancelButton.Click += CreateQuotationCancelButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(926, 1159);
            button5.Name = "button5";
            button5.Size = new Size(120, 35);
            button5.TabIndex = 8;
            button5.Text = "ยืนยัน";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button7);
            groupBox5.Controls.Add(pictureBox1);
            groupBox5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.DarkOrange;
            groupBox5.Location = new Point(866, 256);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(307, 104);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "ลายเซ็น";
            // 
            // button7
            // 
            button7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.WindowText;
            button7.Location = new Point(226, 68);
            button7.Name = "button7";
            button7.Size = new Size(75, 30);
            button7.TabIndex = 1;
            button7.Text = "แก้ไข";
            button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(6, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 79);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel11);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Crimson;
            groupBox4.Location = new Point(8, 366);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1165, 789);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "รายการสินค้า";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel11.ColumnCount = 3;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel11.Controls.Add(textBox11, 2, 0);
            tableLayoutPanel11.Controls.Add(textBox12, 2, 1);
            tableLayoutPanel11.Controls.Add(textBox13, 2, 2);
            tableLayoutPanel11.Controls.Add(textBox14, 2, 3);
            tableLayoutPanel11.Controls.Add(label15, 1, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 1, 1);
            tableLayoutPanel11.Controls.Add(label18, 1, 3);
            tableLayoutPanel11.Controls.Add(label17, 1, 2);
            tableLayoutPanel11.Controls.Add(label19, 1, 4);
            tableLayoutPanel11.Controls.Add(textBox15, 2, 4);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel11.Controls.Add(label20, 0, 4);
            tableLayoutPanel11.Location = new Point(6, 609);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 5;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.Size = new Size(1153, 174);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox11.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(1039, 4);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(110, 26);
            textBox11.TabIndex = 0;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox12.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(1039, 38);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(110, 26);
            textBox12.TabIndex = 1;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox13.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(1039, 72);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(110, 26);
            textBox13.TabIndex = 2;
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox14.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(1039, 106);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(110, 26);
            textBox14.TabIndex = 3;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.WindowText;
            label15.Location = new Point(866, 8);
            label15.Name = "label15";
            label15.Size = new Size(166, 18);
            label15.TabIndex = 4;
            label15.Text = "รวมเป็นเงิน";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel12.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel12.Controls.Add(numericUpDown1, 1, 0);
            tableLayoutPanel12.Controls.Add(label16, 2, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(863, 35);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(172, 33);
            tableLayoutPanel12.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.WindowText;
            checkBox1.Location = new Point(16, 5);
            checkBox1.Margin = new Padding(3, 3, 0, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 22);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "ส่วนลด";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(89, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 26);
            numericUpDown1.TabIndex = 1;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.WindowText;
            label16.Location = new Point(140, 7);
            label16.Name = "label16";
            label16.Size = new Size(29, 18);
            label16.TabIndex = 2;
            label16.Text = "%";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.WindowText;
            label18.Location = new Point(866, 110);
            label18.Name = "label18";
            label18.Size = new Size(166, 18);
            label18.TabIndex = 7;
            label18.Text = "ภาษีมูลค่าเพิ่ม 7 %";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.WindowText;
            label17.Location = new Point(866, 76);
            label17.Name = "label17";
            label17.Size = new Size(166, 18);
            label17.TabIndex = 8;
            label17.Text = "จำนวนเงินหลังหักส่วนลด";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.WindowText;
            label19.Location = new Point(866, 146);
            label19.Name = "label19";
            label19.Size = new Size(166, 18);
            label19.TabIndex = 9;
            label19.Text = "จำนวนเงินทั้งสิน";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox15.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox15.Location = new Point(1039, 142);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(110, 26);
            textBox15.TabIndex = 3;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(1, 1);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel11.SetRowSpan(tableLayoutPanel13, 4);
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(861, 135);
            tableLayoutPanel13.TabIndex = 10;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.WindowText;
            label20.Location = new Point(4, 146);
            label20.Name = "label20";
            label20.Size = new Size(855, 18);
            label20.TabIndex = 11;
            label20.Text = "(ตัวหนังสือ)";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { number, detail, quantity, unit, PricePerUnit, AmountPrice });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Crimson;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1153, 578);
            dataGridView1.TabIndex = 2;
            // 
            // number
            // 
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            number.DefaultCellStyle = dataGridViewCellStyle2;
            number.FillWeight = 50F;
            number.HeaderText = "ที่";
            number.Name = "number";
            number.ReadOnly = true;
            number.Width = 30;
            // 
            // detail
            // 
            dataGridViewCellStyle3.ForeColor = Color.ForestGreen;
            detail.DefaultCellStyle = dataGridViewCellStyle3;
            detail.FillWeight = 650F;
            detail.HeaderText = "รายละเอียด";
            detail.Name = "detail";
            detail.Width = 650;
            // 
            // quantity
            // 
            dataGridViewCellStyle4.ForeColor = Color.ForestGreen;
            quantity.DefaultCellStyle = dataGridViewCellStyle4;
            quantity.HeaderText = "จำนวน";
            quantity.Name = "quantity";
            // 
            // unit
            // 
            dataGridViewCellStyle5.ForeColor = Color.ForestGreen;
            unit.DefaultCellStyle = dataGridViewCellStyle5;
            unit.HeaderText = "หน่วย";
            unit.Name = "unit";
            // 
            // PricePerUnit
            // 
            dataGridViewCellStyle6.ForeColor = Color.ForestGreen;
            PricePerUnit.DefaultCellStyle = dataGridViewCellStyle6;
            PricePerUnit.HeaderText = "ราคา/หน่วย";
            PricePerUnit.Name = "PricePerUnit";
            // 
            // AmountPrice
            // 
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.ForeColor = Color.ForestGreen;
            AmountPrice.DefaultCellStyle = dataGridViewCellStyle7;
            AmountPrice.HeaderText = "จำนวนเงิน";
            AmountPrice.Name = "AmountPrice";
            AmountPrice.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel10);
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Controls.Add(tableLayoutPanel9);
            groupBox3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Green;
            groupBox3.Location = new Point(866, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 245);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "เลขที่/วันที่ใบเสนอราคา";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel10.Location = new Point(6, 165);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.Size = new Size(295, 70);
            tableLayoutPanel10.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(dateTimePicker2, 0, 1);
            tableLayoutPanel8.Controls.Add(label14, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Margin = new Padding(1);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(289, 63);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(3, 34);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(283, 26);
            dateTimePicker2.TabIndex = 6;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.WindowText;
            label14.Location = new Point(3, 13);
            label14.Name = "label14";
            label14.Size = new Size(283, 18);
            label14.TabIndex = 0;
            label14.Text = "วันหมดอายุ";
            label14.TextAlign = ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Location = new Point(6, 25);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(295, 70);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label12, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox7, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 4);
            tableLayoutPanel6.Margin = new Padding(1);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(289, 61);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.WindowText;
            label12.Location = new Point(3, 12);
            label12.Name = "label12";
            label12.Size = new Size(283, 18);
            label12.TabIndex = 0;
            label12.Text = "เลขที่ใบเสนอราคา";
            label12.TextAlign = ContentAlignment.BottomRight;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(3, 33);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(283, 26);
            textBox7.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel9.Location = new Point(6, 95);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Size = new Size(295, 70);
            tableLayoutPanel9.TabIndex = 6;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label13, 0, 0);
            tableLayoutPanel7.Controls.Add(dateTimePicker1, 0, 1);
            tableLayoutPanel7.Location = new Point(3, 4);
            tableLayoutPanel7.Margin = new Padding(1);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(289, 61);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.WindowText;
            label13.Location = new Point(3, 12);
            label13.Name = "label13";
            label13.Size = new Size(283, 18);
            label13.TabIndex = 0;
            label13.Text = "วันที่ออกใบเสนอราคา";
            label13.TextAlign = ContentAlignment.BottomRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(3, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 26);
            dateTimePicker1.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Purple;
            groupBox2.Location = new Point(8, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(852, 174);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ชื่อ/ที่อยู่ลูกค้า";
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(741, 138);
            button4.Name = "button4";
            button4.Size = new Size(105, 30);
            button4.TabIndex = 7;
            button4.Text = "ลบ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(630, 138);
            button3.Name = "button3";
            button3.Size = new Size(105, 30);
            button3.TabIndex = 6;
            button3.Text = "เพิ่ม";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label8, 2, 2);
            tableLayoutPanel4.Controls.Add(label9, 0, 0);
            tableLayoutPanel4.Controls.Add(label10, 0, 1);
            tableLayoutPanel4.Controls.Add(textBox8, 1, 1);
            tableLayoutPanel4.Controls.Add(label11, 0, 2);
            tableLayoutPanel4.Controls.Add(textBox9, 1, 2);
            tableLayoutPanel4.Controls.Add(textBox10, 3, 2);
            tableLayoutPanel4.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel4.Location = new Point(6, 25);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(840, 110);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(429, 81);
            label8.Name = "label8";
            label8.Size = new Size(144, 18);
            label8.TabIndex = 7;
            label8.Text = "เบอร์โทรศัพท์:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(5, 9);
            label9.Name = "label9";
            label9.Size = new Size(154, 18);
            label9.TabIndex = 5;
            label9.Text = "ชื่อลูกค้า:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(5, 45);
            label10.Name = "label10";
            label10.Size = new Size(154, 18);
            label10.TabIndex = 6;
            label10.Text = "ที่อยู่:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.SetColumnSpan(textBox8, 3);
            textBox8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Blue;
            textBox8.Location = new Point(167, 41);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(668, 26);
            textBox8.TabIndex = 14;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.WindowText;
            label11.Location = new Point(5, 81);
            label11.Name = "label11";
            label11.Size = new Size(154, 18);
            label11.TabIndex = 11;
            label11.Text = "เลขประจำตัวผู้เสียภาษี:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = Color.Blue;
            textBox9.Location = new Point(167, 77);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(254, 26);
            textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox10.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.ForeColor = Color.Blue;
            textBox10.Location = new Point(581, 77);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(254, 26);
            textBox10.TabIndex = 15;
            // 
            // comboBox1
            // 
            tableLayoutPanel4.SetColumnSpan(comboBox1, 3);
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(668, 26);
            comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(1358, 212);
            button2.Name = "button2";
            button2.Size = new Size(103, 30);
            button2.TabIndex = 2;
            button2.Text = "แก้ไข";
            button2.UseVisualStyleBackColor = true;
            // 
            // CompanyDetailGroupBox
            // 
            CompanyDetailGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CompanyDetailGroupBox.Controls.Add(tableLayoutPanel1);
            CompanyDetailGroupBox.Controls.Add(CompanyNameEditButton);
            CompanyDetailGroupBox.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CompanyDetailGroupBox.ForeColor = Color.Blue;
            CompanyDetailGroupBox.Location = new Point(8, 6);
            CompanyDetailGroupBox.Name = "CompanyDetailGroupBox";
            CompanyDetailGroupBox.Size = new Size(852, 174);
            CompanyDetailGroupBox.TabIndex = 3;
            CompanyDetailGroupBox.TabStop = false;
            CompanyDetailGroupBox.Text = "ชื่อ/ที่อยู่บริษัท";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 2);
            tableLayoutPanel1.Location = new Point(6, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(840, 107);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(429, 79);
            label4.Name = "label4";
            label4.Size = new Size(144, 18);
            label4.TabIndex = 7;
            label4.Text = "เบอร์โทรศัพท์:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(5, 9);
            label2.Name = "label2";
            label2.Size = new Size(154, 18);
            label2.TabIndex = 5;
            label2.Text = "ชื่อบริษัท:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox1, 3);
            textBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(167, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(668, 26);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(5, 43);
            label3.Name = "label3";
            label3.Size = new Size(154, 18);
            label3.TabIndex = 6;
            label3.Text = "ที่อยู่:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox3, 3);
            textBox3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Blue;
            textBox3.Location = new Point(167, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(668, 26);
            textBox3.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(5, 79);
            label5.Name = "label5";
            label5.Size = new Size(154, 18);
            label5.TabIndex = 11;
            label5.Text = "เลขประจำตัวผู้เสียภาษี:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Blue;
            textBox2.Location = new Point(167, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 26);
            textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Blue;
            textBox4.Location = new Point(581, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 26);
            textBox4.TabIndex = 15;
            // 
            // CompanyNameEditButton
            // 
            CompanyNameEditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CompanyNameEditButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNameEditButton.ForeColor = SystemColors.WindowText;
            CompanyNameEditButton.Location = new Point(741, 137);
            CompanyNameEditButton.Name = "CompanyNameEditButton";
            CompanyNameEditButton.Size = new Size(105, 30);
            CompanyNameEditButton.TabIndex = 2;
            CompanyNameEditButton.Text = "แก้ไข";
            CompanyNameEditButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 232, 74);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 8);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(251, 39);
            label1.TabIndex = 0;
            label1.Text = "สร้างใบเสนอราคา";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            // CreateQuotationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 1261);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateQuotationForm";
            Text = "Create Quotation";
            Load += CreateQuotationForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            CompanyDetailGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Button CompanyNameEditButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private GroupBox CompanyDetailGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox6;
        private Label label7;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox8;
        private Label label11;
        private TextBox textBox9;
        private TextBox textBox10;
        private ComboBox comboBox1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label12;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel9;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button CreateQuotationCancelButton;
        private Button button5;
        private Button button7;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel12;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label19;
        private TextBox textBox15;
        private TableLayoutPanel tableLayoutPanel13;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn detail;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn PricePerUnit;
        private DataGridViewTextBoxColumn AmountPrice;
        private Label label20;
    }
}