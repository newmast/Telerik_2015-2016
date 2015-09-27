using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gravity
{
    public class Entity
    {
        private Vector2 velocity;
        private static Vector2 VelocityCap = new Vector2(0.6f, 0.6f);
 
        public Entity(Vector2 position)
        {
            this.Position = position;
        }

        public Vector2 Position { get; set; }
        public Texture2D Model { get; set; }
        public Rectangle Bounds
        {
            get
            {
                return new Rectangle((int)this.Position.X, (int)this.Position.Y, this.Model.Bounds.Width / 5, this.Model.Bounds.Height / 5);
            }
        }
        public Vector2 Velocity
        {
            get
            {
                return this.velocity;
            }
            set
            {
                if (Math.Abs(value.X) < Entity.VelocityCap.X && Math.Abs(value.Y) < Entity.VelocityCap.Y)
                {
                    this.velocity = value;
                }
            }
        }
        public Vector2 Acceleration { get; set; }
        
    }
}
