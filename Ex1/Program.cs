using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
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

                Console.WriteLine("The {0} {1}, has an egine size of {2}, and is travelling at {3} mph",c1.Make, c1.Model, c1.EngineSize, c1.CurrentSpd);

                Console.WriteLine("The {0} {1}, has an egine size of {2}, and is travelling at {3} mph", c2.Make, c2.Model, c2.EngineSize, c2.CurrentSpd);

            }
        }
    }
}
