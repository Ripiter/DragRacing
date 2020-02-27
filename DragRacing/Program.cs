using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            Engine engine1 = new JondaEngine();
            Engine engine2 = new PoyotaEngine();
            race.printStats += RacePrint;

            Car a = new Car(0, "Green", 1, engine1);
            Car b = new Car(0, "Red", 2, engine2);

            race.Start(a, b);

            Console.ReadKey();
        }

        private static void RacePrint(object sender, EventArgs e)
        {
            string msg = (string)sender;

            if(msg.Contains(" id 2"))
                Console.WriteLine(msg);
        }
    }
}
