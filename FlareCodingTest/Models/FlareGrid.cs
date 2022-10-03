using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlareCodingTest.Models
{
    public class FlareGrid
    {
        private DataGridView ContainerGridView;

        public FlareGrid(DataGridView ContainerGridView)
        {
            this.ContainerGridView = ContainerGridView;
        }
        public int height { get; set; }
        public int width { get; set; }
        public List<int[]> TotalCoordinates {get;set;}

        internal void GetDataGridView()
        {
            for (int w = 0; w <= width - 1; w++)
            {
                DataGridViewColumn newCol = new DataGridViewTextBoxColumn();
                newCol.HeaderText = w.ToString();
                newCol.Width = 40;
                newCol.Resizable = DataGridViewTriState.False;
                ContainerGridView.Columns.Add(newCol);
                
            }

            for (int h = 0; h <= height - 1; h++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.HeaderCell.Value = h.ToString();
                newRow.Height = 40;
                newRow.Resizable = DataGridViewTriState.False;
                ContainerGridView.Rows.Add(newRow);
            }
            ContainerGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ContainerGridView.RowHeadersWidth = 10;
            ContainerGridView.AllowUserToAddRows = false;
        }




        internal void GenerateRectangle(Rectangle rectangle)
        {
            foreach (int[] coordinates in rectangle.rectangleCoordinates)
            {
                foreach (DataGridViewRow row in ContainerGridView.Rows)
                {
                    if (row.Index == coordinates[0])
                    {
                        row.Cells[coordinates[1]].Style.BackColor = rectangle.rectanglecolor;
                    }
                }
            }
        }


        internal void changeToDefaultColor(Rectangle rectangleForRemoval)
        {
            foreach (int[] coordinates in rectangleForRemoval.rectangleCoordinates)
            {
                foreach (DataGridViewRow row in ContainerGridView.Rows)
                {
                    if (row.Index == coordinates[0])
                    {
                        row.Cells[coordinates[1]].Style.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }
    }
}
