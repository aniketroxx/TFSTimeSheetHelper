﻿namespace TfsTimeSheetHelper
{
    partial class TfsTimeSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TfsTimeSheetForm));
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.TfsURIBox = new System.Windows.Forms.TextBox();
            this.btnGenCSV = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTFSUrl = new System.Windows.Forms.Label();
            this.chkBoxDeveloperEst = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(12, 41);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(521, 22);
            this.UserNameBox.TabIndex = 0;
            this.UserNameBox.UseWaitCursor = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 102);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(521, 22);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseWaitCursor = true;
            // 
            // TfsURIBox
            // 
            this.TfsURIBox.Location = new System.Drawing.Point(12, 156);
            this.TfsURIBox.Name = "TfsURIBox";
            this.TfsURIBox.Size = new System.Drawing.Size(521, 22);
            this.TfsURIBox.TabIndex = 2;
            this.TfsURIBox.UseWaitCursor = true;
            // 
            // btnGenCSV
            // 
            this.btnGenCSV.Location = new System.Drawing.Point(12, 239);
            this.btnGenCSV.Name = "btnGenCSV";
            this.btnGenCSV.Size = new System.Drawing.Size(246, 37);
            this.btnGenCSV.TabIndex = 3;
            this.btnGenCSV.Text = "Generate CSV";
            this.btnGenCSV.UseVisualStyleBackColor = true;
            this.btnGenCSV.UseWaitCursor = true;
            this.btnGenCSV.Click += new System.EventHandler(this.btnGenCSV_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(289, 239);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(244, 37);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.UseWaitCursor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Enter Username";
            this.lblUsername.UseWaitCursor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Enter Password";
            this.lblPassword.UseWaitCursor = true;
            // 
            // lblTFSUrl
            // 
            this.lblTFSUrl.AutoSize = true;
            this.lblTFSUrl.Location = new System.Drawing.Point(12, 134);
            this.lblTFSUrl.Name = "lblTFSUrl";
            this.lblTFSUrl.Size = new System.Drawing.Size(66, 17);
            this.lblTFSUrl.TabIndex = 7;
            this.lblTFSUrl.Text = "TFS URL";
            this.lblTFSUrl.UseWaitCursor = true;
            // 
            // chkBoxDeveloperEst
            // 
            this.chkBoxDeveloperEst.AutoSize = true;
            this.chkBoxDeveloperEst.Location = new System.Drawing.Point(15, 198);
            this.chkBoxDeveloperEst.Name = "chkBoxDeveloperEst";
            this.chkBoxDeveloperEst.Size = new System.Drawing.Size(153, 21);
            this.chkBoxDeveloperEst.TabIndex = 9;
            this.chkBoxDeveloperEst.Text = "Developer Estimate";
            this.chkBoxDeveloperEst.UseVisualStyleBackColor = true;
            this.chkBoxDeveloperEst.CheckedChanged += new System.EventHandler(this.chkBoxDeveloperEst_CheckedChanged);
            // 
            // TfsTimeSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 293);
            this.Controls.Add(this.chkBoxDeveloperEst);
            this.Controls.Add(this.lblTFSUrl);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnGenCSV);
            this.Controls.Add(this.TfsURIBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TfsTimeSheetForm";
            this.Text = "TFS Time Sheet Helper";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox TfsURIBox;
        private System.Windows.Forms.Button btnGenCSV;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTFSUrl;
        private System.Windows.Forms.CheckBox chkBoxDeveloperEst;
    }
}

