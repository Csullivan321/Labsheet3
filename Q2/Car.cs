using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string currentspd;

        public string CurrentSpd
        {
            get { return currentspd; }
            set { currentspd = value; }
        }

        private string enginesize;

        public string EngineSize
        {
            get { return enginesize; }
            set { enginesize = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("Car make : {0} " , Make);
            Console.WriteLine("Car model : {0} " , Model);
            Console.WriteLine("Cars speed : {0} mph " , CurrentSpd);
            Console.WriteLine("Cars engine size : {0} " , EngineSize);
        }

        public override string ToString()
        {
            return
                string.Format($"Car make: {Make} " +
                             $"Car model: {Model} " +
                             $"Current speed: {CurrentSpd} " +
                             $"Cars engine size: {EngineSize} ");


        }

        public void Accelerate()
        {
            CurrentSpd += 10;
            Console.WriteLine("Current speed = {0}",CurrentSpd);
        }
    }
   
}
