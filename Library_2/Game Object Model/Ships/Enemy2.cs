﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith.Library
{
    class Enemy2 : Enemy
    {
        public override void Loop() { }

        public Enemy2(Vector position, Ship player)
           : base(position, player)
        {

        }
    }
}
