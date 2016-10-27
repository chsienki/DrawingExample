using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingExample
{
    public class ScalingCanvas : Canvas
    {
        public int ScaleFactor { get; }

        public ScalingCanvas(int scaleFactor)
            : base(nextId)
        {
            this.ScaleFactor = scaleFactor;
        }
    }
}
