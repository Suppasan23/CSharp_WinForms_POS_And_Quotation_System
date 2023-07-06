namespace CSharp_WinForms_POS_And_Quotation_System
{
    partial class dummyForm
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
            Dummy_CloseButton = new Button();
            SuspendLayout();
            // 
            // Dummy_CloseButton
            // 
            Dummy_CloseButton.Location = new Point(22, 8);
            Dummy_CloseButton.Name = "Dummy_CloseButton";
            Dummy_CloseButton.Size = new Size(75, 23);
            Dummy_CloseButton.TabIndex = 0;
            Dummy_CloseButton.Text = "close";
            Dummy_CloseButton.UseVisualStyleBackColor = true;
            Dummy_CloseButton.Click += Dummy_CloseButton_Click;
            // 
            // dummyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(120, 39);
            Controls.Add(Dummy_CloseButton);
            Name = "dummyForm";
            Text = "dummyForm";
            Load += dummyForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Dummy_CloseButton;
    }
}