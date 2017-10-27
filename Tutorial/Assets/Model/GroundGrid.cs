using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model
{
    class GroundGrid
    {
        // in "brick units"
        private int width;
        private int depth;

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Depth
        {
            get
            {
                return depth;
            }

            set
            {
                depth = value;
            }
        }

        // constructor
        public GroundGrid(int width, int depth)
        {
            this.width = width;
            this.depth = depth;
        }
    }
}
