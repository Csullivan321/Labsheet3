﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCashRegister cr1 = new TestCashRegister();

            Console.WriteLine("Adding an item worth 2.70 to cash Register 1");
            Console.WriteLine("Adding an item worth 3.45 to cash Register 1");
            Console.WriteLine("Adding an item worth 5.97 to cash Register 1");
            cr1.AddItem(2.70);
            cr1.AddItem(3.45);
            cr1.AddItem(5.97);


            TestCashRegister cr2 = new TestCashRegister();
            Console.WriteLine("Adding an item worth 12.52 to Cash Register 2");
            Console.WriteLine("Adding an item worth 1.43 to Cash Register 2");
            Console.WriteLine("Adding an item worth 15.57 to Cash Register 2");
            Console.WriteLine("Adding an item worth 5.15 to Cash Register 2");
            cr2.AddItem(12.52);
            cr2.AddItem(1.43);
            cr2.AddItem(15.57);
            cr2.AddItem(5.35);

            Console.WriteLine("Cash Register 1 total : {0}", cr1.Total);
            Console.WriteLine("Cash Register 1 Number Of Items : {0}",cr1.NumberOfItems);

            Console.WriteLine("Cash Register 2 total : {0}", cr2.Total);
            Console.WriteLine("Cash Register 2 Number Of Items : {0}", cr2.NumberOfItems);
        }
    }
}
