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
    public partial class FlareCodingTest : Form
    {
        private FlareGrid m_grid = null;
        private Models.Rectangle m_rectangle = null;
        private Rectangles m_rectangles = null;

        public FlareCodingTest()
        {
            InitializeComponent();
            m_grid = new FlareGrid(ContainerGridView);
            m_rectangles = new Rectangles(ContainerGridView);
            addRetactangeToolStripMenuItem.Enabled = false;
            removeRectangeToolStripMenuItem.Enabled = false;
        }

        private void resizeGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeGrid newGridSize = new ResizeGrid(m_grid);
            newGridSize.ShowDialog();
            if (newGridSize.dResult == System.Windows.Forms.DialogResult.OK)
            {
                ContainerGridView.Columns.Clear();
                addRetactangeToolStripMenuItem.Enabled = false;
                removeRectangeToolStripMenuItem.Enabled = false;
                m_grid.GetDataGridView();
                if (ContainerGridView.Columns.Count != 0)
                {
                    addRetactangeToolStripMenuItem.Enabled = true;
                }
            }
            m_rectangles = new Rectangles(ContainerGridView);
            ContainerGridView.Refresh();
        }

        private void addRetactangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_rectangle = new Models.Rectangle();
            removeRectangeToolStripMenuItem.Enabled = false;
            AddRectangle newAddRectangle = new AddRectangle(m_grid, m_rectangle);
            newAddRectangle.ShowDialog();
            if (m_rectangles.RectanglesCount != 0)
            {
                removeRectangeToolStripMenuItem.Enabled = true;
            }
            if (newAddRectangle.dResult == System.Windows.Forms.DialogResult.OK)
            {
                bool IsOverlap = m_rectangles.AddRectangles(m_rectangle, m_grid);
                if (IsOverlap == true)
                {
                    MessageBox.Show("Unable to add rectangle because of overlap", "Error adding new rectangle",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeRectangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveRectangle newRemoveRectangle = new RemoveRectangle(m_rectangles);
            newRemoveRectangle.ShowDialog();
            if (newRemoveRectangle.dResult == System.Windows.Forms.DialogResult.OK)
            {
                m_rectangles.RemoveRectangles(newRemoveRectangle.RectangleForRemoval, m_grid);
            }
        }
    }
}
