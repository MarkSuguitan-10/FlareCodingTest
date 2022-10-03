namespace FlareCodingTest
{
    partial class ResizeGrid
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
            this.Label_Height = new System.Windows.Forms.Label();
            this.txtbx_height = new System.Windows.Forms.TextBox();
            this.txtbx_width = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_heightError = new System.Windows.Forms.Label();
            this.lbl_widthError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(13, 13);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(38, 13);
            this.Label_Height.TabIndex = 0;
            this.Label_Height.Text = "Height";
            // 
            // txtbx_height
            // 
            this.txtbx_height.Location = new System.Drawing.Point(58, 10);
            this.txtbx_height.MaxLength = 2;
            this.txtbx_height.Name = "txtbx_height";
            this.txtbx_height.Size = new System.Drawing.Size(301, 20);
            this.txtbx_height.TabIndex = 1;
            this.txtbx_height.Text = "5";
            this.txtbx_height.TextChanged += new System.EventHandler(this.txtbx_height_TextChanged);
            this.txtbx_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_height_KeyPress);
            // 
            // txtbx_width
            // 
            this.txtbx_width.Location = new System.Drawing.Point(58, 53);
            this.txtbx_width.MaxLength = 2;
            this.txtbx_width.Name = "txtbx_width";
            this.txtbx_width.Size = new System.Drawing.Size(301, 20);
            this.txtbx_width.TabIndex = 3;
            this.txtbx_width.Text = "5";
            this.txtbx_width.TextChanged += new System.EventHandler(this.txtbx_width_TextChanged);
            this.txtbx_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_width_KeyPress);
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.ForeColor = System.Drawing.Color.Black;
            this.label_width.Location = new System.Drawing.Point(13, 56);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(35, 13);
            this.label_width.TabIndex = 2;
            this.label_width.Text = "Width";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(283, 110);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(187, 110);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_heightError
            // 
            this.lbl_heightError.AutoSize = true;
            this.lbl_heightError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_heightError.ForeColor = System.Drawing.Color.Red;
            this.lbl_heightError.Location = new System.Drawing.Point(55, 37);
            this.lbl_heightError.Name = "lbl_heightError";
            this.lbl_heightError.Size = new System.Drawing.Size(197, 13);
            this.lbl_heightError.TabIndex = 6;
            this.lbl_heightError.Text = "Invalid: Input must be between 5 and 25";
            // 
            // lbl_widthError
            // 
            this.lbl_widthError.AutoSize = true;
            this.lbl_widthError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_widthError.ForeColor = System.Drawing.Color.Red;
            this.lbl_widthError.Location = new System.Drawing.Point(55, 76);
            this.lbl_widthError.Name = "lbl_widthError";
            this.lbl_widthError.Size = new System.Drawing.Size(197, 13);
            this.lbl_widthError.TabIndex = 7;
            this.lbl_widthError.Text = "Invalid: Input must be between 5 and 25";
            // 
            // ResizeGrid
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(371, 145);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_widthError);
            this.Controls.Add(this.lbl_heightError);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtbx_width);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.txtbx_height);
            this.Controls.Add(this.Label_Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResizeGrid";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resize Grid";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.TextBox txtbx_height;
        private System.Windows.Forms.TextBox txtbx_width;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_heightError;
        private System.Windows.Forms.Label lbl_widthError;
    }
}