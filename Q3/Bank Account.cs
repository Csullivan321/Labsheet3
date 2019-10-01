using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Bank_Account
    {
        private string accnum;

        public string AccNum
        {
            get { return accnum; }
            set { accnum = value; }
        }

        private string acchold;

        public string AccHold
        {
            get { return acchold; }
            set { accnum = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public Bank_Account(string accountnumber, string accountHolder, decimal balance)
        {
            AccNum = accountnumber;
            AccHold = accountHolder;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public string GetAccountDetails()
        {
            return $"Account Number: {AccNum}" +
                $"Account Holder: {AccHold}" +
                $"Account Balance: {Balance}";

        }
        

    }
}
