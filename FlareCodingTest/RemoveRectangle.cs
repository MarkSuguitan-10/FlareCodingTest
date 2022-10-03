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
    public partial class RemoveRectangle : Form
    {
        private Rectangles m_rectangles;

        public DialogResult dResult { get; set; }
        public string RectangleForRemoval { get; set; }

        public RemoveRectangle(Rectangles m_rectangles)
        {
            this.m_rectangles = m_rectangles;
            InitializeComponent();
            foreach (Models.Rectangle item in m_rectangles.GetRectangles)
            {
                RectangleSelector.Items.Add(item.rectangleLabel);
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            dResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            dResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void RectangleSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleSelector.SelectedItem.ToString()) == false)
            {
                RectangleForRemoval = RectangleSelector.SelectedItem.ToString();
                dResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
