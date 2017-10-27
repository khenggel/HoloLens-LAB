using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Model
{
    class World
    {
        private GroundGrid groundGrid;
        private List<Brick> bricks;

        // for conversion between real world units to brick units
        private float scaleFactor;

        // constructor
        public World()
        {
            bricks = new List<Brick>();
        }

        // modifiers
        public void addBrick(Brick brick)
        {
            bricks.Add(brick);
        }

        public bool removeBrick(Brick brick)
        {
            return bricks.Remove(brick);
        }

    }
}
