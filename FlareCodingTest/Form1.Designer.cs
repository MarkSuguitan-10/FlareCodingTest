namespace FlareCodingTest
{
    partial class FlareCodingTest
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
            this.ContainerGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRetactangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRectangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerGridView
            // 
            this.ContainerGridView.AllowUserToAddRows = false;
            this.ContainerGridView.AllowUserToDeleteRows = false;
            this.ContainerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContainerGridView.Location = new System.Drawing.Point(12, 27);
            this.ContainerGridView.Name = "ContainerGridView";
            this.ContainerGridView.ReadOnly = true;
            this.ContainerGridView.Size = new System.Drawing.Size(1120, 622);
            this.ContainerGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeGridToolStripMenuItem,
            this.addRetactangeToolStripMenuItem,
            this.removeRectangeToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // resizeGridToolStripMenuItem
            // 
            this.resizeGridToolStripMenuItem.Name = "resizeGridToolStripMenuItem";
            this.resizeGridToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.resizeGridToolStripMenuItem.Text = "Resize Grid";
            this.resizeGridToolStripMenuItem.Click += new System.EventHandler(this.resizeGridToolStripMenuItem_Click);
            // 
            // addRetactangeToolStripMenuItem
            // 
            this.addRetactangeToolStripMenuItem.Name = "addRetactangeToolStripMenuItem";
            this.addRetactangeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addRetactangeToolStripMenuItem.Text = "Add Retactange";
            this.addRetactangeToolStripMenuItem.Click += new System.EventHandler(this.addRetactangeToolStripMenuItem_Click);
            // 
            // removeRectangeToolStripMenuItem
            // 
            this.removeRectangeToolStripMenuItem.Name = "removeRectangeToolStripMenuItem";
            this.removeRectangeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.removeRectangeToolStripMenuItem.Text = "Remove Rectange";
            this.removeRectangeToolStripMenuItem.Click += new System.EventHandler(this.removeRectangeToolStripMenuItem_Click);
            // 
            // FlareCodingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1144, 661);
            this.Controls.Add(this.ContainerGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlareCodingTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flare";
            ((System.ComponentModel.ISupportInitialize)(this.ContainerGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContainerGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRetactangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRectangeToolStripMenuItem;
    }
}

