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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.profilesGroupBox = new System.Windows.Forms.GroupBox();
            this.profilesComboBox = new System.Windows.Forms.ComboBox();
            this.activeProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.activatedProfileLabel = new System.Windows.Forms.Label();
            this.displayUtilityNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.activateButton = new System.Windows.Forms.Button();
            this.newProfileButton = new System.Windows.Forms.Button();
            this.profilesGroupBox.SuspendLayout();
            this.activeProfileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilesGroupBox
            // 
            this.profilesGroupBox.Controls.Add(this.profilesComboBox);
            this.profilesGroupBox.Location = new System.Drawing.Point(12, 74);
            this.profilesGroupBox.Name = "profilesGroupBox";
            this.profilesGroupBox.Size = new System.Drawing.Size(260, 54);
            this.profilesGroupBox.TabIndex = 1;
            this.profilesGroupBox.TabStop = false;
            this.profilesGroupBox.Text = "Profiles";
            // 
            // profilesComboBox
            // 
            this.profilesComboBox.FormattingEnabled = true;
            this.profilesComboBox.Location = new System.Drawing.Point(7, 20);
            this.profilesComboBox.Name = "profilesComboBox";
            this.profilesComboBox.Size = new System.Drawing.Size(247, 21);
            this.profilesComboBox.TabIndex = 0;
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
            // activatedProfileLabel
            // 
            this.activatedProfileLabel.AutoSize = true;
            this.activatedProfileLabel.Location = new System.Drawing.Point(7, 20);
            this.activatedProfileLabel.Name = "activatedProfileLabel";
            this.activatedProfileLabel.Size = new System.Drawing.Size(84, 13);
            this.activatedProfileLabel.TabIndex = 0;
            this.activatedProfileLabel.Text = "Activated Profile";
            // 
            // displayUtilityNotifyIcon
            // 
            this.displayUtilityNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("displayUtilityNotifyIcon.Icon")));
            this.displayUtilityNotifyIcon.Text = "Display Utility";
            this.displayUtilityNotifyIcon.Visible = true;
            this.displayUtilityNotifyIcon.DoubleClick += new System.EventHandler(this.displayUtilityNotifyIcon_DoubleClick);
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(197, 226);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(75, 23);
            this.activateButton.TabIndex = 3;
            this.activateButton.Text = "&Activate";
            this.activateButton.UseVisualStyleBackColor = true;
            // 
            // newProfileButton
            // 
            this.newProfileButton.Location = new System.Drawing.Point(12, 226);
            this.newProfileButton.Name = "newProfileButton";
            this.newProfileButton.Size = new System.Drawing.Size(75, 23);
            this.newProfileButton.TabIndex = 4;
            this.newProfileButton.Text = "&New";
            this.newProfileButton.UseVisualStyleBackColor = true;
            this.newProfileButton.Click += new System.EventHandler(this.newProfileButton_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.activateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.newProfileButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.activeProfileGroupBox);
            this.Controls.Add(this.profilesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Utility";
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.profilesGroupBox.ResumeLayout(false);
            this.activeProfileGroupBox.ResumeLayout(false);
            this.activeProfileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox profilesGroupBox;
        private System.Windows.Forms.GroupBox activeProfileGroupBox;
        private System.Windows.Forms.ComboBox profilesComboBox;
        private System.Windows.Forms.Label activatedProfileLabel;
        private System.Windows.Forms.NotifyIcon displayUtilityNotifyIcon;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Button newProfileButton;
    }
}