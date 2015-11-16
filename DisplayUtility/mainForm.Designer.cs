namespace DisplayUtility
{
    partial class mainForm
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
            this.displaysGroupBox = new System.Windows.Forms.GroupBox();
            this.primaryDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.primaryDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.primaryDisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaysGroupBox
            // 
            this.displaysGroupBox.Location = new System.Drawing.Point(12, 12);
            this.displaysGroupBox.Name = "displaysGroupBox";
            this.displaysGroupBox.Size = new System.Drawing.Size(260, 100);
            this.displaysGroupBox.TabIndex = 0;
            this.displaysGroupBox.TabStop = false;
            this.displaysGroupBox.Text = "Displays";
            // 
            // primaryDisplayGroupBox
            // 
            this.primaryDisplayGroupBox.Controls.Add(this.primaryDisplayComboBox);
            this.primaryDisplayGroupBox.Location = new System.Drawing.Point(12, 119);
            this.primaryDisplayGroupBox.Name = "primaryDisplayGroupBox";
            this.primaryDisplayGroupBox.Size = new System.Drawing.Size(260, 55);
            this.primaryDisplayGroupBox.TabIndex = 1;
            this.primaryDisplayGroupBox.TabStop = false;
            this.primaryDisplayGroupBox.Text = "Primary Display";
            // 
            // primaryDisplayComboBox
            // 
            this.primaryDisplayComboBox.FormattingEnabled = true;
            this.primaryDisplayComboBox.Location = new System.Drawing.Point(7, 20);
            this.primaryDisplayComboBox.Name = "primaryDisplayComboBox";
            this.primaryDisplayComboBox.Size = new System.Drawing.Size(247, 21);
            this.primaryDisplayComboBox.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.primaryDisplayGroupBox);
            this.Controls.Add(this.displaysGroupBox);
            this.Name = "mainForm";
            this.Text = "Display Utility";
            this.primaryDisplayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox displaysGroupBox;
        private System.Windows.Forms.GroupBox primaryDisplayGroupBox;
        private System.Windows.Forms.ComboBox primaryDisplayComboBox;
    }
}

