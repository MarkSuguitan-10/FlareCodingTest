namespace FlareCodingTest
{
    partial class AddRectangle
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
            this.lbl_startindex = new System.Windows.Forms.Label();
            this.lbl_coordinateError = new System.Windows.Forms.Label();
            this.lbl_heighterror = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_widtherror = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mtxb_Coordinates = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_height = new System.Windows.Forms.TextBox();
            this.txtbx_width = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_startindex
            // 
            this.lbl_startindex.AutoSize = true;
            this.lbl_startindex.Location = new System.Drawing.Point(13, 13);
            this.lbl_startindex.Name = "lbl_startindex";
            this.lbl_startindex.Size = new System.Drawing.Size(103, 13);
            this.lbl_startindex.TabIndex = 0;
            this.lbl_startindex.Text = "Starting Coordinate: ";
            // 
            // lbl_coordinateError
            // 
            this.lbl_coordinateError.AutoSize = true;
            this.lbl_coordinateError.ForeColor = System.Drawing.Color.Red;
            this.lbl_coordinateError.Location = new System.Drawing.Point(122, 37);
            this.lbl_coordinateError.Name = "lbl_coordinateError";
            this.lbl_coordinateError.Size = new System.Drawing.Size(131, 13);
            this.lbl_coordinateError.TabIndex = 2;
            this.lbl_coordinateError.Text = "Invalid Starting Coordinate";
            // 
            // lbl_heighterror
            // 
            this.lbl_heighterror.AutoSize = true;
            this.lbl_heighterror.ForeColor = System.Drawing.Color.Red;
            this.lbl_heighterror.Location = new System.Drawing.Point(122, 80);
            this.lbl_heighterror.Name = "lbl_heighterror";
            this.lbl_heighterror.Size = new System.Drawing.Size(258, 13);
            this.lbl_heighterror.TabIndex = 5;
            this.lbl_heighterror.Text = "Invalid Height: Should not exceed current grid height!";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(72, 56);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(44, 13);
            this.lbl_height.TabIndex = 0;
            this.lbl_height.Text = "Height: ";
            // 
            // lbl_widtherror
            // 
            this.lbl_widtherror.AutoSize = true;
            this.lbl_widtherror.ForeColor = System.Drawing.Color.Red;
            this.lbl_widtherror.Location = new System.Drawing.Point(122, 123);
            this.lbl_widtherror.Name = "lbl_widtherror";
            this.lbl_widtherror.Size = new System.Drawing.Size(251, 13);
            this.lbl_widtherror.TabIndex = 0;
            this.lbl_widtherror.Text = "Invalid Width: Should not exceed current grid width!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Width: ";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(357, 175);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(253, 175);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // mtxb_Coordinates
            // 
            this.mtxb_Coordinates.Location = new System.Drawing.Point(125, 10);
            this.mtxb_Coordinates.Mask = "00,00";
            this.mtxb_Coordinates.Name = "mtxb_Coordinates";
            this.mtxb_Coordinates.Size = new System.Drawing.Size(304, 20);
            this.mtxb_Coordinates.TabIndex = 1;
            this.mtxb_Coordinates.TextChanged += new System.EventHandler(this.mtxb_Coordinates_TextChanged);
            this.mtxb_Coordinates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxb_Coordinates_KeyPress);
            this.mtxb_Coordinates.Leave += new System.EventHandler(this.mtxb_Coordinates_Leave);
            // 
            // txtbx_height
            // 
            this.txtbx_height.Location = new System.Drawing.Point(125, 53);
            this.txtbx_height.MaxLength = 2;
            this.txtbx_height.Name = "txtbx_height";
            this.txtbx_height.Size = new System.Drawing.Size(304, 20);
            this.txtbx_height.TabIndex = 2;
            this.txtbx_height.Text = "1";
            this.txtbx_height.TextChanged += new System.EventHandler(this.txtbx_height_TextChanged);
            this.txtbx_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_height_KeyPress);
            // 
            // txtbx_width
            // 
            this.txtbx_width.Location = new System.Drawing.Point(125, 96);
            this.txtbx_width.MaxLength = 2;
            this.txtbx_width.Name = "txtbx_width";
            this.txtbx_width.Size = new System.Drawing.Size(304, 20);
            this.txtbx_width.TabIndex = 3;
            this.txtbx_width.Text = "1";
            this.txtbx_width.TextChanged += new System.EventHandler(this.txtbx_width_TextChanged);
            this.txtbx_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_width_KeyPress);
            // 
            // AddRectangle
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(441, 210);
            this.ControlBox = false;
            this.Controls.Add(this.txtbx_width);
            this.Controls.Add(this.txtbx_height);
            this.Controls.Add(this.mtxb_Coordinates);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_widtherror);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_heighterror);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_coordinateError);
            this.Controls.Add(this.lbl_startindex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddRectangle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Rectangle";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startindex;
        private System.Windows.Forms.Label lbl_coordinateError;
        private System.Windows.Forms.Label lbl_heighterror;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_widtherror;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox mtxb_Coordinates;
        private System.Windows.Forms.TextBox txtbx_height;
        private System.Windows.Forms.TextBox txtbx_width;
    }
}