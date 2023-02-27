/* 
   Copyright (C) codepoet
   
   This is free software; you can redistribute it and/or
   modify it under the terms of the GNU Library General Public
   License as published by the Free Software Foundation; either
   version 2 of the License, or (at your option) any later version.
   
   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Library General Public License for more details.
   
   You should have received a copy of the GNU Library General Public
   License along with this software; if not, write to the Free
   Software Foundation, Inc., 59 Temple Place - Suite 330, Boston,
   MA 02111-1307, USA

  Don't use it to find and eat babies ... unless you're really REALLY hungry ;-)

*/

namespace Athena
{
    partial class AboutDialog : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(225, 225);
            this.logoPictureBox.TabIndex = 27;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(228, 2);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(9, 0, 6, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 33);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(181, 33);
            this.labelProductName.TabIndex = 20;
            this.labelProductName.Text = "Title: Athena";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(228, 55);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(155, 26);
            this.labelVersion.TabIndex = 21;
            this.labelVersion.Text = "Version: 2023.1";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Location = new System.Drawing.Point(228, 81);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(198, 26);
            this.labelCopyright.TabIndex = 22;
            this.labelCopyright.Text = "License: GPL v2 or later";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Location = new System.Drawing.Point(228, 29);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(181, 26);
            this.labelCompanyName.TabIndex = 23;
            this.labelCompanyName.Text = "Author: Damien Golding";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(328, 198);
            this.okButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(101, 31);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "&OK";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.HideSelection = false;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(231, 114);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(195, 78);
            this.descriptionRichTextBox.TabIndex = 26;
            this.descriptionRichTextBox.Text = "A tool for managing data generated and collated by the Heracles CLI";
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 229);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.logoPictureBox);
            this.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Text = "About Athena";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private Button okButton;
        private RichTextBox descriptionRichTextBox;
    }
}