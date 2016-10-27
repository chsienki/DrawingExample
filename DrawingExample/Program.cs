using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteExpectedValues();

            // create two canvases with different scale factors
            ScalingCanvas canvas1 = new ScalingCanvas(2);
            ScalingCanvas canvas2 = new ScalingCanvas(4);

            // create a couple of squares on each canvas
            Square square1 = new Square(canvas1, 10, 10, 10);
            Square square2 = new Square(canvas2, 5, 5, 5);

            // 'draw' them
            square1.Draw();
            square2.Draw();

            Console.ReadKey();
        }

        private static void WriteExpectedValues()
        {
            Console.WriteLine("Expected output:\n");
            Console.WriteLine("Drawing a square:");
            Console.WriteLine("Drew points on canvas 0:  (20, 20) (40, 20) (40, 40) (20, 40)");
            Console.WriteLine("");
            Console.WriteLine("Drawing a square:");
            Console.WriteLine("Drew points on canvas 1:  (20, 20)  (40, 20)  (40, 40)  (20, 40)");
            Console.WriteLine("");
            Console.WriteLine("".PadLeft(40, '='));
            Console.WriteLine("Actual Output:\n");
        }
    }
}
