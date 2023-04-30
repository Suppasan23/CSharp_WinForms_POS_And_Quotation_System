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
            M_MenuStrip = new MenuStrip();
            M_FileToolStripMenuItem = new ToolStripMenuItem();
            M_ExitToolStripMenuItem = new ToolStripMenuItem();
            M_HelpToolStripMenuItem = new ToolStripMenuItem();
            M_StatusStrip = new StatusStrip();
            M_ToolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            M_ProductManagementToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            M_PointOfSaleToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            M_CreateQuotationToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            M_ArchiveQuotationToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            M_ExitToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            M_MenuStrip.SuspendLayout();
            M_StatusStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // M_MenuStrip
            // 
            M_MenuStrip.Items.AddRange(new ToolStripItem[] { M_FileToolStripMenuItem, M_HelpToolStripMenuItem });
            M_MenuStrip.Location = new Point(0, 0);
            M_MenuStrip.Name = "M_MenuStrip";
            M_MenuStrip.Padding = new Padding(7, 2, 0, 2);
            M_MenuStrip.Size = new Size(1784, 24);
            M_MenuStrip.TabIndex = 1;
            M_MenuStrip.Text = "menuStrip1";
            // 
            // M_FileToolStripMenuItem
            // 
            M_FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { M_ExitToolStripMenuItem });
            M_FileToolStripMenuItem.Name = "M_FileToolStripMenuItem";
            M_FileToolStripMenuItem.Size = new Size(37, 20);
            M_FileToolStripMenuItem.Text = "File";
            // 
            // M_ExitToolStripMenuItem
            // 
            M_ExitToolStripMenuItem.Name = "M_ExitToolStripMenuItem";
            M_ExitToolStripMenuItem.Size = new Size(93, 22);
            M_ExitToolStripMenuItem.Text = "Exit";
            M_ExitToolStripMenuItem.Click += M_ExitToolStripMenuItem_Click;
            // 
            // M_HelpToolStripMenuItem
            // 
            M_HelpToolStripMenuItem.Name = "M_HelpToolStripMenuItem";
            M_HelpToolStripMenuItem.Size = new Size(44, 20);
            M_HelpToolStripMenuItem.Text = "Help";
            // 
            // M_StatusStrip
            // 
            M_StatusStrip.Items.AddRange(new ToolStripItem[] { M_ToolStripStatusLabel });
            M_StatusStrip.Location = new Point(0, 1139);
            M_StatusStrip.Name = "M_StatusStrip";
            M_StatusStrip.Padding = new Padding(1, 0, 16, 0);
            M_StatusStrip.Size = new Size(1784, 22);
            M_StatusStrip.TabIndex = 2;
            M_StatusStrip.Text = "statusStrip1";
            // 
            // M_ToolStripStatusLabel
            // 
            M_ToolStripStatusLabel.Name = "M_ToolStripStatusLabel";
            M_ToolStripStatusLabel.Size = new Size(39, 17);
            M_ToolStripStatusLabel.Text = "Status";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Items.AddRange(new ToolStripItem[] { M_ProductManagementToolStripButton, toolStripSeparator1, M_PointOfSaleToolStripButton, toolStripSeparator2, M_CreateQuotationToolStripButton, toolStripSeparator3, M_ArchiveQuotationToolStripButton, toolStripSeparator4, M_ExitToolStripButton, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(137, 1115);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // M_ProductManagementToolStripButton
            // 
            M_ProductManagementToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M_ProductManagementToolStripButton.Image = Properties.Resources.warehouse_110;
            M_ProductManagementToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            M_ProductManagementToolStripButton.ImageTransparentColor = Color.Magenta;
            M_ProductManagementToolStripButton.Margin = new Padding(3, 0, 0, 0);
            M_ProductManagementToolStripButton.Name = "M_ProductManagementToolStripButton";
            M_ProductManagementToolStripButton.Size = new Size(131, 133);
            M_ProductManagementToolStripButton.Text = "จัดการสินค้า";
            M_ProductManagementToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            M_ProductManagementToolStripButton.Click += M_ProductManagementToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(134, 6);
            // 
            // M_PointOfSaleToolStripButton
            // 
            M_PointOfSaleToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M_PointOfSaleToolStripButton.Image = Properties.Resources.exchange_110;
            M_PointOfSaleToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            M_PointOfSaleToolStripButton.ImageTransparentColor = Color.Magenta;
            M_PointOfSaleToolStripButton.Margin = new Padding(3, 0, 0, 0);
            M_PointOfSaleToolStripButton.Name = "M_PointOfSaleToolStripButton";
            M_PointOfSaleToolStripButton.Size = new Size(131, 133);
            M_PointOfSaleToolStripButton.Text = "ขายสินค้า";
            M_PointOfSaleToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            M_PointOfSaleToolStripButton.Click += M_PointOfSaleToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(134, 6);
            // 
            // M_CreateQuotationToolStripButton
            // 
            M_CreateQuotationToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M_CreateQuotationToolStripButton.Image = Properties.Resources.create_file_110;
            M_CreateQuotationToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            M_CreateQuotationToolStripButton.ImageTransparentColor = Color.Magenta;
            M_CreateQuotationToolStripButton.Margin = new Padding(3, 0, 0, 0);
            M_CreateQuotationToolStripButton.Name = "M_CreateQuotationToolStripButton";
            M_CreateQuotationToolStripButton.Size = new Size(131, 133);
            M_CreateQuotationToolStripButton.Text = "สร้างใบเสนอราคา";
            M_CreateQuotationToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            M_CreateQuotationToolStripButton.Click += M_CreateQuotationToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(134, 6);
            // 
            // M_ArchiveQuotationToolStripButton
            // 
            M_ArchiveQuotationToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M_ArchiveQuotationToolStripButton.Image = Properties.Resources.cabinet_110;
            M_ArchiveQuotationToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            M_ArchiveQuotationToolStripButton.ImageTransparentColor = Color.Magenta;
            M_ArchiveQuotationToolStripButton.Margin = new Padding(3, 0, 0, 0);
            M_ArchiveQuotationToolStripButton.Name = "M_ArchiveQuotationToolStripButton";
            M_ArchiveQuotationToolStripButton.Size = new Size(131, 133);
            M_ArchiveQuotationToolStripButton.Text = "ที่เก็บใบเสนอราคา";
            M_ArchiveQuotationToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            M_ArchiveQuotationToolStripButton.Click += M_ArchiveQuotationToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(134, 6);
            // 
            // M_ExitToolStripButton
            // 
            M_ExitToolStripButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            M_ExitToolStripButton.Image = Properties.Resources.shutdown_110;
            M_ExitToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            M_ExitToolStripButton.ImageTransparentColor = Color.Magenta;
            M_ExitToolStripButton.Margin = new Padding(3, 0, 0, 0);
            M_ExitToolStripButton.Name = "M_ExitToolStripButton";
            M_ExitToolStripButton.Size = new Size(131, 133);
            M_ExitToolStripButton.Text = "ออก";
            M_ExitToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            M_ExitToolStripButton.Click += M_ExitToolStripButton_Click;
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
            BackColor = SystemColors.Control;
            ClientSize = new Size(1784, 1161);
            Controls.Add(toolStrip1);
            Controls.Add(M_StatusStrip);
            Controls.Add(M_MenuStrip);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = M_MenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ร้านธีรภัทร์";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            M_MenuStrip.ResumeLayout(false);
            M_MenuStrip.PerformLayout();
            M_StatusStrip.ResumeLayout(false);
            M_StatusStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip M_MenuStrip;
        private ToolStripMenuItem M_FileToolStripMenuItem;
        private ToolStripMenuItem M_ExitToolStripMenuItem;
        private ToolStripMenuItem M_HelpToolStripMenuItem;
        private StatusStrip M_StatusStrip;
        private ToolStrip toolStrip1;
        private ToolStripButton M_ProductManagementToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton M_PointOfSaleToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton M_CreateQuotationToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton M_ArchiveQuotationToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton M_ExitToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripStatusLabel M_ToolStripStatusLabel;
    }
}