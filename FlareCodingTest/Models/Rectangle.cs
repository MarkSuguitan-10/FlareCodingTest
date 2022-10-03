using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlareCodingTest.Models
{
    public class Rectangle
    {
        public int [] startCoordinate = new int[2] {0,0};
        public int recHeight { get; set; }
        public int recWidth  {get; set;}

        public Color rectanglecolor { get; set; }
        public string rectangleLabel { get; set; }
        public List<int[]> rectangleCoordinates = new List<int[]>();
    }
}
