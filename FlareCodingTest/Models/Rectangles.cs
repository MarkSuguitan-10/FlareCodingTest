using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlareCodingTest.Models;
using System.Drawing;

namespace FlareCodingTest.Models
{
    public class Rectangles
    {
        private List<Rectangle> newrectangles = null;
        private System.Windows.Forms.DataGridView ContainerGridView;
        public int RectanglesCount { get { return newrectangles.Count; } }
        private Random rnd = new Random();
        public List<Rectangle> GetRectangles { get { return newrectangles; } }

        public Rectangles(System.Windows.Forms.DataGridView ContainerGridView)
        {
            this.ContainerGridView = ContainerGridView;
            newrectangles = new List<Rectangle>();
        }

        public bool AddRectangles(Models.Rectangle rectangle, FlareGrid mygrid)
        {
            bool result = true;
            try
            {
                rectangle.rectanglecolor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                for (int row = rectangle.startCoordinate[0]; row <= (rectangle.startCoordinate[0] + rectangle.recHeight - 1); row++)
                {
                    for (int col = rectangle.startCoordinate[1]; col <= (rectangle.startCoordinate[1] + rectangle.recWidth - 1); col++)
                    {
                        int[] newCoordinate = new int[2] { row, col };
                        rectangle.rectangleCoordinates.Add(newCoordinate);
                    }
                }
                result = CheckIfRectangleDoesOverlap(rectangle.rectangleCoordinates);
                if (result == false)
                {
                    rectangle.rectangleLabel = "Rectangle_" + (newrectangles.Count + 1).ToString();
                    newrectangles.Add(rectangle);
                    mygrid.GenerateRectangle(rectangle);
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return result;
        }

        private bool CheckIfRectangleDoesOverlap(List<int[]> list)
        {
            bool isOverlap = false;
            try
            {
                foreach (int[] item in list)
                {
                    foreach (Rectangle rec in newrectangles)
                    {
                        isOverlap = rec.rectangleCoordinates.Any(x => x.SequenceEqual(item));
                        if (isOverlap == true) {
                            break;
                        }
                    }
                    if (isOverlap == true)
                    {
                        break;
                    }
                }
            }
            catch (Exception ee)
            {
                Console.Write( ee.Message);
            }
            return isOverlap;
        }

        public void RemoveRectangles(string RectangleName, FlareGrid mygrid)
        {
            Rectangle rectangleForRemoval = newrectangles.Where(x => x.rectangleLabel == RectangleName).FirstOrDefault();
            mygrid.changeToDefaultColor(rectangleForRemoval);
            newrectangles.Remove(rectangleForRemoval);
        }

    }
}
