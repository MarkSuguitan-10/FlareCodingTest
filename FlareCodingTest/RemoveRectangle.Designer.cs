namespace FlareCodingTest
{
    partial class RemoveRectangle
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
            this.lbl_RemoveRectangle = new System.Windows.Forms.Label();
            this.RectangleSelector = new System.Windows.Forms.ComboBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_RemoveRectangle
            // 
            this.lbl_RemoveRectangle.AutoSize = true;
            this.lbl_RemoveRectangle.Location = new System.Drawing.Point(12, 15);
            this.lbl_RemoveRectangle.Name = "lbl_RemoveRectangle";
            this.lbl_RemoveRectangle.Size = new System.Drawing.Size(115, 13);
            this.lbl_RemoveRectangle.TabIndex = 0;
            this.lbl_RemoveRectangle.Text = "Rectangle to removed:";
            // 
            // RectangleSelector
            // 
            this.RectangleSelector.FormattingEnabled = true;
            this.RectangleSelector.Location = new System.Drawing.Point(133, 12);
            this.RectangleSelector.Name = "RectangleSelector";
            this.RectangleSelector.Size = new System.Drawing.Size(281, 21);
            this.RectangleSelector.TabIndex = 1;
            this.RectangleSelector.SelectedValueChanged += new System.EventHandler(this.RectangleSelector_SelectedValueChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(336, 52);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(236, 52);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // RemoveRectangle
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(423, 87);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.RectangleSelector);
            this.Controls.Add(this.lbl_RemoveRectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RemoveRectangle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Rectangle";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RemoveRectangle;
        private System.Windows.Forms.ComboBox RectangleSelector;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}