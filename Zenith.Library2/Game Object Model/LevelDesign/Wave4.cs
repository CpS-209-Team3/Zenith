﻿//-----------------------------------------------------------
//File:   Wave4.cs
//Desc:   This class defines the enemies that will spawn in the fourth wave.
//----------------------------------------------------------- 

using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith.Library
{
    public class Wave4 : Wave
    {
        public override void Spawn()
        {
            for (int i = 0; i < difficulty + (level * 2); i++)
            {
                startingPos = new Vector(World.Instance.Width, World.Instance.Random.Next(0, Convert.ToInt32(World.Instance.Height)), false);
 
                Enemy2 e2 = new Enemy2(startingPos);
                Enemy3 e3 = new Enemy3(startingPos);
                AddEnemy(e2);
                AddEnemy(e3);
            }
        }

    }
    
}
