using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    abstract class Engine
    {
        private float maxSpeed;

        public float MaxSpeed
        {
            get { return maxSpeed; }
            protected set { maxSpeed = value; }
        }

        private float timeToFullSpeed;

        public float TimeToFullSpeed
        {
            get { return timeToFullSpeed; }
            set { timeToFullSpeed = value; }
        }



        public Engine(float maxSpeed, float time)
        {
            this.MaxSpeed = maxSpeed;
            this.TimeToFullSpeed = time;
        }
    }
}
