using System;
using System.Diagnostics;
using System.Threading;

namespace DragRacing
{
    class Car
    {
        private float speed;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private Engine engine;

        public Engine CarEngine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Car(float speed, string color, int number, Engine curEngine)
        {
            this.Speed = speed;
            this.Color = color;
            this.Number = number;
            this.CarEngine = curEngine;
        }
    }
}
