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
            panel1 = new Panel();
            AQ_Panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            button3 = new Button();
            AQ_Panel1 = new Panel();
            AQ_HeadingLabel = new Label();
            panel1.SuspendLayout();
            AQ_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
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
            panel1.Size = new Size(1184, 1261);
            panel1.TabIndex = 0;
            // 
            // AQ_Panel2
            // 
            AQ_Panel2.BackColor = Color.FromArgb(251, 240, 240);
            AQ_Panel2.Controls.Add(splitContainer1);
            AQ_Panel2.Dock = DockStyle.Fill;
            AQ_Panel2.Location = new Point(0, 60);
            AQ_Panel2.Margin = new Padding(3, 2, 3, 2);
            AQ_Panel2.Name = "AQ_Panel2";
            AQ_Panel2.Size = new Size(1182, 1199);
            AQ_Panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Location = new Point(6, 10);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1170, 1178);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.SplitterIncrement = 2;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 4;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1168, 198);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 8);
            label2.Name = "label2";
            label2.Size = new Size(1160, 21);
            label2.TabIndex = 3;
            label2.Text = "ใบเสนอราคารอดำเนินการ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel4.Controls.Add(dataGridView2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1, 37);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1166, 160);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Margin = new Padding(3, 3, 0, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1091, 154);
            dataGridView2.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button2, 0, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new Point(1096, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Size = new Size(68, 130);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Image = Properties.Resources.delete_16;
            button2.Location = new Point(0, 65);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(68, 65);
            button2.TabIndex = 6;
            button2.Text = "ทิ้ง";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Image = Properties.Resources.download_16;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(68, 65);
            button1.TabIndex = 0;
            button1.Text = "เก็บถาวร";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1168, 966);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.SlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1160, 922);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel5.Controls.Add(label1, 1, 0);
            tableLayoutPanel5.Controls.Add(button3, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(1, 1);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1166, 35);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 7);
            label1.Name = "label1";
            label1.Size = new Size(700, 21);
            label1.TabIndex = 1;
            label1.Text = "ใบเสนอราคาเก็บถาวร";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.download_blue_16_;
            button3.Location = new Point(959, 1);
            button3.Margin = new Padding(0, 0, 2, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(5, 0, 0, 0);
            button3.Size = new Size(205, 32);
            button3.TabIndex = 5;
            button3.Text = "เก็บใบเสนอราคาจากภายนอก";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // AQ_Panel1
            // 
            AQ_Panel1.BackColor = Color.FromArgb(219, 138, 138);
            AQ_Panel1.Controls.Add(AQ_HeadingLabel);
            AQ_Panel1.Dock = DockStyle.Top;
            AQ_Panel1.Location = new Point(0, 0);
            AQ_Panel1.Margin = new Padding(3, 2, 3, 2);
            AQ_Panel1.Name = "AQ_Panel1";
            AQ_Panel1.Size = new Size(1182, 60);
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
            ClientSize = new Size(1184, 1261);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ArchiveQuotationForm";
            Text = "Archive Quotation";
            Load += ArchiveQuotationForm_Load;
            panel1.ResumeLayout(false);
            AQ_Panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            AQ_Panel1.ResumeLayout(false);
            AQ_Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel AQ_Panel2;
        private Panel AQ_Panel1;
        private Label AQ_HeadingLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer1;
        private Button button2;
        private DataGridView dataGridView2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
    }
}