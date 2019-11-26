﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zenith.Library
{
    public enum GameObjectType
    {
        Generic,
        Ship,
        Player,
        Item,
        Asteroid,
        Laser,
        BackgroundElement,
        Enemy,
        Enemy1,
        Enemy2,
        Enemy3,
        Boss1,
        Boss2,
        Boss3,
        Boss4,
        Boss5,
    }

    public abstract class GameObject : ISerialize
    {
        protected Vector position, velocity, size;
        protected GameObjectType type;
        protected double maxSpeed = 2000;
        protected double deacceleration = 1;

        protected bool collidable;
        protected bool destroy = false;

        protected string imageSource;
        protected double imageRotation = 0;


        // Properties

        public Vector Position { get { return position; } }

        public Vector Velocity { get { return velocity; } }

        public Vector Size { get { return size; } }

        public GameObjectType Type { get { return type; } }

        public bool Collidable { get { return collidable; } }

        public bool Destroy { get { return destroy;} set { destroy = value; } }

        public string ImageSource { get { return imageSource; } }

        public double ImageRotation { get { return imageRotation; } set { imageRotation = value; } }

        // Methods

        public virtual void OnCollision(GameObject gameObject) { }

        public abstract void Loop();

        public void Update()
        {
            Loop();
            if (velocity.Magnitude > maxSpeed)
            {
                velocity.Magnitude = maxSpeed;
            }
            position += velocity * World.Instance.DeltaTime;
        }

        public void AddForce(Vector f)
        {
            this.velocity += f * World.Instance.DeltaTime;
        }

        public GameObject(Vector position)
        {
            this.position = position;
            velocity = new Vector(0, 0);
            size = new Vector(0, 0);
            type = GameObjectType.Generic;
        }

        public virtual string Serialize()
        {
            return type.ToString() + ',' + collidable.ToString() + ',' + position.ToString() + ',' + velocity.ToString() + ',' + size.ToString() + ',' + Destroy.ToString();
        }

        public virtual void Deserialize(string saveInfo)
        {
            // saveInfo includes everything but the gameObjectType
            string[] savedValues = saveInfo.Split(',');
            collidable = Convert.ToBoolean(savedValues[0]);
            string[] xNy1 = savedValues[1].Split(':');
            position = new Vector(Convert.ToDouble(xNy1[0]), Convert.ToDouble(xNy1[1]), false);
            string[] xNy2 = savedValues[2].Split(':');
            velocity = new Vector(Convert.ToDouble(xNy2[0]), Convert.ToDouble(xNy2[1]), false);
            string[] xNy3 = savedValues[3].Split(':');
            size = new Vector(Convert.ToDouble(xNy3[0]), Convert.ToDouble(xNy3[1]), false);
            Destroy = Convert.ToBoolean(savedValues[4]);
        }

        // Got this method from here: https://stackoverflow.com/questions/186653/get-the-index-of-the-nth-occurrence-of-a-string
        // Returns the index of the nth occurance of a match within a string.
        public int IndexOfNthOccurance(string s, string match, int n)
        {
            int i = 1;
            int index = 0;

            while (i <= n && (index = s.IndexOf(match, index + 1)) != -1)
            {
                if (i == n)
                    return index;
                i++;
            }
            return -1;
        }
    }
}
