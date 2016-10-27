using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingExample
{
    public class Square : DrawingObjectBase
    {
        int x, y, length;

        public Square(ScalingCanvas canvas, int x, int y, int length)
            : base(canvas)
        {
            this.x = x;
            this.y = y;
            this.length = length;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a square:");
            this.DrawInternal(new[] { new Point(x, y), new Point(x + length, y), new Point(x + length, y + length), new Point(x, y + length) });
        }
    }
}
