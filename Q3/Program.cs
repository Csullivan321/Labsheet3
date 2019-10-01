﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Bank_Account acc1 = new Bank_Account("12345678", "Tom Smith", 1000);
            Bank_Account acc2 = new Bank_Account("87654321", "Mary Mills", 2000);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc2.GetAccountDetails());

            Console.WriteLine("Adding £1000 to account 1 ");
            acc1.Deposit(1000);
            Console.WriteLine(acc1.GetAccountDetails());

            Console.WriteLine("Withdrawing £500 from account 2");
            acc2.WithDraw(500);
            Console.WriteLine(acc2.GetAccountDetails());
        }
    }
}
