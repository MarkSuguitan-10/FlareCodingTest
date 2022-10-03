using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlareCodingTest
{
    public partial class ResizeGrid : Form
    {
        private Models.FlareGrid m_grid;
        public DialogResult dResult { get; set; }

        public ResizeGrid(Models.FlareGrid m_grid)
        {
            InitializeComponent();
            lbl_heightError.Visible = false;
            lbl_widthError.Visible = false;
            this.m_grid = m_grid;
            txtbx_height.Text = "5";
            txtbx_width.Text = "5";
            if (this.m_grid.height != 0)
            {
                txtbx_height.Text = this.m_grid.height.ToString();
            }
            if (this.m_grid.width != 0)
            {
                txtbx_width.Text = this.m_grid.width.ToString();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            m_grid.height = int.Parse(txtbx_height.Text);
            m_grid.width = int.Parse(txtbx_width.Text);
            dResult = DialogResult.OK;
            this.Close();
        }

        private void txtbx_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtbx_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtbx_width_TextChanged(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            if (string.IsNullOrEmpty(txtbx_width.Text) == true)
            {
                txtbx_width.Text = (m_grid.width.ToString() == "0") ? "5" : m_grid.width.ToString(); 
            }
            int val = int.Parse(txtbx_width.Text);
            lbl_widthError.Visible = false;
            if ((val < 5 || val > 25))
            {
                btn_OK.Enabled = false;
                lbl_widthError.Visible = true;
            }
        }

        private void txtbx_height_TextChanged(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            if(string.IsNullOrEmpty(txtbx_height.Text) == true)
            {
                txtbx_height.Text = (m_grid.height.ToString() == "0") ?  "5" : m_grid.height.ToString() ;
            }

            int val = int.Parse(txtbx_height.Text);
            lbl_heightError.Visible = false;
            if ((val < 5 || val > 25))
            {
                btn_OK.Enabled = false;
                lbl_heightError.Visible = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            dResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
