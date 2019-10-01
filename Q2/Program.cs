using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car();

            c1.Make = "VW";
            c1.Model = "Golf";
            c1.CurrentSpd = "0";
            c1.EngineSize = "1.9";

            Car c2 = new Car();

            c2.Make = "Opel";
            c2.Model = "Corsa";
            c2.CurrentSpd = "0";
            c2.EngineSize = "1.0";

            c1.DisplayCarInfo();
            Console.WriteLine(c2);

            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine(c1);
        }
    }
}
