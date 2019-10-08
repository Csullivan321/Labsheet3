using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class AddingCashReg
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

        private double totalmoneycrs;

        public double TotalMoneyCrs
        {
            get { return totalmoneycrs; }
            set { totalmoneycrs = value; }
        }


        private int totalitemscrs;

        public int TotalItemsCrs
        {
            get { return totalitemscrs; }
            set { totalitemscrs = value; }
        }
        


        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;

            TotalItemsCrs++;
            TotalMoneyCrs += itemPrice;
        }
    }
}

