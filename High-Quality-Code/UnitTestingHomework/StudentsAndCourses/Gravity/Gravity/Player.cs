using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gravity
{
    public class Player : Entity
    {
        public static float Speed = 0.02f;
        public static Vector2 Friction = new Vector2(1.5f, 1.5f);

        public Player(Vector2 position)
            : base(position)
        {
        }

    }
}
