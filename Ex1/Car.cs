using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
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

    }
}
