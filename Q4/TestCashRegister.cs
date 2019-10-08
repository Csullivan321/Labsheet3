using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class TestCashRegister
    {
        private int numofitems;
        public int NumberOfItems
        {
            get { return numofitems; }
            set { numofitems = value; }
        }

        private double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }


        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems ++;
        }
    }
}
