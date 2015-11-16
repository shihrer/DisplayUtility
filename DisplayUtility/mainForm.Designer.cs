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
            this.selectProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.activeProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.profilesComboBox = new System.Windows.Forms.ComboBox();
            this.activatedProfileLabel = new System.Windows.Forms.Label();
            this.selectProfileGroupBox.SuspendLayout();
            this.activeProfileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectProfileGroupBox
            // 
            this.selectProfileGroupBox.Controls.Add(this.profilesComboBox);
            this.selectProfileGroupBox.Location = new System.Drawing.Point(12, 74);
            this.selectProfileGroupBox.Name = "selectProfileGroupBox";
            this.selectProfileGroupBox.Size = new System.Drawing.Size(260, 54);
            this.selectProfileGroupBox.TabIndex = 1;
            this.selectProfileGroupBox.TabStop = false;
            this.selectProfileGroupBox.Text = "Select Profile";
            // 
            // activeProfileGroupBox
            // 
            this.activeProfileGroupBox.Controls.Add(this.activatedProfileLabel);
            this.activeProfileGroupBox.Location = new System.Drawing.Point(12, 13);
            this.activeProfileGroupBox.Name = "activeProfileGroupBox";
            this.activeProfileGroupBox.Size = new System.Drawing.Size(260, 55);
            this.activeProfileGroupBox.TabIndex = 2;
            this.activeProfileGroupBox.TabStop = false;
            this.activeProfileGroupBox.Text = "Active Profile";
            // 
            // profilesComboBox
            // 
            this.profilesComboBox.FormattingEnabled = true;
            this.profilesComboBox.Location = new System.Drawing.Point(7, 20);
            this.profilesComboBox.Name = "profilesComboBox";
            this.profilesComboBox.Size = new System.Drawing.Size(247, 21);
            this.profilesComboBox.TabIndex = 0;
            // 
            // activatedProfileLabel
            // 
            this.activatedProfileLabel.AutoSize = true;
            this.activatedProfileLabel.Location = new System.Drawing.Point(7, 20);
            this.activatedProfileLabel.Name = "activatedProfileLabel";
            this.activatedProfileLabel.Size = new System.Drawing.Size(84, 13);
            this.activatedProfileLabel.TabIndex = 0;
            this.activatedProfileLabel.Text = "Activated Profile";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.activeProfileGroupBox);
            this.Controls.Add(this.selectProfileGroupBox);
            this.Name = "mainForm";
            this.Text = "Display Utility";
            this.selectProfileGroupBox.ResumeLayout(false);
            this.activeProfileGroupBox.ResumeLayout(false);
            this.activeProfileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectProfileGroupBox;
        private System.Windows.Forms.GroupBox activeProfileGroupBox;
        private System.Windows.Forms.ComboBox profilesComboBox;
        private System.Windows.Forms.Label activatedProfileLabel;
    }
}