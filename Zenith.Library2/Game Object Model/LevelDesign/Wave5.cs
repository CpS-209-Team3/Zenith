﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith.Library
{
    class Wave5 : Wave
    {
        public Wave5(int difficulty, int level)
        {
            AddEnemy(World.Instance.SpawnBoss(level));
        }
    }
}