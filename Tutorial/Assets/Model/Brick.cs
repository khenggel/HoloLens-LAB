using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Model
{
    /// <summary>
    /// for bricks that have been placed in the model
    /// </summary>
    class Brick
    {
        // in "brick units"
        private int height;
        private int width;
        private int depth;

        private Transform transform;

        private List<Brick> connectedBricks;

        // getters & setters
        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Debth
        {
            get
            {
                return depth;
            }
        }

        public Transform Transform
        {
            get
            {
                return transform;
            }

            set
            {
                transform = value;
            }
        }

        // constructors
        public Brick(int height, int width, int depth, List<Brick> connectedBricks)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.connectedBricks = connectedBricks;
        }

        public Brick(int height, int width, int depth, List<Brick> connectedBricks, Transform transform)
            : this(height, width, depth, connectedBricks)
        {
            this.transform = transform;
        }

        // modifiers
        public void addConnectedBrick(Brick brick)
        {
            connectedBricks.Add(brick);
        }

        public bool removeConnectedBrick(Brick brick)
        {
            return connectedBricks.Remove(brick);
        }


    }
}
