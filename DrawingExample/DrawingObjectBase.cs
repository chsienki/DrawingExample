using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingExample
{
    public abstract class DrawingObjectBase
    {
        public ScalingCanvas Canvas { get; }

        protected DrawingObjectBase(ScalingCanvas canvas)
        {
            this.Canvas = canvas;
        }

        public abstract void Draw();

        protected void DrawInternal(Point[] points)
        {
            Console.Write($"Drew points on canvas {Canvas.Id}: ");
            foreach(var p in points)
            {
                // scale the point
                ScalePointByCanvasScale(p);

                // 'draw' it
                Console.Write($" ({p.X}, {p.Y}) ");
            }
            Console.WriteLine("\n");
        }

        protected void ScalePointByCanvasScale(Point p)
        {
            p.X = p.X * this.Canvas.ScaleFactor;
        }

    }
}
