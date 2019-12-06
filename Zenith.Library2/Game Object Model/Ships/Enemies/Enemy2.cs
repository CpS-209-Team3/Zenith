﻿using System;
using System.Collections.Generic;
using System.Text;


// needs a different sprite. 
// needs its own movemment pattern put in ship loop.
// 




namespace Zenith.Library
{
    class Enemy2 : Enemy
    {
        Vector goal;

        public override void ShipLoop()
        {
            cannon.Fire();
            var playerOffset = World.Instance.Player.Position - position;
            angle = playerOffset.Angle;

            if (playerOffset.Magnitude < 500)
            {
                playerOffset.Magnitude = 500;
                AddForce(playerOffset * -1);
            }
            else
            {
                MoveTo(goal, 10);
            }
        }

        public Enemy2(Vector position)
           : base(position)
        {
            imageSources = new List<string> { Util.GetShipSpriteFolderPath("darkgrey_01.png") };
            type = GameObjectType.Enemy2;
            double x = (World.Instance.Random.NextDouble() * World.Instance.Width / 2) + World.Instance.Width / 2;
            double y = World.Instance.Random.NextDouble() * World.Instance.Height;
            goal = new Vector(x, y);
            cannon = new BasicCannon(this, 200);
            cannon.ProjectileColor = ProjectileColor.Red;
        }
    }
}