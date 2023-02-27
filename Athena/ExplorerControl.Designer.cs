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
    partial class ExplorerControl
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
            this.centralTabControl = new System.Windows.Forms.TabControl();
            this.tablesPage = new System.Windows.Forms.TabPage();
            this.tablesTreeView = new System.Windows.Forms.TreeView();
            this.sourcesPage = new System.Windows.Forms.TabPage();
            this.sourcesDataGridView = new System.Windows.Forms.DataGridView();
            this.centralTabControl.SuspendLayout();
            this.tablesPage.SuspendLayout();
            this.sourcesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // centralTabControl
            // 
            this.centralTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.centralTabControl.Controls.Add(this.tablesPage);
            this.centralTabControl.Controls.Add(this.sourcesPage);
            this.centralTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralTabControl.Enabled = false;
            this.centralTabControl.HotTrack = true;
            this.centralTabControl.Location = new System.Drawing.Point(0, 0);
            this.centralTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.centralTabControl.Name = "centralTabControl";
            this.centralTabControl.SelectedIndex = 0;
            this.centralTabControl.Size = new System.Drawing.Size(492, 501);
            this.centralTabControl.TabIndex = 0;
            // 
            // tablesPage
            // 
            this.tablesPage.Controls.Add(this.tablesTreeView);
            this.tablesPage.Location = new System.Drawing.Point(4, 4);
            this.tablesPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablesPage.Name = "tablesPage";
            this.tablesPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablesPage.Size = new System.Drawing.Size(484, 469);
            this.tablesPage.TabIndex = 0;
            this.tablesPage.Text = "Tables";
            this.tablesPage.UseVisualStyleBackColor = true;
            // 
            // tablesTreeView
            // 
            this.tablesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesTreeView.Location = new System.Drawing.Point(3, 4);
            this.tablesTreeView.Name = "tablesTreeView";
            this.tablesTreeView.Size = new System.Drawing.Size(478, 461);
            this.tablesTreeView.TabIndex = 0;
            // 
            // sourcesPage
            // 
            this.sourcesPage.Controls.Add(this.sourcesDataGridView);
            this.sourcesPage.Location = new System.Drawing.Point(4, 4);
            this.sourcesPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sourcesPage.Name = "sourcesPage";
            this.sourcesPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sourcesPage.Size = new System.Drawing.Size(484, 469);
            this.sourcesPage.TabIndex = 1;
            this.sourcesPage.Text = "Sources";
            this.sourcesPage.UseVisualStyleBackColor = true;
            // 
            // sourcesDataGridView
            // 
            this.sourcesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourcesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcesDataGridView.Location = new System.Drawing.Point(3, 4);
            this.sourcesDataGridView.Name = "sourcesDataGridView";
            this.sourcesDataGridView.RowTemplate.Height = 25;
            this.sourcesDataGridView.Size = new System.Drawing.Size(478, 461);
            this.sourcesDataGridView.TabIndex = 0;
            // 
            // ExplorerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.centralTabControl);
            this.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExplorerControl";
            this.Size = new System.Drawing.Size(492, 501);
            this.centralTabControl.ResumeLayout(false);
            this.tablesPage.ResumeLayout(false);
            this.sourcesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourcesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl centralTabControl;
        private TabPage tablesPage;
        private TreeView tablesTreeView;
        private TabPage sourcesPage;
        private DataGridView sourcesDataGridView;
    }
}
