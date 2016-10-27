using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingExample
{
    public class Canvas
    {
        protected static int nextId = 0;

        /// <summary>
        /// Gets the unique identifier for this canvas.
        /// </summary>
        public string Id { get; }

        public Canvas()
        {
            // ensure each new canvas has a unique id
            this.Id = nextId.ToString();
            nextId++;
        }

        protected internal Canvas(int id)
        {
            //use the derived class passed id
            this.Id = id.ToString();
        }
    }
}
