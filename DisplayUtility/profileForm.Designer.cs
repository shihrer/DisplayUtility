﻿namespace DisplayUtility
{
    partial class profileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            this.displaysGroupBox = new System.Windows.Forms.GroupBox();
            this.primaryDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.primaryDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.availableDisplaysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.displaysGroupBox.SuspendLayout();
            this.primaryDisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaysGroupBox
            // 
            this.displaysGroupBox.Controls.Add(this.availableDisplaysCheckedListBox);
            this.displaysGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.displaysGroupBox.Location = new System.Drawing.Point(0, 0);
            this.displaysGroupBox.Name = "displaysGroupBox";
            this.displaysGroupBox.Size = new System.Drawing.Size(284, 100);
            this.displaysGroupBox.TabIndex = 0;
            this.displaysGroupBox.TabStop = false;
            this.displaysGroupBox.Text = "Displays";
            // 
            // primaryDisplayGroupBox
            // 
            this.primaryDisplayGroupBox.Controls.Add(this.primaryDisplayComboBox);
            this.primaryDisplayGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.primaryDisplayGroupBox.Location = new System.Drawing.Point(0, 100);
            this.primaryDisplayGroupBox.Name = "primaryDisplayGroupBox";
            this.primaryDisplayGroupBox.Size = new System.Drawing.Size(284, 55);
            this.primaryDisplayGroupBox.TabIndex = 1;
            this.primaryDisplayGroupBox.TabStop = false;
            this.primaryDisplayGroupBox.Text = "Primary Display";
            // 
            // primaryDisplayComboBox
            // 
            this.primaryDisplayComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryDisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primaryDisplayComboBox.FormattingEnabled = true;
            this.primaryDisplayComboBox.Location = new System.Drawing.Point(3, 16);
            this.primaryDisplayComboBox.Name = "primaryDisplayComboBox";
            this.primaryDisplayComboBox.Size = new System.Drawing.Size(278, 21);
            this.primaryDisplayComboBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(116, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // availableDisplaysCheckedListBox
            // 
            this.availableDisplaysCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableDisplaysCheckedListBox.FormattingEnabled = true;
            this.availableDisplaysCheckedListBox.Location = new System.Drawing.Point(3, 16);
            this.availableDisplaysCheckedListBox.Name = "availableDisplaysCheckedListBox";
            this.availableDisplaysCheckedListBox.Size = new System.Drawing.Size(278, 81);
            this.availableDisplaysCheckedListBox.TabIndex = 0;
            // 
            // profileForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.primaryDisplayGroupBox);
            this.Controls.Add(this.displaysGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "profileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Profile";
            this.Load += new System.EventHandler(this.profileForm_Load);
            this.displaysGroupBox.ResumeLayout(false);
            this.primaryDisplayGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox displaysGroupBox;
        private System.Windows.Forms.GroupBox primaryDisplayGroupBox;
        private System.Windows.Forms.ComboBox primaryDisplayComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckedListBox availableDisplaysCheckedListBox;
    }
}

