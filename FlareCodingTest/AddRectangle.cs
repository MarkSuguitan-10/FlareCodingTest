using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlareCodingTest.Models;

namespace FlareCodingTest
{
    public partial class AddRectangle : Form
    {
        private FlareGrid m_grid;
        private Models.Rectangle m_rectangle;
        public DialogResult dResult { get; set; }

        public AddRectangle(FlareGrid m_grid, Models.Rectangle Rectangle)
        {
            this.m_grid = m_grid;
            this.m_rectangle = Rectangle;
            InitializeComponent();
            lbl_coordinateError.Visible = false;
            lbl_heighterror.Visible = false;
            lbl_widtherror.Visible = false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string[] coordinates = mtxb_Coordinates.Text.Split(',');
            m_rectangle.startCoordinate = new int[2] { Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]) };
            m_rectangle.recHeight = Convert.ToInt32(txtbx_height.Text);
            m_rectangle.recWidth = Convert.ToInt32(txtbx_width.Text);
            dResult = DialogResult.OK;
            this.Close();
        }

        private void mtxb_Coordinates_TextChanged(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            lbl_coordinateError.Visible = false;
            try
            {
                lbl_coordinateError.Text = "Invalid Starting Coordinate";
                string[] coordinates = mtxb_Coordinates.Text.Split(',');
                int rowCoordinate = Convert.ToInt32(coordinates[0]);
                int colCoordinate = Convert.ToInt32(coordinates[1]);
                if (rowCoordinate < -1 || rowCoordinate > 25)
                {
                    lbl_coordinateError.Text = "Row coordinate should not be lower than 0 or greated than 25";
                    lbl_coordinateError.Visible = true;
                    btn_OK.Enabled = false;
                }
                if (colCoordinate < -1 || colCoordinate > 25)
                {
                    lbl_coordinateError.Text = "Column coordinate should not be lower than 0 or greated than 25";
                    lbl_coordinateError.Visible = true;
                    btn_OK.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                lbl_coordinateError.Text = ee.Message;
                lbl_coordinateError.Visible = true;
                btn_OK.Enabled = false;
            }
        }

        private void mtxb_Coordinates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void mtxb_Coordinates_Leave(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            lbl_coordinateError.Visible = false;
            string[] coordinates = mtxb_Coordinates.Text.Split(',');
            if(string.IsNullOrEmpty(coordinates[0]) || string.IsNullOrEmpty(coordinates[1]))
            {
                lbl_coordinateError.Visible = true;
                btn_OK.Enabled = false;
            }
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
                txtbx_width.Text = (m_grid.width.ToString() == "0") ? "1" : m_grid.width.ToString();
            }
            int val = int.Parse(txtbx_width.Text);
            lbl_widtherror.Visible = false;
            string[] coordinates = mtxb_Coordinates.Text.Split(',');
            int widthCoordinate = Convert.ToInt32(coordinates[1]);
            if ((val < 1 || (val + widthCoordinate -1) >= m_grid.width))
            {
                btn_OK.Enabled = false;
                lbl_widtherror.Visible = true;
            }
        }

        private void txtbx_height_TextChanged(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            if (string.IsNullOrEmpty(txtbx_height.Text) == true)
            {
                txtbx_height.Text = (m_grid.height.ToString() == "0") ? "1" : m_grid.height.ToString();
            }

            int val = int.Parse(txtbx_height.Text);
            lbl_heighterror.Visible = false;
            string[] coordinates = mtxb_Coordinates.Text.Split(',');
            int heightCoordinate = Convert.ToInt32(coordinates[0]);
            if (heightCoordinate == 0)
            {
                if ((val < 1 || (val + heightCoordinate + 1) >= m_grid.height))
                {
                    btn_OK.Enabled = false;
                    lbl_heighterror.Visible = true;
                }
            }
            else
            {
                if ((val < 1 || (val + heightCoordinate - 1) >= m_grid.height))
                {
                    btn_OK.Enabled = false;
                    lbl_heighterror.Visible = true;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            dResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
