﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith.Library
{
    public class Asteroid : Enemy
    {
        public override void Loop() { }

        public Asteroid(Vector position, double size)
            : base(position)
        {
            this.size = new Vector(size, size);
            velocity.X = (World.Instance.Random.NextDouble() * 2 - 1) * 8;
            velocity.Y = (World.Instance.Random.NextDouble() * 2 - 1) * 8;
            type = GameObjectType.Asteroid;
            imageSource = Util.GetSpriteFolderPath("Aster1.png");
        }
    }
}
