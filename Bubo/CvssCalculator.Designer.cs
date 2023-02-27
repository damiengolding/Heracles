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

namespace Bubo
{
    partial class CvssCalculator
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.vectorTextBox = new System.Windows.Forms.TextBox();
            this.vectorLabel = new System.Windows.Forms.Label();
            this.componentsTab = new System.Windows.Forms.TabControl();
            this.baseTabPage = new System.Windows.Forms.TabPage();
            this.tempTabPage = new System.Windows.Forms.TabPage();
            this.envTabPage = new System.Windows.Forms.TabPage();
            this.componentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreTextBox.Location = new System.Drawing.Point(353, 153);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(73, 24);
            this.scoreTextBox.TabIndex = 3;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(305, 153);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(42, 17);
            this.scoreLabel.TabIndex = 13;
            this.scoreLabel.Text = "Score:";
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vectorTextBox.Location = new System.Drawing.Point(62, 153);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.ReadOnly = true;
            this.vectorTextBox.Size = new System.Drawing.Size(233, 24);
            this.vectorTextBox.TabIndex = 2;
            // 
            // vectorLabel
            // 
            this.vectorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vectorLabel.AutoSize = true;
            this.vectorLabel.Location = new System.Drawing.Point(10, 153);
            this.vectorLabel.Name = "vectorLabel";
            this.vectorLabel.Size = new System.Drawing.Size(46, 17);
            this.vectorLabel.TabIndex = 11;
            this.vectorLabel.Text = "Vector:";
            // 
            // componentsTab
            // 
            this.componentsTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.componentsTab.Controls.Add(this.baseTabPage);
            this.componentsTab.Controls.Add(this.tempTabPage);
            this.componentsTab.Controls.Add(this.envTabPage);
            this.componentsTab.Location = new System.Drawing.Point(10, 14);
            this.componentsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.componentsTab.Name = "componentsTab";
            this.componentsTab.SelectedIndex = 0;
            this.componentsTab.Size = new System.Drawing.Size(420, 132);
            this.componentsTab.TabIndex = 1;
            // 
            // baseTabPage
            // 
            this.baseTabPage.Location = new System.Drawing.Point(4, 26);
            this.baseTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baseTabPage.Name = "baseTabPage";
            this.baseTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baseTabPage.Size = new System.Drawing.Size(412, 102);
            this.baseTabPage.TabIndex = 0;
            this.baseTabPage.Text = "Base score";
            this.baseTabPage.UseVisualStyleBackColor = true;
            // 
            // tempTabPage
            // 
            this.tempTabPage.Location = new System.Drawing.Point(4, 26);
            this.tempTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tempTabPage.Name = "tempTabPage";
            this.tempTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tempTabPage.Size = new System.Drawing.Size(412, 102);
            this.tempTabPage.TabIndex = 1;
            this.tempTabPage.Text = "Temporal score";
            this.tempTabPage.UseVisualStyleBackColor = true;
            // 
            // envTabPage
            // 
            this.envTabPage.Location = new System.Drawing.Point(4, 26);
            this.envTabPage.Name = "envTabPage";
            this.envTabPage.Size = new System.Drawing.Size(412, 102);
            this.envTabPage.TabIndex = 2;
            this.envTabPage.Text = "Environmental score";
            this.envTabPage.UseVisualStyleBackColor = true;
            // 
            // CvssCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.vectorTextBox);
            this.Controls.Add(this.vectorLabel);
            this.Controls.Add(this.componentsTab);
            this.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CvssCalculator";
            this.Size = new System.Drawing.Size(440, 190);
            this.componentsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox scoreTextBox;
        private Label scoreLabel;
        private TextBox vectorTextBox;
        private Label vectorLabel;
        private TabControl componentsTab;
        private TabPage baseTabPage;
        private TabPage tempTabPage;
        private TabPage envTabPage;
    }
}