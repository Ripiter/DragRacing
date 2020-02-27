using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DragRacing
{
    class Race
    {
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        readonly object _lock = new object();
        public event EventHandler printStats;

        public void Start(params Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                ThreadPool.QueueUserWorkItem(UpdateCar, cars[i]);
            }

        }
        
        void UpdateCar(object obj)
        {
            Stopwatch stopwatch = new Stopwatch();
            Car car = (Car)obj;
            double distanceTraveled = 0;
            
            stopwatch.Start();
            while (distanceTraveled < 400)
            {
                if (car.Speed < car.CarEngine.MaxSpeed)
                    UpdateSpeed(car);

                distanceTraveled = (car.Speed * ConvertToHours(stopwatch.Elapsed.TotalSeconds)) * 1000;
                if(printStats != null)
                    printStats("[Time]" + stopwatch.Elapsed.TotalSeconds + " " +
                               "Car with id " + car.Number + " Distance " + distanceTraveled + " speed " + car.Speed, new EventArgs());
            }

            if (printStats != null)
                printStats("Done car with id " + car.Number, new EventArgs());
        }

        double ConvertToHours(double seconds)
        {
            double minutes = seconds / 60;
            
            return minutes / 60;
        }

        void UpdateSpeed(Car car)
        {
            float accelerationSpeed = (car.CarEngine.TimeToFullSpeed * 1000) / car.CarEngine.MaxSpeed;
            car.Speed += 2;

            int waitTime = (int)accelerationSpeed + rnd.Next(5, 10);

            Thread.Sleep(waitTime);
        }

        
    }
}
