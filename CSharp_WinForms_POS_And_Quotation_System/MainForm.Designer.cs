namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            MainFormStatusToolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            ProductManagementToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            PointOfSaleToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            CreateQuotationToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ArchiveQuotationToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            ExitToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { MainFormStatusToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 1139);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1784, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainFormStatusToolStripStatusLabel
            // 
            MainFormStatusToolStripStatusLabel.Name = "MainFormStatusToolStripStatusLabel";
            MainFormStatusToolStripStatusLabel.Size = new Size(39, 17);
            MainFormStatusToolStripStatusLabel.Text = "Status";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Items.AddRange(new ToolStripItem[] { ProductManagementToolStripButton, toolStripSeparator1, PointOfSaleToolStripButton, toolStripSeparator2, CreateQuotationToolStripButton, toolStripSeparator3, ArchiveQuotationToolStripButton, toolStripSeparator4, ExitToolStripButton, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(137, 1115);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // ProductManagementToolStripButton
            // 
            ProductManagementToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductManagementToolStripButton.Image = Properties.Resources.warehouse_110;
            ProductManagementToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            ProductManagementToolStripButton.ImageTransparentColor = Color.Magenta;
            ProductManagementToolStripButton.Margin = new Padding(3, 0, 0, 0);
            ProductManagementToolStripButton.Name = "ProductManagementToolStripButton";
            ProductManagementToolStripButton.Size = new Size(131, 133);
            ProductManagementToolStripButton.Text = "จัดการสินค้า";
            ProductManagementToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(134, 6);
            // 
            // PointOfSaleToolStripButton
            // 
            PointOfSaleToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PointOfSaleToolStripButton.Image = Properties.Resources.exchange_110;
            PointOfSaleToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            PointOfSaleToolStripButton.ImageTransparentColor = Color.Magenta;
            PointOfSaleToolStripButton.Margin = new Padding(3, 0, 0, 0);
            PointOfSaleToolStripButton.Name = "PointOfSaleToolStripButton";
            PointOfSaleToolStripButton.Size = new Size(131, 133);
            PointOfSaleToolStripButton.Text = "ขายสินค้า";
            PointOfSaleToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(134, 6);
            // 
            // CreateQuotationToolStripButton
            // 
            CreateQuotationToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateQuotationToolStripButton.Image = Properties.Resources.create_file_110;
            CreateQuotationToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            CreateQuotationToolStripButton.ImageTransparentColor = Color.Magenta;
            CreateQuotationToolStripButton.Margin = new Padding(3, 0, 0, 0);
            CreateQuotationToolStripButton.Name = "CreateQuotationToolStripButton";
            CreateQuotationToolStripButton.Size = new Size(131, 133);
            CreateQuotationToolStripButton.Text = "สร้างใบเสนอราคา";
            CreateQuotationToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(134, 6);
            // 
            // ArchiveQuotationToolStripButton
            // 
            ArchiveQuotationToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveQuotationToolStripButton.Image = Properties.Resources.cabinet_110;
            ArchiveQuotationToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            ArchiveQuotationToolStripButton.ImageTransparentColor = Color.Magenta;
            ArchiveQuotationToolStripButton.Margin = new Padding(3, 0, 0, 0);
            ArchiveQuotationToolStripButton.Name = "ArchiveQuotationToolStripButton";
            ArchiveQuotationToolStripButton.Size = new Size(131, 133);
            ArchiveQuotationToolStripButton.Text = "ที่เก็บใบเสนอราคา";
            ArchiveQuotationToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(134, 6);
            // 
            // ExitToolStripButton
            // 
            ExitToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitToolStripButton.Image = Properties.Resources.shutdown_110;
            ExitToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            ExitToolStripButton.ImageTransparentColor = Color.Magenta;
            ExitToolStripButton.Margin = new Padding(3, 0, 0, 0);
            ExitToolStripButton.Name = "ExitToolStripButton";
            ExitToolStripButton.Size = new Size(131, 133);
            ExitToolStripButton.Text = "ออก";
            ExitToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ExitToolStripButton.Click += ExitToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(134, 6);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 1161);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ร้านธีรภัทร์";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel MainFormStatusToolStripStatusLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton ProductManagementToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton PointOfSaleToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton CreateQuotationToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ArchiveQuotationToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton ExitToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
    }
}