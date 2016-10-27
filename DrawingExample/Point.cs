using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingExample
{
    public struct Point
    {
        /// <summary>
        /// The X-Coordinate of this point
        /// </summary>
        public int X { get; set; }


        /// <summary>
        /// The Y-Coordinate of this point
        /// </summary>
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

    }
}
